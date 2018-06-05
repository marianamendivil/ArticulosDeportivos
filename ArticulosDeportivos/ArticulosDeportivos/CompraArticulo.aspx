<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompraArticulo.aspx.cs" Inherits="ArticulosDeportivos.CompraArticulo" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Compra de productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">
       
        <div class ="formgroup">
            <asp:Label ID="lblIdCliente" runat="server" Text="idCliente"></asp:Label>
            <asp:TextBox ID="txtIdCliente" runat="server"  CssClass ="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="cliente" runat="server" ErrorMessage="Campo Requerido" ControlToValidate ="txtIdCliente" ForeColor =" Red" ValidationGroup ="AdminProductos"></asp:RequiredFieldValidator>
        </div>
        <div class ="formgroup">
            <asp:Label ID="lblIdProducto" runat="server" Text="IdProducto"></asp:Label>
            <asp:TextBox ID="txtIdProducto" runat="server"  CssClass ="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="producto" runat="server" ErrorMessage="Campo Requerido" ControlToValidate ="txtIdProducto" ForeColor =" Red" ValidationGroup ="AdminProductos"></asp:RequiredFieldValidator>

        </div>
        <div class="formgroup">
            <asp:Label ID="lblIdRaza" runat="server" Text="IdRaza"></asp:Label>
            <asp:TextBox ID="txtIdRaza" runat="server"  CssClass ="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="raza" runat="server" ErrorMessage="Campo Requerido" ControlToValidate ="txtIdRaza" ForeColor =" Red" ValidationGroup ="AdminProductos"></asp:RequiredFieldValidator>

        </div>
        <div>          
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar"  OnClick="btnAgregar_Click" CssClass="btn btn-success" />
            <div>
            <br/>
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id Mascota" />
                    <asp:BoundField DataField="NombreMascota" HeaderText="Nombre Mascota" />
                    <asp:BoundField DataField="Cliente.NombreCliente" HeaderText="Cliente" />
                    <asp:BoundField DataField="Raza.NombreRaza" HeaderText="Raza" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>               
       </div>
    </div>            
    </form>
</body>
</html>