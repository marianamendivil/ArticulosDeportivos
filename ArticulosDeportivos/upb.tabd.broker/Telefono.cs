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
    
    public partial class Telefono
    {
        public int idTelefono { get; set; }
        public int Telefono1 { get; set; }
        public int idCliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}