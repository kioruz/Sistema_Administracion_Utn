<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <h1>Sistema de Administración Web</h1>
            <asp:Label ID="lblUser" runat="server" Text="Usuario"></asp:Label>
            <br />
            <asp:TextBox ID="tbxUser" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Contraseña"></asp:Label>
            <br />
            <asp:TextBox ID="tbxPassword" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="btnIniciarSesion" runat="server" OnClick="btn_IniciarSesion" Text="Iniciar Sesión" ValidateRequestMode="Disabled" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblRegister" runat="server" Text="No posees cuenta?. REGISTRATE!"></asp:Label>
        <br />
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Registrarse" />
        <br />
        <br />
    </form>
</body>
</html>
