using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBgood
{
    public partial class usuarios : System.Web.UI.Page
    {
        #region Variables Globales

        //Cadena de conexión al servidor donde se encuentra la base de datos MongoDB
        protected static IMongoClient client = new MongoClient("mongodb://marianamendidu:finaltopicos2018@ds163689.mlab.com:63689/perfilusuarios_finaltopicos");
        //Se establece la base de datos donde se realizarán las operaciones
        protected static IMongoDatabase database = client.GetDatabase("perfilusuarios_finaltopicos");

        #endregion

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarFormulario();
            }

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = txtIdCliente.Text;

            if (buscado.Length == 0)
            {
                lblResultado.Text = "Debe ingresar el identificador del cliente";
            }
            else
            {
                lblResultado.Text = String.Empty;
                // BuscarComentario(buscado);
                BuscarListaDeseos(buscado);
            }
        }       

        #endregion

        #region Métodos Privados

        /*
        private void BuscarComentario(string id)
        {
            //Se obtiene la colección, en este caso Comentarios
            var collection = database.GetCollection<BsonDocument>("Comentarios");
            //Se obtiene el filtro, es decir, la condición Where, para este caso con el Id del Cliente
            //Como el Id es generado por la base de datos, se debe convertir el tipo de datos para su ejecución
            var filter = Builders<BsonDocument>.Filter.Eq("IdCliente", id);
            //Se realiza la consulta
            var result = collection.Find(filter).FirstOrDefault();

            //Si el resultado es nulo, es porque la consulta no arrojó resultados, en caso contrario
            // se carga la info al formulario y se habilitan las acciones que se pueden ejecutar para el registro
            if (result != null)
            {
                gvComentarios.DataSource = result["IdProducto"] != null ? result["IdProducto"].ToString() : string.Empty;
                gvComentarios.DataSource = result["Comentario"] != null ? result["Comentario"].ToString() : string.Empty;

                gvComentarios.DataBind();

                EstablecerEdicion();
            }
            else
            {
                lblResultado.Text = "No se encontró el producto con el id " + id;
                LimpiarFormulario();
            }
        }*/

        private void BuscarListaDeseos(string id)
        {            

            //Se obtiene la colección, en este caso Comentarios
            var collection = database.GetCollection<BsonDocument>("Lista de deseos");
            //Se obtiene el filtro, es decir, la condición Where, para este caso con el Id del Cliente
            //Como el Id es generado por la base de datos, se debe convertir el tipo de datos para su ejecución
            var filter = Builders<BsonDocument>.Filter.Eq("IdCliente", int.Parse(id));
            //Se realiza la consulta
            var result = collection.Find(filter).FirstOrDefault();

            //Si el resultado es nulo, es porque la consulta no arrojó resultados, en caso contrario
            // se carga la info al formulario y se habilitan las acciones que se pueden ejecutar para el registro
        
            if (result != null)
            {
              
                gvListaDeseos.DataSource = result["IdProducto"] != null ? result["IdProducto"].ToString() : string.Empty;
                gvListaDeseos.DataBind();
                EstablecerEdicion();               

            }
            else
            {
                lblResultado.Text = "No se encontró el producto con el id " + id;
                LimpiarFormulario();
            }
        }

        private void EstablecerEdicion()
        {
            lblResultado.Text = string.Empty;
            btnBuscar.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            txtIdCliente.Text = string.Empty;
            btnBuscar.Enabled = true;
        }

        #endregion

        #region Clases

        private class Comentario
        {
            [BsonId]
            public ObjectId _id { get; set; }

            public int idProducto { get; set; }

            public int idCliente { get; set; }

            public string comentario { get; set; }
        }

        private class ListaDeseos
        {
            [BsonId]
            public ObjectId _id { get; set; }

            public int idProducto { get; set; }

            public int idCliente { get; set; }

        }

        private class Puntuacion
        {
            [BsonId]
            public ObjectId _id { get; set; }

            public int idProducto { get; set; }

            public int idCliente { get; set; }

            public int puntuacion { get; set; }
        }

        #endregion
    }
}