using System;
using System.Data;
using System.Data.SqlClient;
using InventarioInstitutoMariaMontessori.Modelos;

namespace InventarioInstitutoMariaMontessori.Datos
{
    public class UsuarioRepositorio
    {
        private readonly ConexionDB conexion;

        public UsuarioRepositorio()
        {
            conexion = new ConexionDB();
        }

        public Usuario ValidarUsuario(string nombreUsuario, string contrasena)
        {
            string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena AND Estado = 1";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NombreUsuario", nombreUsuario),
                new SqlParameter("@Contrasena", contrasena)
            };

            DataTable dt = conexion.EjecutarConsulta(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return new Usuario
                {
                    IdUsuario = Convert.ToInt32(dt.Rows[0]["IdUsuario"]),
                    NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString(),
                    Rol = dt.Rows[0]["Rol"].ToString(),
                    Estado = Convert.ToBoolean(dt.Rows[0]["Estado"])
                };
            }

            return null;
        }
    }
}