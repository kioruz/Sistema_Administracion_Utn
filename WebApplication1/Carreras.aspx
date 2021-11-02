<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carreras.aspx.cs" Inherits="WebApplication1.Carreras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="Css/FontFamily.css" />
    <link type="text/css" rel="stylesheet" href="Css/Estilos.css" />
</head>
<body class="flex-body">
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
    <main class="flex-main">
        <form id="form1" runat="server">
            <div>
                <p>
                    <asp:Button ID="btnVolver" CssClass="boton" runat="server" OnClick="btnVolver_Click" Style="text-align: center" Text="Volver" />
                    &nbsp;<asp:Button ID="btnCerrarSesion" CssClass="boton" runat="server" OnClick="btnCerrarSesion_Click" Style="text-align: center" Text="Cerrar Sesión" />
                </p>
                <p style="margin-left: 920px">
                    Usuario:
            <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
                </p>
            </div>
            <asp:GridView ID="gvCarreras" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCancelingEdit="gvCarreras_RowCancelingEdit" OnRowEditing="gvCarreras_RowEditing" OnRowUpdating="gvCarreras_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Editar">
                        <EditItemTemplate>
                            <asp:Button ID="UpdateButton" CssClass="botonGrid" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" CssClass="botonGrid" runat="server" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" CssClass="botonGrid" runat="server" CommandName="Edit" Text="Editar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IDCarrera">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_ID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_IDCarrera" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Inscripciones_ID">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_Inscripciones_ID" runat="server" Text='<%# Eval("INSCRIPCIONES_Id") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_Inscripciones_ID" runat="server" Text='<%# Eval("INSCRIPCIONES_Id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tipos_Carreras_id">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_Tipos_Carrera" runat="server" Text='<%# Eval("TIPO_CARRERAS_Id") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_Tipo_Carrera_id" runat="server" Text='<%# Bind("TIPO_CARRERAS_Id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxNombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_Nombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CodigoInterno">
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxCodigoInterno" runat="server" Text='<%# Eval("Codigointerno") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_Codigointerno" runat="server" Text='<%# Bind("Codigointerno") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FechaBaja">
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxFechabaja" runat="server" Text='<%# Eval("Fechabaja") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_Fechabaja" runat="server" Text='<%# Bind("Fechabaja") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CausaBaja">
                        <EditItemTemplate>
                            <asp:TextBox ID="tbxCausabaja" runat="server" Text='<%# Eval("Causabaja") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_causabaja" runat="server" Text='<%# Bind("Causabaja") %>'></asp:Label>
                        </ItemTemplate>
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
            <div>
                <br />
                <br />
                <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3"><strong>Agregar Carrera</strong></td>
                        <td class="auto-style11"></td>
                    </tr>
                    <tr>
                        <td class="auto-style5">Inscripcion ID:</td>
                        <td class="auto-style6">
                            <asp:TextBox ID="tbxINSCRIPCIONES" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RFV_Inscripcion_ID" runat="server" ControlToValidate="tbxINSCRIPCIONES" ErrorMessage="Ingrese una inscripción existente" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">Tipo carrera ID:</td>
                        <td class="auto-style6">
                            <asp:TextBox ID="tbx_Tipos_Carreras" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RFV_Tipo_Carreras_ID" runat="server" ControlToValidate="tbx_Tipos_Carreras" ErrorMessage="Ingrese un Tipo de Carrera Existente" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">Nombre:</td>
                        <td class="auto-style6">
                            <asp:TextBox ID="tbxNombre" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="tbxNombre" ErrorMessage="Ingrese un Nombre" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">CodigoInterno:</td>
                        <td class="auto-style6">
                            <asp:TextBox ID="tbxCodigoInterno" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RFV_CodigoInterno" runat="server" ControlToValidate="tbxCodigoInterno" ErrorMessage="Ingrese un Código Interno" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:Button ID="btn_aceptar" CssClass="boton" runat="server" OnClick="btn_aceptar_Click" Text="Agregar" ValidationGroup="grupo2" Width="140px" />
            </div>
        </form>
    </main>
    <footer class="footer">
        <div class="footer-container">
            <hr class="hr" />
            <span class="copyright">Copyright © 2021 Universidad Tecnológica Nacional</span>
        </div>
    </footer>
</body>
</html>
