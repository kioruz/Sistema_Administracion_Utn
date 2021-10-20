using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication1
{
    public partial class ControlUsuarios : System.Web.UI.Page
    {
        NEGUsuarios usuario = new NEGUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTabla();
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
        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                CargarTabla();
            }
        }
        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}