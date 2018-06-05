using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EN = upb.tabd.entidades;
using BR = upb.tabd.broker;

namespace upb.tabd.controladora
{
    public class Factura
    {
        BR.restauradaEntities db = new BR.restauradaEntities();

        /// <summary>
        /// Método para la consulta de facturas
        /// </summary>
        /// <param name="objFactura"></param>Objeto factura a consultar
        /// <returns>Lista de las facturas</returns>

        public List<EN.Factura> ConsultarFacturas(int id)
        {
            List<EN.Factura> listado = new List<EN.Factura>();

            var resultado = from f in db.Facturas
                  
                            join c in db.Clientes on f.idFactura equals c.idCliente
                            join d in db.DetalleFacturas on f.idFactura equals d.idFactura
                       
                            where (f.idCliente == id)
                            select new { c.idCliente, f.idFactura, f.Fecha, f.MontoFinal, d.Descuento, d.Precio, d.idProducto, d.CantidadVendida };

            foreach (var item in resultado)
            {
                EN.Factura objFactura = new EN.Factura();
                EN.DetalleFactura objDetalle = new EN.DetalleFactura();
                 

                objFactura.idFactura = int.Parse(item.idFactura.ToString());
                objFactura.idCliente = int.Parse(item.idCliente.ToString());
                objFactura.Fecha = item.Fecha;
                objFactura.MontoFinal = int.Parse(item.MontoFinal.ToString());
                objDetalle.Descuento = double.Parse(item.Descuento.ToString());
                objDetalle.Precio = item.Precio;
                objDetalle.idProducto = int.Parse(item.idProducto.ToString());
                objDetalle.CantidadVendida = item.CantidadVendida;


                listado.Add(objFactura);

            }

            return listado;
        }
    }
}

