//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upb.tabd.broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        public double Descuento { get; set; }
        public long Precio { get; set; }
        public int CantidadVendida { get; set; }
        public long MontoProducto { get; set; }
        public int idProducto { get; set; }
        public int idFactura { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
