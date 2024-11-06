// Datos/ProductoRepositorio.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using InventarioInstitutoMariaMontessori.Modelos;

namespace InventarioInstitutoMariaMontessori.Datos
{
    public class ProductoRepositorio
    {
        private readonly string connectionString;

        public ProductoRepositorio()
        {
            connectionString = "Server=DESKTOP-QR0D1P2;Database=InventarioInstitutoMariaMontessori;Trusted_Connection=True;";
        }

        public List<Producto> ObtenerTodos()
        {
            var productos = new List<Producto>();
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Producto", conexion))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(MapearProducto(reader));
                        }
                    }
                }
            }
            return productos;
        }

        public Producto ObtenerPorId(int id)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Producto WHERE ID_Producto = @ID", conexion))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return MapearProducto(reader);
                    }
                }
            }
            return null;
        }

        public void Insertar(Producto producto)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var cmd = new SqlCommand(@"INSERT INTO Producto (CodigoPatrimonio, Nombre, Cantidad, Estado, 
                    Precio, FechaAdquisicion, ID_Proveedor, Descripcion, ID_Categoria, ID_Ubicacion, Modelo, Serie) 
                    VALUES (@CodigoPatrimonio, @Nombre, @Cantidad, @Estado, @Precio, @FechaAdquisicion, @ID_Proveedor, 
                    @Descripcion, @ID_Categoria, @ID_Ubicacion, @Modelo, @Serie)", conexion))
                {
                    AsignarParametros(cmd, producto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Producto producto)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var cmd = new SqlCommand(@"UPDATE Producto SET CodigoPatrimonio = @CodigoPatrimonio, 
                    Nombre = @Nombre, Cantidad = @Cantidad, Estado = @Estado, Precio = @Precio, 
                    FechaAdquisicion = @FechaAdquisicion, ID_Proveedor = @ID_Proveedor, 
                    Descripcion = @Descripcion, ID_Categoria = @ID_Categoria, ID_Ubicacion = @ID_Ubicacion, 
                    Modelo = @Modelo, Serie = @Serie WHERE ID_Producto = @ID_Producto", conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_Producto", producto.ID_Producto);
                    AsignarParametros(cmd, producto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (var cmd = new SqlCommand("DELETE FROM Producto WHERE ID_Producto = @ID", conexion))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Producto MapearProducto(SqlDataReader reader)
        {
            return new Producto
            {
                ID_Producto = Convert.ToInt32(reader["ID_Producto"]),
                CodigoPatrimonio = reader["CodigoPatrimonio"].ToString(),
                Nombre = reader["Nombre"].ToString(),
                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                Estado = reader["Estado"].ToString(),
                Precio = Convert.ToDecimal(reader["Precio"]),
                FechaAdquisicion = Convert.ToDateTime(reader["FechaAdquisicion"]),
                ID_Proveedor = reader["ID_Proveedor"] != DBNull.Value ? Convert.ToInt32(reader["ID_Proveedor"]) : (int?)null,
                Descripcion = reader["Descripcion"].ToString(),
                ID_Categoria = reader["ID_Categoria"] != DBNull.Value ? Convert.ToInt32(reader["ID_Categoria"]) : (int?)null,
                ID_Ubicacion = reader["ID_Ubicacion"] != DBNull.Value ? Convert.ToInt32(reader["ID_Ubicacion"]) : (int?)null,
                Modelo = reader["Modelo"].ToString(),
                Serie = reader["Serie"].ToString()
            };
        }

        private void AsignarParametros(SqlCommand cmd, Producto producto)
        {
            cmd.Parameters.AddWithValue("@CodigoPatrimonio", producto.CodigoPatrimonio);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
            cmd.Parameters.AddWithValue("@Estado", producto.Estado ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);
            cmd.Parameters.AddWithValue("@FechaAdquisicion", producto.FechaAdquisicion);
            cmd.Parameters.AddWithValue("@ID_Proveedor", producto.ID_Proveedor ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ID_Categoria", producto.ID_Categoria ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ID_Ubicacion", producto.ID_Ubicacion ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Modelo", producto.Modelo ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Serie", producto.Serie ?? (object)DBNull.Value);
        }
    }
}