<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="puntuaciones.aspx.cs" Inherits="MongoDBgood.puntuaciones" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administración de puntuaciones</title>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div class="form-group">
                <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="lblIdProducto" runat="server" Text="Id Producto"></asp:Label>
                <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblIdCliente" runat="server" Text="Id Cliente"></asp:Label>
                <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblPuntuacion" runat="server" Text="Puntuacion"></asp:Label>
                <asp:TextBox ID="txtPuntuacion" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
            </div>
        </form>
    </div>
</body>
</html>