﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="WebApplication1.Materias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: 50pt;
            color: #3399FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style1">
            Materias</div>

            
            <br />
            <asp:GridView ID="gv" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" ShowFooter="True" OnSelectedIndexChanged="gv_SelectedIndexChanged" AllowSorting="True">
                <Columns>
                    <asp:TemplateField HeaderText="Controles">

                        <ItemTemplate>

                            <asp:Button text="Editar" ID ="Editbutton" runat="server" CommandName="Edit" />

                        </ItemTemplate>
                        <EditItemTemplate>
                               <asp:Button text="Update" ID ="UpdateButton" runat="server" CommandName="Update" />
                               <asp:Button text="Cancel" ID ="CancelButton" runat="server" CommandName="Cancel" />


                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ID">
                        <FooterTemplate>
                            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("id") %>' />

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
                            <asp:TextBox ID="txtNombre" runat="server" Text ='<%# Eval("Nombre") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Fecha">
                         <FooterTemplate>
                             <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                         </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFecha" runat="server"   Text='<%# Eval("Fechabaja","{0:dd/MM/yyyy}") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFecha" runat="server"   Text ='<%# Eval("Fechabaja") %>' />
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
                            <asp:TextBox ID="txtCausabaja" runat="server" Text ='<%# Eval("Causabaja") %>' />
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
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/InicioB.aspx">Volver</asp:HyperLink>
        </div>
    </form>
</body>
</html>
