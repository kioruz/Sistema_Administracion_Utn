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
    public partial class Login : System.Web.UI.Page
    {
        int time = 7;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie ckuser;
            if (!IsPostBack)
            {
                if ((ckuser = this.Request.Cookies["usuario"]) != null)
                {
                    txtUser.Text = ckuser.Value;
                }
            }
            NEGUsuarios usNeg = new NEGUsuarios();
            //Usuarios us = usNeg.GetUsuarioPass();
           // txtUser.Text = us.Usuario;
            //txtPass.Text = us.Clave;

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            /*  ClientesNEG clienNEG = new ClientesNEG();
              UsuariosNEG usNeg = new UsuariosNEG();
              CuentasNEG cuentasNEG = new CuentasNEG();

              if (CheckBox1.Checked == true)
              {
                  HttpCookie ckuser = new HttpCookie("usuario", txtUser.Text);
                  ckuser.Expires.AddDays(time);
                  this.Response.Cookies.Add(ckuser);
              }
              else
              {
                  if (this.Request.Cookies["usuario"] != null)
                  {
                      HttpCookie ckuser = new HttpCookie("usuario");
                      ckuser.Expires = DateTime.Now.AddDays(-time);
                      this.Response.Cookies.Add(ckuser);
                  }
              }
              switch (usNeg.TipoUser(txtUser.Text.ToString(), txtPass.Text.ToString()))
              {
                  case 1:
                      Server.Transfer("inicioB.aspx");
                      break;
                  case 2:
                      //Server.Transfer("inicio.aspx");
                      Session["CodCuenta"] = clienNEG.ObtenerCodCuenta(usNeg.ObtenerDNI(txtUser.Text, txtPass.Text)).ToString();
                      Session["NombreApellido"] = clienNEG.ObtenerNombreApellido(usNeg.ObtenerDNI(txtUser.Text, txtPass.Text).ToString());
                      Session["Saldo"] = cuentasNEG.ObtenerSaldo(Session["CodCuenta"].ToString());

                      Label1.Text = Session["Saldo"].ToString();
                      // Server.Transfer("Compra.aspx");
                      Server.Transfer("inicio.aspx");
                      break;
                  case 0:
                      Label1.Text = "Usuario o Contraseña incorrecto";
                      break;
              }*/


        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



    }
}