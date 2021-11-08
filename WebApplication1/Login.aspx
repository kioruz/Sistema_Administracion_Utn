<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Inicio de Sesión</title>
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
                <h2 class="titulo">Sistema de Administración Web</h2>
            </div>
        </div>
    </header>
    <main class="flex-main">
        <form id="form1" runat="server">
            <div class="flex-form">
                <div>
                    <h1 class="titulo">Inicio de Sesión</h1>
                </div>
                <div>
                    <hr class="hr" />
                </div>
                <div>
                    <div class="form-textbox">
                        <asp:Label ID="lblUser" runat="server" Text="Usuario" AssociatedControlID="tbxUser"></asp:Label>
                        <asp:TextBox ID="tbxUser" CssClass="textbox" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-textbox">
                        <asp:Label ID="lblPassword" runat="server" Text="Contraseña" AssociatedControlID="tbxPassword"></asp:Label>
                        <asp:TextBox ID="tbxPassword" TextMode="Password" CssClass="textbox" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-btn">
                        <asp:Button ID="btnIniciarSesion" CssClass="btn" runat="server" OnClick="btn_IniciarSesion" Text="Iniciar Sesión" ValidateRequestMode="Disabled" />
                    </div>
                    <div class="msj-error">
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </div>
                    <div class="form-btn">
                        <asp:HyperLink ID="HlinkRegistrarse" CssClass="hyperlink" NavigateUrl="~/Registro.aspx" runat="server">No posees cuenta?. ¡REGISTRATE!</asp:HyperLink>
                    </div>
                </div>
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
