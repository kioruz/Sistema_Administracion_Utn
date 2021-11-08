<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplication1.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sistema de Administración Web</title>
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
                            <asp:Button ID="btnCerrarSesion" CssClass="boton" runat="server" OnClick="btnCerrarSesion_Click" Text="Cerrar Sesión" />
                        </div>
                    </div>
                </div>
            </header>
            <main class="flex-main">
                <div class="nav">
                    <div>
                        <asp:Menu ID="Menu1" runat="server" BackColor="#F2F2F0" DynamicHorizontalOffset="2" EnableTheming="True" Font-Names="Verdana" Font-Size="Medium" ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="16px" Style="text-align: left; font-size: xx-large">
                            <DynamicHoverStyle   BorderStyle="Solid" BorderColor="White" BackColor="White" />
                            <DynamicMenuStyle BackColor="#F2F2F0" HorizontalPadding="10px" VerticalPadding="10px" />
                            <Items>
                                <asp:MenuItem Text="Maestro" Value="Maestro">
                                    <asp:MenuItem NavigateUrl="~/ControlUsuarios.aspx" Text="Usuarios" Value="Usuarios"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/Modalidades.aspx" Text="Modalidades" Value="Modalidades"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/Turnos.aspx" Text="Turnos" Value="Turnos"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/Anexos.aspx" Text="Anexos" Value="Anexos"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/Materias.aspx" Text="Materias" Value="Materias"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/Carreras.aspx" Text="Carreras" Value="Carreras"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/Tipo_Carreras.aspx" Text="Tipo de Carreras" Value="Tipo_Carreras"></asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="Ingreso" Value="Ingreso">
                                    <asp:MenuItem NavigateUrl="~/Inscripciones.aspx" Text="Inscripciones" Value="Inscripciones"></asp:MenuItem>
                                    <asp:MenuItem NavigateUrl="~/Instancias.aspx" Text="Instancias" Value="Instancias"></asp:MenuItem>
                                </asp:MenuItem>
                            </Items>
                            <StaticMenuStyle HorizontalPadding="20px" VerticalPadding="20px" />
                        </asp:Menu>
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
