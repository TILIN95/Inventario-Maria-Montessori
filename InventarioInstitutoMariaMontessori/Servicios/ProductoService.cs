// Servicios/ProductoService.cs
using System;
using System.Collections.Generic;
using InventarioInstitutoMariaMontessori.Modelos;
using InventarioInstitutoMariaMontessori.Datos;
using InventarioInstitutoMariaMontessori.Validaciones;

namespace InventarioInstitutoMariaMontessori.Servicios
{
    public class ProductoService
    {
        private readonly ProductoRepositorio _repositorio;

        public ProductoService()
        {
            _repositorio = new ProductoRepositorio();
        }

        public List<Producto> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }

        public Producto ObtenerPorId(int id)
        {
            return _repositorio.ObtenerPorId(id);
        }

        public string Guardar(Producto producto)
        {
            var resultado = ValidacionProducto.ValidarProducto(producto);
            if (!string.IsNullOrEmpty(resultado))
                return resultado;

            try
            {
                if (producto.ID_Producto == 0)
                    _repositorio.Insertar(producto);
                else
                    _repositorio.Actualizar(producto);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Error al guardar el producto: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                _repositorio.Eliminar(id);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Error al eliminar el producto: " + ex.Message;
            }
        }

        internal object ObtenerTodosLosProductos()
        {
            throw new NotImplementedException();
        }

        internal object ObtenerProveedores()
        {
            throw new NotImplementedException();
        }

        internal object ObtenerCategorias()
        {
            throw new NotImplementedException();
        }

        internal object ObtenerUbicaciones()
        {
            throw new NotImplementedException();
        }

        internal object ObtenerProducto(int idProducto)
        {
            throw new NotImplementedException();
        }
    }
}