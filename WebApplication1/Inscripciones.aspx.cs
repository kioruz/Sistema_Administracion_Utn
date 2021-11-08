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
    public partial class Inscripciones : System.Web.UI.Page
    {
        NEGInscripciones NegInc = new NEGInscripciones();
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
            NEGInscripciones insc = new NEGInscripciones();
            gv.DataSource = insc.GetTable();
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
            TextBox txtNombre = gv.Rows[e.RowIndex].FindControl("tbxNombre") as TextBox;
            TextBox txtFechabaja = gv.Rows[e.RowIndex].FindControl("tbxFechabaja") as TextBox;
            TextBox txtCausabaja = gv.Rows[e.RowIndex].FindControl("tbxCausabaja") as TextBox;

            NegInc.ActualizarTabla(lbl_ID.Text, txtNombre.Text, txtFechabaja.Text, txtCausabaja.Text);
            gv.EditIndex = -1;
            CargarTabla();
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            NegInc.AgregarInscripcion(tbxNombre.Text);
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