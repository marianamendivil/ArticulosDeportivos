<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaProductos.aspx.cs" Inherits="ArticulosDeportivos.ConsultaProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta de productos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblIdProducto" runat="server" Text="Ingrese el producto a consultar"></asp:Label>
        <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />   
    </div>
        <br /> <!--Salto de línea -->
        <div>
            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="IdProducto" HeaderText="Id Producto" />
                    <asp:BoundField DataField="NombreProducto" HeaderText="Nombre Producto" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock" />
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
    </form>
</body>
</html>
