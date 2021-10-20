<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlUsuarios.aspx.cs" Inherits="WebApplication1.ControlUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" style="text-align: center" Text="Volver" />
            <br />
            <br />
            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowCommand="gv_RowCommand" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Editar">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Usuario">
                        <ItemTemplate>
                            <asp:Label ID="lblUsuario" runat="server" Text='<%# Eval("Usuario") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Apellido">
                        <ItemTemplate>
                            <asp:Label ID="lblApellido" runat="server" Text='<%# Eval("Apellido") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Clave">
                        <ItemTemplate>
                            <asp:Label ID="lblClave" runat="server" Text='<%# Eval("Clave") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fechabaja">
                        <ItemTemplate>
                            <asp:Label ID="lblFechabaja" runat="server" Text='<%# Eval("Fechabaja") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Causabaja">
                        <ItemTemplate>
                            <asp:Label ID="lblCausabaja" runat="server" Text='<%# Eval("Causabaja") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
