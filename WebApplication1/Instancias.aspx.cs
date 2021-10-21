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
            NEGInstancias NEGINS = new NEGInstancias();
            gv.DataSource = NEGINS.GetTable();
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

        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                NEGInstancias negins = new NEGInstancias();
                //TextBox txtid = (TextBox)gv.FooterRow.FindControl("txtId");
                TextBox t1 = (TextBox)gv.FooterRow.FindControl("txtINSCRIPCIONES_Id");
                TextBox t2 = (TextBox)gv.FooterRow.FindControl("txtNombre");
                TextBox t3 = (TextBox)gv.FooterRow.FindControl("txtIdinscripcion");
                TextBox t4 = (TextBox)gv.FooterRow.FindControl("txtAnio");
                TextBox t5 = (TextBox)gv.FooterRow.FindControl("txtNroinscripcion");
                TextBox t6 = (TextBox)gv.FooterRow.FindControl("txtEstado");
                TextBox t7 = (TextBox)gv.FooterRow.FindControl("txtFechainicio");
                TextBox t8 = (TextBox)gv.FooterRow.FindControl("txtFechafin");
                


                negins.AgregarInstancia(t1.Text , t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text);

                CargarTabla();
            }
        }
        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            NEGInstancias negins = new NEGInstancias();
     
            Label l1 = gv.Rows[e.RowIndex].FindControl("lblid") as Label;
            TextBox t1 = gv.Rows[e.RowIndex].FindControl("txtINSCRIPCIONES_Id") as TextBox;
            TextBox t2 = gv.Rows[e.RowIndex].FindControl("txtNombre") as TextBox;
            TextBox t3 = gv.Rows[e.RowIndex].FindControl("txtIdinscripcion") as TextBox;
            TextBox t4 = gv.Rows[e.RowIndex].FindControl("txtAnio") as TextBox;
            TextBox t5 = gv.Rows[e.RowIndex].FindControl("txtNroinscripcion") as TextBox;
            TextBox t6 = gv.Rows[e.RowIndex].FindControl("txtEstado") as TextBox;
            TextBox t7 = gv.Rows[e.RowIndex].FindControl("txtFechainicio") as TextBox;
            TextBox t8 = gv.Rows[e.RowIndex].FindControl("txtFechafin") as TextBox;
          

            negins.ActualizarTabla(l1.Text, t1.Text, t2.Text, t3.Text, int.Parse(t4.Text), t5.Text, t6.Text, t7.Text, t8.Text);
            gv.EditIndex = -1;
            CargarTabla();
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}