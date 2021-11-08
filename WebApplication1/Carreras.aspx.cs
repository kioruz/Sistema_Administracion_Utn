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
    public partial class Carreras : System.Web.UI.Page
    {
        NEGCarreras Carrera = new NEGCarreras();
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
            gvCarreras.DataSource = Carrera.GetTable();
            gvCarreras.DataBind();
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void gvCarreras_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvCarreras.EditIndex = e.NewEditIndex;
            CargarTabla();
        }

        protected void gvCarreras_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            gvCarreras.EditIndex = -1;
            CargarTabla();
        }

        protected void gvCarreras_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lbl_ID = gvCarreras.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            Label lbl_Inscripcion = gvCarreras.Rows[e.RowIndex].FindControl("lbl_Inscripciones_ID") as Label;
            Label lbl_Tipos_Carrera = gvCarreras.Rows[e.RowIndex].FindControl("lbl_Tipos_Carrera") as Label;
            TextBox txtNombre = gvCarreras.Rows[e.RowIndex].FindControl("tbxNombre") as TextBox;
            TextBox tbxCodigoInterno = gvCarreras.Rows[e.RowIndex].FindControl("tbxCodigoInterno") as TextBox;
            TextBox txtFechabaja = gvCarreras.Rows[e.RowIndex].FindControl("tbxFechabaja") as TextBox;
            TextBox txtCausabaja = gvCarreras.Rows[e.RowIndex].FindControl("tbxCausabaja") as TextBox;

            Carrera.ActualizarTabla(lbl_ID.Text, lbl_Inscripcion.Text, lbl_Tipos_Carrera.Text, txtNombre.Text, tbxCodigoInterno.Text, txtFechabaja.Text, txtCausabaja.Text);
            gvCarreras.EditIndex = -1;
            CargarTabla();
        }
        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            Carrera.AgregarCarrera(tbxINSCRIPCIONES.Text, tbx_Tipos_Carreras.Text, tbxNombre.Text, tbxCodigoInterno.Text);
            LimpiarTextBox();
            CargarTabla();
        }
        void LimpiarTextBox()
        {
            tbxINSCRIPCIONES.Text = string.Empty;
            tbx_Tipos_Carreras.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxCodigoInterno.Text = string.Empty;
        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;

            Response.Redirect("Login.aspx");
        }

        protected void gvCarreras_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCarreras.PageIndex = e.NewPageIndex;
            CargarTabla();
        }
    }
}