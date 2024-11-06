// Modelos/Producto.cs
using System;

namespace InventarioInstitutoMariaMontessori.Modelos
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string CodigoPatrimonio { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public int? ID_Proveedor { get; set; }
        public string Descripcion { get; set; }
        public int? ID_Categoria { get; set; }
        public int? ID_Ubicacion { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }

        // Propiedades de navegación
        public virtual Proveedor Proveedor { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
    }
}