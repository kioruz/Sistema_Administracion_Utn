<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carreras.aspx.cs" Inherits="WebApplication1.Carreras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
            <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" style="text-align: center" Text="Volver" />
            &nbsp;&nbsp;&nbsp;
            </p>
            <p style="margin-left: 920px">
            Usuario:
            <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
