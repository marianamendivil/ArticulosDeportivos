using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EN = upb.tabd.entidades;
using BR = upb.tabd.broker;

namespace upb.tabd.controladora
{
    public class Articulos
    {
        BR.restauradaEntities db = new BR.restauradaEntities();

        /// <summary>
        /// Método para la consulta de productos
        /// </summary>
        /// <param name="objProducto"></param>Objeto producto a consultar
        /// <returns>Lista de los productos</returns>

        public List<EN.Articulos> ConsultarProductos(int id)
        {
            List<EN.Articulos> listado = new List<EN.Articulos>();

            var resultado = from p in db.Productoes

                            //join c in db.Categorias on p.idCategoria equals c.idCategoria
                            where ((p.idProducto == id || id == -1))
                            select new { p.idProducto, p.NombreProducto, p.Precio, p.Stock };

            foreach (var item in resultado)
            {
                EN.Articulos objProducto = new EN.Articulos();
                          
                objProducto.idProducto = int.Parse(item.idProducto.ToString());
                objProducto.NombreProducto = item.NombreProducto;
                objProducto.Precio = item.Precio;
                objProducto.Stock = item.Stock;
              
                listado.Add(objProducto);

            }

            return listado;
        }
    }
}
