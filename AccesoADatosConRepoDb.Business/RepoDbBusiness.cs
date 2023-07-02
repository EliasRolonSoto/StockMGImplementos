using AccesoADatosConRepoDb.Data;
using AccesoADatosConRepoDb.Entities;

namespace AccesoADatosConRepoDb.Business
{
    public class RepoDbBusiness
    {
        private RepoDbRepository _dataAccessRepoDbRepository;

        public RepoDbBusiness()
        {
            _dataAccessRepoDbRepository = new RepoDbRepository();
        }
        public List<Producto> TraerProductos()
        {
            return _dataAccessRepoDbRepository.TraerProductos();
        }
        public void Agregar(Producto producto)
        {
            _dataAccessRepoDbRepository.AgregarProducto(producto);
        }
        public void EditarProducto()
        {
            _dataAccessRepoDbRepository.EditarProducto();
        }
        public List<Producto> Busqueda(string textToSearch)
        {
            return _dataAccessRepoDbRepository.BuscarProducto(textToSearch);
        }
        public void Eliminar(Producto producto)
        {
            _dataAccessRepoDbRepository.EliminarProducto(producto);
        }
    }
}