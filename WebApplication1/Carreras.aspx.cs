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



    }
}