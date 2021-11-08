<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anexos.aspx.cs" Inherits="WebApplication1.Anexos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Anexos</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link type="text/css" rel="stylesheet" href="Css/FontFamily.css" />
    <link type="text/css" rel="stylesheet" href="Css/Estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="flex-body">
            <header class="header">
                <div class="header-container">
                    <div class="header-item">
                        <a href="#">
                            <img class="logo" alt="Logo UTN" src="Logo/logo-utn.png" />
                        </a>
                    </div>
                    <div class="header-item">
                        <h2 class="titulo">Sistema de Administración Web</h2>
                    </div>
                    <div class="header-item">
                        <div>
                            Usuario:
                            <asp:Label ID="lblNombreUsuario" Font-Bold="true" runat="server"></asp:Label>
                        </div>
                        <div class="form-btn">
                            <asp:Button ID="btnVolver" CssClass="boton" runat="server" OnClick="btnVolver_Click" Text="Volver" />
                            <asp:Button ID="btnCerrarSesion" CssClass="boton" runat="server" OnClick="btnCerrarSesion_Click" Text="Cerrar Sesión" />
                        </div>
                    </div>
                </div>
            </header>
            <main class="flex-main">
                <div class="flex-form">
                    <div class="nav">
                    </div>
                    <div>
                        <h1 class="titulo">Anexos</h1>
                    </div>
                    <div>
                        <hr class="hr" />
                    </div>
                    <div class="rows">
                        <asp:GridView ID="gv" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" AutoGenerateColumns="False" AllowSorting="True" AllowPaging="True" PageSize="12" OnPageIndexChanging="gv_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="Controles">
                                    <ItemTemplate>
                                        <asp:Button Text="Editar" ID="Editbutton" CssClass="botonGrid" runat="server" CommandName="Edit" />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:Button Text="Update" ID="UpdateButton" CssClass="botonGrid" runat="server" CommandName="Update" />
                                        <asp:Button Text="Cancel" ID="CancelButton" CssClass="botonGrid" runat="server" CommandName="Cancel" />
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
                                        <asp:Label ID="lbl_ID" runat="server" Text='<%# Eval("id") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre">
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                                    </FooterTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre") %>' />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtNombre" runat="server" Text='<%# Eval("Nombre") %>' />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Fecha">
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                                    </FooterTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblFecha" runat="server" Text='<%# Eval("Fechabaja","{0:dd/MM/yyyy}") %>' />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtFechabaja" runat="server" Text='<%# Eval("Fechabaja") %>' />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Causabaja">
                                    <FooterTemplate>
                                        <asp:TextBox ID="txtCausabaja" runat="server"></asp:TextBox>
                                    </FooterTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblCausabaja" runat="server" Text='<%# Eval("Causabaja") %>' />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtCausabaja" runat="server" Text='<%# Eval("Causabaja") %>' />
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
                        <div class="col">
                            <div>
                                <h4 class="titulo">Agregar Anexo</h4>
                            </div>
                            <div>
                                <hr class="hr" />
                            </div>
                            <div class="form-textbox">
                                <label for="tbxNombre">Nombre:</label>
                                <asp:TextBox ID="tbxNombre" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFV_Nombre" CssClass="label-error" runat="server" ControlToValidate="tbxNombre" ErrorMessage="Ingrese un Nombre" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-btn">
                                <asp:Button ID="btn_aceptar" runat="server" CssClass="boton" OnClick="btn_aceptar_Click" Text="Agregar" ValidationGroup="grupo2" Width="140px" />
                            </div>
                        </div>
                    </div>
                </div>
            </main>
            <footer class="footer">
                <div class="footer-container">
                    <hr class="hr" />
                    <span class="copyright">Copyright © 2021 Universidad Tecnológica Nacional</span>
                </div>
            </footer>
        </div>
    </form>
</body>
</html>

