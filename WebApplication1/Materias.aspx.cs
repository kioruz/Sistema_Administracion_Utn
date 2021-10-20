﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication1
{
    public partial class Materias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla();
            }
        }
        
        public void CargarTabla()
        {
            NEGMaterias mat = new NEGMaterias();
            gv.DataSource = mat.GetTable();
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
                NEGMaterias matNeg = new NEGMaterias();
                TextBox txtID = (TextBox)gv.FooterRow.FindControl("txtId");
                TextBox txtNomb = (TextBox)gv.FooterRow.FindControl("txtnombre");
                TextBox txtFecha = (TextBox)gv.FooterRow.FindControl("txtFecha");
                TextBox txtCausa = (TextBox)gv.FooterRow.FindControl("txtCausabaja");
                


                string s = matNeg.AgregarMateria(txtID.Text, txtNomb.Text, txtFecha.Text, txtCausa.Text);

                Label1.Text = s;

                CargarTabla();
            }
        }
        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            NEGMaterias NegMat = new NEGMaterias();
            Materias mat = new Materias();
            Label l1 = gv.Rows[e.RowIndex].FindControl("lblid") as Label;
            TextBox t1 = gv.Rows[e.RowIndex].FindControl("txtNombre") as TextBox;
            TextBox t2 = gv.Rows[e.RowIndex].FindControl("txtFecha") as TextBox;
            TextBox t3 = gv.Rows[e.RowIndex].FindControl("txtCausabaja") as TextBox;
           

            NegMat.ActualizarTabla (l1.Text, t1.Text, t2.Text, t3.Text);
            gv.EditIndex = -1;
            CargarTabla();
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {

        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}