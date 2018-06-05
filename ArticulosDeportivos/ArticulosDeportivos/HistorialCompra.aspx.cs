using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN = upb.tabd.entidades;
using CT = upb.tabd.controladora;

namespace ArticulosDeportivos
{
    public partial class HistorialCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int id = -1;
            //string nombreProducto = "";

            if (txtIdCliente.Text.Length != 0)
            {
                id = int.Parse(txtIdCliente.Text); //suponemos que el idProducto siempre es numerico y parseamos ese campo a entero
            }

            ConsultarHistorialCompra(id);
        }

        private void ConsultarHistorialCompra(int id)
        {
            CT.Factura factura = new CT.Factura();
            List<EN.Factura> listado = factura.ConsultarFacturas(id);

            gvFacturas.DataSource = listado;
            gvFacturas.DataBind();

        }

    }
}
