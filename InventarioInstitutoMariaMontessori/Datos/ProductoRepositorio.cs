using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using InventarioInstitutoMariaMontessori.Modelos;

namespace InventarioInstitutoMariaMontessori.Datos
{
    public class ProductoRepositorio
    {
        private ConexionDB conexionDB = new ConexionDB();

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string query = "SELECT * FROM Producto";
                SqlCommand command = new SqlCommand(query, conexion);
                conexion.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            IdProducto = (int)reader["ID_Producto"],
                            CodigoPatrimonio = (string)reader["CodigoPatrimonio"],
                            Nombre = (string)reader["Nombre"],
                            Cantidad = (int)reader["Cantidad"],
                            Estado = (string)reader["Estado"],
                            Precio = (decimal)reader["Precio"],
                            FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                            IdProveedor = reader["ID_Proveedor"] as int?,
                            IdCategoria = reader["ID_Categoria"] as int?,
                            IdUbicacion = reader["ID_Ubicacion"] as int?,
                            Modelo = reader["Modelo"] as string,
                            Serie = reader["Serie"] as string
                        });
                    }
                }
            }
            return productos;
        }

        public void Agregar(Producto producto)
        {
            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO Producto (CodigoPatrimonio, Nombre, Cantidad, Estado, Precio, FechaAdquisicion, ID_Proveedor, ID_Categoria, ID_Ubicacion, Modelo, Serie) " +
                               "VALUES (@CodigoPatrimonio, @Nombre, @Cantidad, @Estado, @Precio, @FechaAdquisicion, @ID_Proveedor, @ID_Categoria, @ID_Ubicacion, @Modelo, @Serie)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@CodigoPatrimonio", producto.CodigoPatrimonio);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@FechaAdquisicion", producto.FechaAdquisicion);
                command.Parameters.AddWithValue("@ID_Proveedor", (object)producto.IdProveedor ?? DBNull.Value);
                command.Parameters.AddWithValue("@ID_Categoria", (object)producto.IdCategoria ?? DBNull.Value);
                command.Parameters.AddWithValue("@ID_Ubicacion", (object)producto.IdUbicacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@Modelo", (object)producto.Modelo ?? DBNull.Value);
                command.Parameters.AddWithValue("@Serie", (object)producto.Serie ?? DBNull.Value);
                conexion.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Actualizar(Producto producto)
        {
            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string query = "UPDATE Producto SET CodigoPatrimonio = @CodigoPatrimonio, Nombre = @Nombre, Cantidad = @Cantidad, Estado = @Estado, " +
                               "Precio = @Precio, FechaAdquisicion = @FechaAdquisicion, ID_Proveedor = @ID_Proveedor, ID_Categoria = @ID_Categoria, ID_Ubicacion = @ID_Ubicacion, " +
                               "Modelo = @Modelo, Serie = @Serie WHERE ID_Producto = @ID_Producto";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@ID_Producto", producto.IdProducto);
                command.Parameters.AddWithValue("@CodigoPatrimonio", producto.CodigoPatrimonio);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@FechaAdquisicion", producto.FechaAdquisicion);
                command.Parameters.AddWithValue("@ID_Proveedor", (object)producto.IdProveedor ?? DBNull.Value);
                command.Parameters.AddWithValue("@ID_Categoria", (object)producto.IdCategoria ?? DBNull.Value);
                command.Parameters.AddWithValue("@ID_Ubicacion", (object)producto.IdUbicacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@Modelo", (object)producto.Modelo ?? DBNull.Value);
                command.Parameters.AddWithValue("@Serie", (object)producto.Serie ?? DBNull.Value);
                conexion.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idProducto)
        {
            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string query = "DELETE FROM Producto WHERE ID_Producto = @ID_Producto";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@ID_Producto", idProducto);
                conexion.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
