using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace upb.tabd.entidades
{
    [Serializable]
    public class Articulos
    {
        public int idProducto { get; set; }
        public string NombreProducto { get; set; }
        public long Precio { get; set; }
        public int Stock { get; set; }
        public int idProveedor { get; set; }
        public int idCategoria { get; set; }

    }
}
