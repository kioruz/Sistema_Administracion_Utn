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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            NEGUsuarios usuario = new NEGUsuarios();
            Usuarios user = new Usuarios();

            if (tbx_Pass.Text == tbx_PassRepetida.Text) 
            {
                user.Usuario = tbx_Usuario.Text;
                user.Apellido = tbx_Apellido.Text;
                user.Nombre = tbx_Nombre.Text;
                user.Clave = usuario.GetMD5(tbx_Pass.Text);

                usuario.AgregarUsuario(user);
                try
                {
                    Response.Write(@"<script language=javascript>(()=>{alert('Te has registrado con exito.');window.location.href = 'Login.aspx';})()</script>");
                }
                catch
                {
                    Response.Write("<script language=javascript>alert('Error al registrar.')</script>");
                }

                tbx_Nombre.Text = "";
                tbx_Apellido.Text = "";
                tbx_Usuario.Text = "";
                tbx_Pass.Text = "";
                tbx_PassRepetida.Text = "";
            }
        }
        protected void btn_Inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;

            Response.Redirect("Login.aspx");
        }
    }
}