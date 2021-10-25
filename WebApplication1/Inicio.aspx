<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplication1.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 1040px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#CCFFFF" DynamicHorizontalOffset="2" EnableTheming="True" Font-Names="Verdana" Font-Size="Medium" ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="16px" style="text-align: left; font-size: xx-large" >
               <DynamicHoverStyle BackColor="Aqua" />
                <DynamicMenuStyle BackColor="#CCFFFF" HorizontalPadding="10px" VerticalPadding="10px" />
                <Items>
                    <asp:MenuItem Text="Maestro" Value="Maestro">
                        <asp:MenuItem NavigateUrl="~/ControlUsuarios.aspx" Text="Usuarios" Value="Usuarios"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Modalidades.aspx" Text="Modalidades" Value="Modalidades"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Turnos.aspx" Text="Turnos" Value="Turnos"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Anexos.aspx" Text="Anexos" Value="Anexos"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Materias.aspx" Text="Materias" Value="Materias"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Carreras.aspx" Text="Carreras" Value="Carreras"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Tipo_Carreras.aspx" Text="Tipo_Carreras" Value="Tipo_Carreras"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Ingreso" Value="Ingreso">
                        <asp:MenuItem NavigateUrl="~/Inscripciones.aspx" Text="Inscripciones" Value="Inscripciones"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Instancias.aspx" Text="Instancias" Value="Instancias"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticMenuStyle HorizontalPadding="20px" VerticalPadding="20px" />
            </asp:Menu>
        &nbsp;&nbsp;&nbsp;
            <p class="auto-style1">
            Usuario:
            <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
