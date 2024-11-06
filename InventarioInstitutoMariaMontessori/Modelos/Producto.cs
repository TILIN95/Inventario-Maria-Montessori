using System;

namespace InventarioInstitutoMariaMontessori.Modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string CodigoPatrimonio { get; set; } 
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; } 
        public DateTime FechaAdquisicion { get; set; } 
        public int? IdProveedor { get; set; } 
        public int? IdCategoria { get; set; } 
        public int? IdUbicacion { get; set; } 
        public string Modelo { get; set; } 
        public string Serie { get; set; }
        public int ID_Categoria { get; internal set; }
    }
}
