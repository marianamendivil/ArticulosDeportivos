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
    public partial class puntuaciones : System.Web.UI.Page
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

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Puntuacion puntuacion = new Puntuacion();
            puntuacion.idProducto = int.Parse(txtIdProducto.Text);
            puntuacion.idCliente = int.Parse(txtIdCliente.Text);
            puntuacion.puntuacion = int.Parse(txtPuntuacion.Text);

            Insertar(puntuacion);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = txtId.Text;

            if (buscado.Length == 0)
            {
                lblResultado.Text = "Debe ingresar el identificador del producto";
            }
            else
            {
                lblResultado.Text = String.Empty;
                Buscar(buscado);
            }
        }

        #endregion

        #region Métodos Privados

        private void Eliminar()
        {
            var collection = database.GetCollection<BsonDocument>("Puntuaciones");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(txtId.Text));

            collection.DeleteOne(filter);
            LimpiarFormulario();
        }

        private void Insertar(Puntuacion puntuacion)
        {
            var collection = database.GetCollection<BsonDocument>("Puntuaciones");
            BsonDocument documento = puntuacion.ToBsonDocument();
            collection.InsertOne(documento);
            txtId.Text = documento["_id"].ToString();
            EstablecerEdicion();
        }

        private void Buscar(string id)
        {
            //Se obtiene la colección, en este caso Comentarios
            var collection = database.GetCollection<BsonDocument>("Puntuaciones");
            //Se obtiene el filtro, es decir, la condición Where, para este caso con el Id del Comentario
            //Como el Id es generado por la base de datos, se debe convertir el tipo de datos para su ejecución
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            //Se realiza la consulta
            var result = collection.Find(filter).FirstOrDefault();

            //Si el resultado es nulo, es porque la consulta no arrojó resultados, en caso contrario
            // se carga la info al formulario y se habilitan las acciones que se pueden ejecutar para el registro
            if (result != null)
            {
                txtIdProducto.Text = result["idProducto"] != null ? result["idProducto"].ToString() : string.Empty;
                txtIdCliente.Text = result["idCliente"] != null ? result["idCliente"].ToString() : string.Empty;
                txtPuntuacion.Text = result["puntuacion"] != null ? result["puntuacion"].ToString() : string.Empty;

                EstablecerEdicion();
            }
            else
            {
                lblResultado.Text = "No se encontró la puntuación con el id " + id;
                LimpiarFormulario();
            }
        }

        private void EstablecerEdicion()
        {
            lblResultado.Text = string.Empty;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
            btnInsertar.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            txtId.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtIdProducto.Text = string.Empty;
            txtPuntuacion.Text = string.Empty;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = false;
            btnInsertar.Enabled = true;
        }

        #endregion

        #region Clases

        private class Puntuacion
        {
            [BsonId]
            public ObjectId _id { get; set; }

            public int idProducto { get; set; }

            public int idCliente { get; set; }

            public int puntuacion  { get; set; }
        }

        #endregion
    }
}