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
        <asp:GridView ID="gvCarreras" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:TemplateField HeaderText="IDCarrera">
                    <ItemTemplate>
                        <asp:Label ID="lbl_IDCarrera" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Inscripciones_id">
                    <ItemTemplate>
                        <asp:Label ID="lbl_Inscripciones_id" runat="server" Text='<%# Bind("INSCRIPCIONES_Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tipos_Carreras_id">
                    <ItemTemplate>
                        <asp:Label ID="lbl_Tipo_Carrera_id" runat="server" Text='<%# Bind("TIPOS_CARRERAS_Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <ItemTemplate>
                        <asp:Label ID="lbl_Nombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CodigoInterno">
                    <ItemTemplate>
                        <asp:Label ID="lbl_Codigointerno" runat="server" Text='<%# Bind("Codigointerno") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IdTipoCarrera">
                    <ItemTemplate>
                        <asp:Label ID="lbl_idtipocarrera" runat="server" Text='<%# Bind("Idtipocarrera") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IdInscripcion">
                    <ItemTemplate>
                        <asp:Label ID="lbl_Inscripcion" runat="server" Text='<%# Bind("Idinscripcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FechaBaja">
                    <ItemTemplate>
                        <asp:Label ID="lbl_Fechabaja" runat="server" Text='<%# Bind("Fechabaja") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CausaBaja">
                    <ItemTemplate>
                        <asp:Label ID="lbl_causabaja" runat="server" Text='<%# Bind("Causabaja") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    </form>
</body>
</html>
