using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Negocio;


namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_IniciarSesion(object sender, EventArgs e)
        {
            if (tbxUser.Text.Trim().Length == 0 || tbxPassword.Text.Trim().Length == 0)
            {
                lblUsuario.Text = "No se aceptan campos vacíos.";
            }
            else
            {
                NEGUsuarios usuario = new NEGUsuarios();
                String username = tbxUser.Text;
                String pass = usuario.GetMD5(tbxPassword.Text);
                Usuarios user = usuario.login(username,pass);
                if (user == null)
                {
                    lblUsuario.Text = "Usuario y/o contraseña incorrecto.";
                    tbxPassword.Text = string.Empty;
                    tbxUser.Text = string.Empty;
                }
                else
                {
                    Session["Usuario"] = user;
                    Response.Redirect("Inicio.aspx");
                }
            }
        }
    }
}
