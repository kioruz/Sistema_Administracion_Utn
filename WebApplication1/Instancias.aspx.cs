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
    public partial class Instancias : System.Web.UI.Page
    {
        NEGInstancias negins = new NEGInstancias();
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
            gv.DataSource = negins.GetTable();
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
            Label l1 = gv.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            Label l2 = gv.Rows[e.RowIndex].FindControl("tbx_Inscripcion_ID") as Label;
            TextBox t2 = gv.Rows[e.RowIndex].FindControl("tbxNombre") as TextBox;
            TextBox t3 = gv.Rows[e.RowIndex].FindControl("tbxAnio") as TextBox;
            DropDownList t4 = gv.Rows[e.RowIndex].FindControl("tbx_Estado") as DropDownList;
            TextBox t5 = gv.Rows[e.RowIndex].FindControl("tbxFechainicio") as TextBox;
            TextBox t6 = gv.Rows[e.RowIndex].FindControl("tbxFechafin") as TextBox;
          
            negins.ActualizarTabla(l1.Text, l2.Text, t2.Text, t3.Text, t4.SelectedValue, t5.Text, t6.Text);
            gv.EditIndex = -1;
            CargarTabla();
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tbx_Anio.Text) <= 0)
            {
                lbl_validacion.Text = "Ingrese un año valido";
            }
            else{
                negins.AgregarInstancia(tbx_INSCRIPCIONES.Text, tbx_Nombre.Text, tbx_Anio.Text, tbx_Estado.SelectedValue, tbx_FechaInicio.Text, tbx_FechaFin.Text);
            }
            LimpiarTextBox();
            CargarTabla();
        }
        void LimpiarTextBox()
        {
            tbx_INSCRIPCIONES.Text = string.Empty;
            tbx_Nombre.Text = string.Empty;
            tbx_Anio.Text = string.Empty;
            tbx_Estado.SelectedIndex = 0;
            tbx_FechaInicio.Text = string.Empty;
            tbx_FechaFin.Text = string.Empty;
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