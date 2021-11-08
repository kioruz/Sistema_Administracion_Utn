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
    public partial class ControlUsuarios : System.Web.UI.Page
    {
        NEGUsuarios usuario = new NEGUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Usuarios usuario = (Usuarios)Session["Usuario"];
                if (usuario == null)
                {
                    Response.Redirect("Login.aspx");
                }

                lblNombreUsuario.Text = usuario.Usuario;
                CargarTabla();
            }
        }
        public void CargarTabla()
        {
            gvUsuarios.DataSource = usuario.TablaUsuarios();
            gvUsuarios.DataBind();
        }
        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvUsuarios.EditIndex = -1;
            CargarTabla();
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvUsuarios.EditIndex = e.NewEditIndex;
            CargarTabla();
        }
        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            NEGUsuarios NegUs = new NEGUsuarios();

            Label lblUsuario = gvUsuarios.Rows[e.RowIndex].FindControl("lblUsuario") as Label;
            TextBox txtApellido = gvUsuarios.Rows[e.RowIndex].FindControl("tbxApellido") as TextBox;
            TextBox txtNombre = gvUsuarios.Rows[e.RowIndex].FindControl("tbxNombre") as TextBox;
            TextBox txtClave = gvUsuarios.Rows[e.RowIndex].FindControl("tbxClave") as TextBox;
            TextBox txtFechabaja = gvUsuarios.Rows[e.RowIndex].FindControl("tbxFechabaja") as TextBox;
            TextBox txtCausabaja = gvUsuarios.Rows[e.RowIndex].FindControl("tbxCausabaja") as TextBox;

            NegUs.ActualizarUsuario(lblUsuario.Text, txtApellido.Text, txtNombre.Text, txtClave.Text, txtFechabaja.Text, txtCausabaja.Text);
            gvUsuarios.EditIndex = -1;
            CargarTabla();
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;

            Response.Redirect("Login.aspx");
        }

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsuarios.PageIndex = e.NewPageIndex;
            CargarTabla();
        }
    }
}