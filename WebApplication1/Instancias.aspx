<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instancias.aspx.cs" Inherits="WebApplication1.Instancias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style1">
            <asp:Button ID="btnVolver0" runat="server" OnClick="btnVolver_Click" style="text-align: left" Text="Volver" />
            <p style="margin-left: 920px">
            Usuario:
            <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
            </p>
                <br />
            Instancias&nbsp;&nbsp;&nbsp; </div>
            <br />
            <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
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

                    <asp:TemplateField HeaderText="INSCRIPCIONES_Id">
                        <FooterTemplate>
                            <asp:TextBox ID="txtINSCRIPCIONES_Id" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblINSCRIPCIONES_Id" runat="server" Text='<%# Eval("INSCRIPCIONES_Id") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtINSCRIPCIONES_Id" runat="server" Text ='<%# Eval("INSCRIPCIONES_Id") %>' />
                        </EditItemTemplate>
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

                     <asp:TemplateField HeaderText="Idinscripcion">
                        <FooterTemplate>
                            <asp:TextBox ID="txtIdinscripcion" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblIdinscripcion" runat="server" Text='<%# Eval("Idinscripcion") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtIdinscripcion" runat="server" Text ='<%# Eval("Idinscripcion") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Anio">
                        <FooterTemplate>
                            <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAnio" runat="server" Text='<%# Eval("Anio") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAnio" runat="server" Text ='<%# Eval("Anio") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Nroinscripcion">
                        <FooterTemplate>
                            <asp:TextBox ID="txtNroinscripcion" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNroinscripcion" runat="server" Text='<%# Eval("Nroinscripcion") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNroinscripcion" runat="server" Text ='<%# Eval("Nroinscripcion") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Estado">
                        <FooterTemplate>
                            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("Estado") %>' />

                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEstado" runat="server" Text ='<%# Eval("Estado") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="Fechainicio">
                         <FooterTemplate>
                             <asp:TextBox ID="txtFechainicio" runat="server"></asp:TextBox>
                         </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFechainicio" runat="server"   Text='<%# Eval("Fechainicio","{0:dd/MM/yyyy}") %>' />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechainicio" runat="server"  Text ='<%# Eval("Fechainicio","{0:dd/MM/yyyy}") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Fechafin">
                         <FooterTemplate>
                             <asp:TextBox ID="txtFechafin" runat="server"></asp:TextBox>
                         </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFechafin" runat="server"  Text='<%# Eval("Fechafin") %>' />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechafin" runat="server"   Text ='<%# Eval("Fechafin") %>' />
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
            
        </div>
    </form>
</body>
</html>

