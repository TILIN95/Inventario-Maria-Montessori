using InventarioInstitutoMariaMontessori.Datos;
using InventarioInstitutoMariaMontessori.Modelos;
using System.Collections.Generic;

namespace InventarioInstitutoMariaMontessori.Servicios
{
    public class ProductoService
    {
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();

        public List<Producto> ObtenerTodos()
        {
            return productoRepositorio.ObtenerProductos();
        }

        public void Agregar(Producto producto)
        {
            productoRepositorio.Agregar(producto);
        }

        public void Actualizar(Producto producto)
        {
            productoRepositorio.Actualizar(producto);
        }

        public void Eliminar(int idProducto)
        {
            productoRepositorio.Eliminar(idProducto);
        }
    }
}
