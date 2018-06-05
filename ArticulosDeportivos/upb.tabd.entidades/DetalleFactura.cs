using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace upb.tabd.entidades
{
    public class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        public double Descuento { get; set; }
        public long Precio { get; set; }
        public int CantidadVendida { get; set; }
        public long MontoProducto { get; set; }
        public int idProducto { get; set; }
        public int idFactura { get; set; }
    }
}
