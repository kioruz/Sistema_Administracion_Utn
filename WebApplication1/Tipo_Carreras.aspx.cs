using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidad;

namespace WebApplication1
{
    public partial class Tipo_Carreras : System.Web.UI.Page
    {
        NEGTipos_Carreras tpNEG = new NEGTipos_Carreras();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            Usuarios usuario = (Usuarios)Session["Usuario"];

            if (usuario == null)
            {
                Response.Redirect("Login.aspx");
            }

            lblNombreUsuario.Text = usuario.Usuario;

            if (!IsPostBack)
            {
                CargarTabla();
            }
        }

        public void CargarTabla()
        {

            gv.DataSource = tpNEG.GetTable();
            gv.DataBind();
        }

        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv.EditIndex = -1;
            CargarTabla();
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
            CargarTabla();
        }
        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lbl_ID = gv.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox txt_Nombre = gv.Rows[e.RowIndex].FindControl("tbxNombre") as TextBox;
            TextBox txt_Fecha = gv.Rows[e.RowIndex].FindControl("tbxFecha") as TextBox;
            TextBox txt_Causa = gv.Rows[e.RowIndex].FindControl("tbxCausabaja") as TextBox;

            tpNEG.ActualizarTabla(lbl_ID.Text, txt_Nombre.Text, txt_Fecha.Text, txt_Causa.Text);
            gv.EditIndex = -1;
            CargarTabla();
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            tpNEG.AgregarTipoCarrera(tbxNombre.Text);
            tbxNombre.Text = string.Empty;
            CargarTabla();
        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;

            Response.Redirect("Login.aspx");
        }

        protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv.PageIndex = e.NewPageIndex;
            CargarTabla();
        }
    }
}