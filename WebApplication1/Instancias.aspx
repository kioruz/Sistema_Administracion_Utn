<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instancias.aspx.cs" Inherits="WebApplication1.Instancias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link type="text/css" rel="stylesheet" href="Css/FontFamily.css"/>
        <link type="text/css" rel="stylesheet" href="Css/Estilos.css"/>
<%--    <style>
        .boton{
            background-color: #1c819f;
            color: white;
            padding: 5px 10px; 
            cursor: pointer;
            border-radius: 50px;
            border: none; 
           
            transition: 0.5s;

            /*Agregados(Para que así se vea bien, originalmente la clase contiene lo de arriba nada más)*/
            margin: 0px 5px;
        }

        .centrarVertical {
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .centrarHorizontal{
            display: flex;
            flex-direction: row;
            align-items: center;
        }

        .spaceAround{
            display: flex;
            flex-direction: row;
            justify-content: space-around;
            min-width: 1200px;
        }

         .usuarioActual{
            font-weight: bold;
        }

         .conteinerAgregar{
             border: 1px solid #000;
             padding: 5px;
             display: flex;
             flex-direction: column;
             align-items: center;
         }
      
         /*tr = fila */
         /*auto-style6 = conteinerInput / error input */
        .auto-style6{
            display: flex;
            flex-direction: column;
        }
        tr{
            display: flex;
            flex-direction: row;
           justify-content: space-between;
        }

        td{
            width: 50%;
        }

        .inputTamanio{
            width: 95%;
        }


        /*Titulo de la tabla*/
        .tituloTable{
            text-align: center;
            margin-bottom: 20px;
        }

        .auto-style3{
             width: 100%;
        }
        /*Fin Titulo de la tabla*/

    </style>--%>
</head>
<body>
    <header class="header">
        <div class="header-container">
            <div class="header-item">
                <a href="#">
                    <img class="logo" alt="Logo UTN" src="Logo/logo-utn.png" />
                </a>
            </div>
            <div class="header-item">
                <h2>Sistema de Administración Web</h2>
            </div>
        </div>
    </header>
    <form id="form1" runat="server" class="centrarVertical">
        <div>
            <div class="spaceAround">
                <div class="centrarHorizontal">
                     <asp:Button ID="btnVolver0" CssClass="boton" runat="server" OnClick="btnVolver_Click"  Text="Volver" />
            <asp:Button ID="btnCerrarSesion" CssClass="boton" runat="server" OnClick="btnCerrarSesion_Click"  Text="Cerrar Sesión" />
                </div>
            <p>
            Usuario:
            <asp:Label ID="lblNombreUsuario" runat="server" CssClass="usuarioActual"></asp:Label>
            </p>
            </div>
            <br />
            <asp:GridView ID="gv" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" AutoGenerateColumns="False" AllowSorting="True">
                <Columns>
                    <asp:TemplateField HeaderText="Controles">

                        <ItemTemplate>

                            <asp:Button text="Editar" ID ="Editbutton" CssClass="botonGrid" runat="server" CommandName="Edit" />

                        </ItemTemplate>
                        <EditItemTemplate>
                               <asp:Button text="Update" ID ="UpdateButton" CssClass="botonGrid" runat="server" CommandName="Update" />
                               <asp:Button text="Cancel" ID ="CancelButton" CssClass="botonGrid" runat="server" CommandName="Cancel" />


                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ID">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_ID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="INSCRIPCIONES_Id">
                        <FooterTemplate>
                            <asp:TextBox ID="txtINSCRIPCIONES_Id" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblINSCRIPCIONES_Id" runat="server" Text='<%# Eval("INSCRIPCIONES_Id") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="tbx_Inscripcion_ID" runat="server" Text='<%# Eval("INSCRIPCIONES_Id") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre">
                        <FooterTemplate>
                            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxNombre" runat="server" Text ='<%# Eval("Nombre") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Anio">
                        <FooterTemplate>
                            <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAnio" runat="server" Text='<%# Eval("Anio") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxAnio" runat="server" Text ='<%# Eval("Anio") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Estado">
                        <FooterTemplate>
                            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("Estado") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="tbx_Estado" runat="server">
                                <asp:ListItem>Espera</asp:ListItem>
                                <asp:ListItem>Abierta</asp:ListItem>
                                <asp:ListItem>Cerrado</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Fechainicio">
                         <FooterTemplate>
                             <asp:TextBox ID="txtFechainicio" runat="server"></asp:TextBox>
                         </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFechainicio" runat="server"   Text='<%# Eval("Fechainicio","{0:dd/MM/yyyy}") %>' />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxFechainicio" runat="server"  Text ='<%# Eval("Fechainicio","{0:dd/MM/yyyy}") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Fechafin">
                         <FooterTemplate>
                             <asp:TextBox ID="txtFechafin" runat="server"></asp:TextBox>
                         </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFechafin" runat="server"  Text='<%# Eval("Fechafin") %>' />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxFechafin" runat="server"   Text ='<%# Eval("Fechafin") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>      

           
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            
            <br />
            <br />
            
        </div>
        <div class="conteinerAgregar">
            <br />
            <br />
            <br />
            <table class="tablaAgregar">
                <tr class="tituloTable">
                    <td class="auto-style3"><strong>Agregar Carrera</strong></td>
                    
                </tr>
                <tr>
                    <td class="auto-style5">Inscripcion ID:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_INSCRIPCIONES" runat="server" CssClass="inputTamanio"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_Inscripcion_ID" runat="server" ControlToValidate="tbx_INSCRIPCIONES" ErrorMessage="Ingrese una inscripción existente" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Nombre:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_Nombre" runat="server" CssClass="inputTamanio"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="tbx_Nombre" ErrorMessage="Ingrese un Nombre" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Anio:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_Anio" runat="server" CssClass="inputTamanio"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_Anio" runat="server" ControlToValidate="tbx_Anio" ErrorMessage="Ingrese un Año" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Estado:</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="tbx_Estado" runat="server" CssClass="inputTamanio">
                            <asp:ListItem>Espera</asp:ListItem>
                            <asp:ListItem>Abierta</asp:ListItem>
                            <asp:ListItem>Cerrado</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RFV_Estado" runat="server" ControlToValidate="tbx_Estado" ErrorMessage="Ingrese un Estado" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Fecha Inicio:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_FechaInicio" runat="server" TextMode="Date" CssClass="inputTamanio"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_FechaInicio" runat="server" ControlToValidate="tbx_FechaInicio" ErrorMessage="Ingrese una fecha Inicio" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Fecha Fin:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_FechaFin" runat="server" TextMode="Date" CssClass="inputTamanio"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_FechaFin" runat="server" ControlToValidate="tbx_FechaFin" ErrorMessage="Ingrese una Fecha Fin" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Button ID="btn_aceptar" runat="server" CssClass="boton" OnClick="btn_aceptar_Click" Text="Agregar" ValidationGroup="grupo2" Width="140px" />
        </div>
    </form>
     <footer class="footer">
        <div class="footer-container">
            <hr class="hr" />
            <span class="copyright">Copyright © 2021 Universidad Tecnológica Nacional</span>
        </div>
    </footer>
</body>
</html>

