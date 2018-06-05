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
    public partial class ConsultaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int idProducto = -1;
            //string nombreProducto = "";

            if (txtIdProducto.Text.Length != 0)
            {
                idProducto = int.Parse(txtIdProducto.Text); //suponemos que el idProducto siempre es numerico y parseamos ese campo a entero
            }

            ConsultarProductos(idProducto);
        }

        private void ConsultarProductos(int idProducto)
        {
            CT.Articulos producto = new CT.Articulos(); 
            List<EN.Articulos> listado = producto.ConsultarProductos(idProducto);

            gvProductos.DataSource = listado;
            gvProductos.DataBind();

        }

    }
}