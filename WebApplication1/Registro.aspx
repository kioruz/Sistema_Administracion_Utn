<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebApplication1.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Registro</title>
    <link type="text/css" rel="stylesheet" href="Css/FontFamily.css" />
    <link rel="stylesheet" href="Css/Estilos.css" />
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
                    <h1 class="titulo">Registrarse</h1>
                </div>
                <div>
                    <hr />
                </div>
                <div>
                    <div class="rows">
                        <div class="col">
                            <div class="form-textbox">
                                <label for="tbx_Nombre">Nombre</label>
                                <asp:TextBox ID="tbx_Nombre" CssClass="textbox" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvNombre" CssClass="label-error" runat="server" ControlToValidate="tbx_Nombre" ErrorMessage="Ingrese el nombre" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                            </div>

                            <div class="form-textbox">
                                <label for="tbx_Pass">Contraseña:</label>
                                <asp:TextBox ID="tbx_Pass" CssClass="textbox" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvNombre3" CssClass="label-error" runat="server" ControlToValidate="tbx_Pass" EnableTheming="True" ErrorMessage="Ingrese contraseña" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-textbox">
                                <label for="tbx_Usuario">Usuario</label>
                                <asp:TextBox ID="tbx_Usuario" CssClass="textbox" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvUsuario" CssClass="label-error" runat="server" ControlToValidate="tbx_Usuario" ErrorMessage="Ingrese el usuario" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col">
                            <div class="form-textbox">
                                <label for="tbx_Apellido">Apellido</label>
                                <asp:TextBox ID="tbx_Apellido" CssClass="textbox" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvNombre0" CssClass="label-error" runat="server" ControlToValidate="tbx_Apellido" ErrorMessage="Ingrese el apellido" ValidationGroup="grupo2"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-textbox">
                                <label for="tbx_PassRepetida">Repetir Contraseña:</label>
                                <asp:TextBox ID="tbx_PassRepetida" CssClass="textbox" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" CssClass="label-error" runat="server" ControlToCompare="tbx_Pass" ControlToValidate="tbx_PassRepetida" ErrorMessage="Las password no coinciden" ValidationGroup="grupo2"></asp:CompareValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-btn">
                        <asp:Button ID="btn_Inicio" CssClass="btn" runat="server" OnClick="btn_Inicio_Click" Text="Login" />
                        <asp:Button ID="btn_Aceptar" CssClass="btn" runat="server" OnClick="btn_Aceptar_Click" OnClientClick="if(Page_ClientValidate('grupo2'))" Text="Aceptar" ValidationGroup="grupo2" />
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
