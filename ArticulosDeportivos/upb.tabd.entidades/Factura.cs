using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace upb.tabd.entidades
{
    [Serializable]
    public class Factura
    {
        public int idFactura { get; set; }
        public System.DateTime Fecha { get; set; }
        public long MontoFinal { get; set; }
        public int idCliente { get; set; }
        public DetalleFactura DetalleFactura { get; set; }
    }
}
