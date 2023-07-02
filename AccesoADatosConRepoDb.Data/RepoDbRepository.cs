using AccesoADatosConRepoDb.Entities;
using Microsoft.Data.SqlClient;
using RepoDb;

namespace AccesoADatosConRepoDb.Data
{
    public class RepoDbRepository
    {
        //Para hacerlo por capas tenemos que poner la configuracion global en el constructor.
        public RepoDbRepository() 
        {
            GlobalConfiguration
                .Setup()
                .UseSqlServer();
        }
        string _connectionString = "Persist Security Info=True;Initial Catalog=StockIGImplementos;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

        public List<Producto> TraerProductos()
        {
             var producto = new List<Producto>();

            using (var connection = new SqlConnection(_connectionString))
            {
                producto = (List<Producto>)connection.QueryAll<Producto>();
            }
            foreach (var m in producto)
            {
            }
            return producto;
        }
        public void AgregarProducto(Producto producto )
        {
            using (var connection = new SqlConnection(_connectionString))
            {
               if (BuscarProducto(producto.NombreProducto).Count() >= 1)
                {
                    var buscar = new Producto();

                    buscar = connection.Query<Producto>(p => p.NombreProducto == producto.NombreProducto).FirstOrDefault();

                    var cantidadProducto = buscar.Cantidad + producto.Cantidad;

                    buscar.Cantidad = cantidadProducto;

                    var borrar = connection.Update<Producto>(buscar);
                }

                else 
                {
                    var agregar = connection.Insert<Producto>(producto);
                }
               
                
            }
        }
        public void EditarProducto()
        {
            IEnumerable<Producto> editarProducto;
            using (var connection = new SqlConnection(_connectionString))
            {
                editarProducto = connection.Query<Producto>(m => m.NombreProducto.EndsWith("666"));

                foreach (var movie in editarProducto)
                {
                    movie.NombreProducto = $"{movie.NombreProducto} (X)";
                }
                connection.UpdateAll<Producto>(editarProducto);
            }
        }
        public List<Producto> BuscarProducto(string textToSearch)
        {
            var producto = new List<Producto>();

            using (var connection = new SqlConnection(_connectionString))
            {
                producto = (List<Producto>)connection.Query<Producto>(m => m.NombreProducto.Contains(textToSearch) || m.TipoProducto.Contains(textToSearch));
            }
            
            return producto;
        }
        public void EliminarProducto(Producto producto)
        {
            var buscar = new Producto();
            
            using (var connection = new SqlConnection(_connectionString))
            {
               buscar = connection.Query<Producto>(p => p.NombreProducto == producto.NombreProducto).FirstOrDefault();
            }

            var cantidadProducto = buscar.Cantidad - producto.Cantidad;

            buscar.Cantidad = cantidadProducto;

            using (var connection = new SqlConnection(_connectionString))
            {
                var borrar = connection.Update<Producto>(buscar);
            }
            
        }
        //public void EliminarProducto(Producto producto)
        //{
        //    var cantidadProducto = 0;
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        connection.Open();

        //        // Buscar el producto por su nombre
        //        var buscar = connection.Query<Producto>(p => p.NombreProducto == producto.NombreProducto).FirstOrDefault();

        //        if (buscar != null)
        //        {
        //            cantidadProducto = buscar.Cantidad - producto.Cantidad;

        //            producto.Cantidad = cantidadProducto;

        //            // Actualizar el producto en la base de datos
        //            connection.Update<Producto>(buscar);

        //            // Agregar el producto actualizado
        //            connection.Insert<Producto>(producto);
        //        }
        //    }
        //}

    }
}