<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="WebApplication1.Inscripciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link type="text/css" rel="stylesheet" href="Css/FontFamily.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
    <style type="text/css">

        .tablaAgregar {
            width: 100%;

        }
        .auto-style3 {
            width: 300px;
            font-size: x-large;
            text-align: center;
            height: 56px;
        }
        .auto-style11 {
            height: 56px;
        }
        .auto-style5 {
            width: 146px;
            height: 26px;
            text-align: right;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style12 {
            margin-left: 760px;
        }


        body{
            background-color: #fcfcfc;
        }

        .centrarVertical {
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .spaceAround{
            display: flex;
            flex-direction: row;
            justify-content: space-around;
            min-width: 1200px;
        }
        
        #form1{
            display: flex;
            flex-direction: column;
            align-items: center;
        }
        
        .boton{
            background-color: #1c819f;
            color: white;
            padding: 5px 10px; 
            cursor: pointer;
            border-radius: 50px;
            border: none; 
           
            transition: 0.5s;
        }
    
        .aceptar:hover{
            color: lightgreen;
        }


        .conteinerAgregar{
            border: 1px solid #000;
            padding: 10px;
        }

        .usuarioActual{
            font-weight: bold;
        }
        
        #tbxNombre{
            padding: 5px;
        }

        .inputEditar{
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="centrarVertical">
        <div class="spaceAround">
            <p>
            <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click"  Text="Volver" class="boton"/>
            <asp:Button ID="btnCerrarSesion" runat="server" OnClick="btnCerrarSesion_Click" Text="Cerrar Sesión" class="boton" />
            </p>
            <p >
            Usuario:
            <asp:Label ID="lblNombreUsuario" runat="server" CssClass="usuarioActual"></asp:Label>
            &nbsp;</p>
        </div>
            <asp:GridView ID="gv" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" AutoGenerateColumns="False" AllowSorting="True">
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
                        <EditItemTemplate>
                            <asp:Label ID="lbl_ID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_ID" runat="server" Text='<%# Eval("Id") %>' />

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
                            <asp:TextBox ID="tbxNombre" runat="server" CssClass="inputEditar" Text ='<%# Eval("Nombre") %>' />
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
                            <asp:TextBox ID="tbxFechabaja" runat="server" CssClass="inputEditar"  Text ='<%# Eval("Fechabaja") %>' />
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
                            <asp:TextBox ID="tbxCausabaja" runat="server" CssClass="inputEditar" Text ='<%# Eval("Causabaja") %>' />
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
        <p>
            &nbsp;</p>
        <div class="centrarVertical conteinerAgregar">
            <table class="centrarVertical tablaAgregar">
                <tr class="centrarVertical">
                    <td class="auto-style3"><strong>Agregar Inscripción</strong></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style5">Nombre:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbxNombre" runat="server" placeholder="Su nombre"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="tbxNombre" ErrorMessage="Ingrese un Nombre" ValidationGroup="grupo2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Button ID="btn_aceptar" runat="server" CssClass="boton aceptar" OnClick="btn_aceptar_Click" Text="Agregar" ValidationGroup="grupo2" Width="140px" />
        </div>
    </form>
</body>
</html>
