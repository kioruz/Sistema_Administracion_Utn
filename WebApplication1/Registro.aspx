<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebApplication1.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro</title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 135px;
            font-size: x-large;
            height: 31px;
        }
        .auto-style6 {
            font-size: large;
            height: 31px;
        }
        .auto-style8 {
            width: 135px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style2 {
            width: 135px;
        }
        .auto-style3 {
            width: 135px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">Registrarse</td>
                </tr>
                <tr>
                    <td class="auto-style8">Nombre:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="tbx_Nombre" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="tbx_Nombre" ErrorMessage="Ingrese el nombre" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Apellido</td>
                    <td>
                        <asp:TextBox ID="tbx_Apellido" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre0" runat="server" ControlToValidate="tbx_Apellido" ErrorMessage="Ingrese el apellido" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Usuario</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbx_Usuario" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="tbx_Usuario" ErrorMessage="Ingrese el usuario" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Contraseña:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbx_Pass" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre3" runat="server" ControlToValidate="tbx_Pass" EnableTheming="True" ErrorMessage="Ingrese contraseña" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Repetir Contraseña:</td>
                    <td>
                        <asp:TextBox ID="tbx_PassRepetida" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbx_Pass" ControlToValidate="tbx_PassRepetida" ErrorMessage="Las password no coinciden" ValidationGroup="grupo2"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_Inicio" runat="server" OnClick="btn_Inicio_Click" Text="Login" />
                    </td>
                    <td>
                        <asp:Button ID="btn_Aceptar" runat="server" OnClick="btn_Aceptar_Click" onClientClick="if(Page_ClientValidate('grupo2'))" Text="Aceptar" ValidationGroup="grupo2" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
