using System;
using System.Data;
using System.Data.SqlClient;

namespace InventarioInstitutoMariaMontessori.Datos
{
    public class ConexionDB
    {
        private static readonly string connectionString =
            "Server=DESKTOP-QR0D1P2;Database=InventarioInstitutoMariaMontessori;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }

        public bool EjecutarComando(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        if (parameters != null)
                            comando.Parameters.AddRange(parameters);

                        conexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar comando: " + ex.Message);
                }
            }
        }

        public DataTable EjecutarConsulta(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        if (parameters != null)
                            comando.Parameters.AddRange(parameters);

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(comando);
                        adapter.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar consulta: " + ex.Message);
                }
            }
        }
    }
}