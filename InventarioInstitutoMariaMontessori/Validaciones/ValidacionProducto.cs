// Validaciones/ValidacionProducto.cs
using System;
using InventarioInstitutoMariaMontessori.Modelos;

namespace InventarioInstitutoMariaMontessori.Validaciones
{
    public class ValidacionProducto
    {
        public static string ValidarProducto(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.CodigoPatrimonio))
                return "El código de patrimonio es requerido.";

            if (string.IsNullOrEmpty(producto.Nombre))
                return "El nombre del producto es requerido.";

            if (producto.Cantidad < 0)
                return "La cantidad no puede ser negativa.";

            if (producto.Precio < 0)
                return "El precio no puede ser negativo.";

            if (producto.FechaAdquisicion > DateTime.Now)
                return "La fecha de adquisición no puede ser futura.";

            return string.Empty;
        }
    }
}