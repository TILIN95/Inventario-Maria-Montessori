using InventarioInstitutoMariaMontessori.Modelos;
using System;

namespace InventarioInstitutoMariaMontessori.Validaciones
{
    internal class ValidacionProducto
    {
        public static bool Validar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (producto.Cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.");
            if (producto.Precio < 0)
                throw new ArgumentException("El precio no puede ser negativo.");
            // Agregar más validaciones según sea necesario
            return true;
        }
    }
}
