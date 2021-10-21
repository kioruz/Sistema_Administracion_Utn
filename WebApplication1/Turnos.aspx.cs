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
    public partial class Turnos : System.Web.UI.Page
    {
        NEGTurnos turnoNEG = new NEGTurnos();
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

            gv.DataSource = turnoNEG.GetTable();
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

                TextBox txtID = (TextBox)gv.FooterRow.FindControl("txtId");
                TextBox txtNomb = (TextBox)gv.FooterRow.FindControl("txtnombre");
                TextBox txtFecha = (TextBox)gv.FooterRow.FindControl("txtFecha");
                TextBox txtCausa = (TextBox)gv.FooterRow.FindControl("txtCausabaja");

                turnoNEG.AgregarTurno(txtID.Text, txtNomb.Text, txtFecha.Text, txtCausa.Text);

                CargarTabla();
            }
        }
        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            Turnos Turno = new Turnos();
            Label l1 = gv.Rows[e.RowIndex].FindControl("lblid") as Label;
            TextBox t1 = gv.Rows[e.RowIndex].FindControl("txtNombre") as TextBox;
            TextBox t2 = gv.Rows[e.RowIndex].FindControl("txtFecha") as TextBox;
            TextBox t3 = gv.Rows[e.RowIndex].FindControl("txtCausabaja") as TextBox;


            turnoNEG.ActualizarTabla(l1.Text, t1.Text, t2.Text, t3.Text);
            gv.EditIndex = -1;
            CargarTabla();
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}