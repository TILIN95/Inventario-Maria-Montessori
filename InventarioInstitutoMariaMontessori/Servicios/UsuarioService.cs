using InventarioInstitutoMariaMontessori.Datos;
using InventarioInstitutoMariaMontessori.Modelos;

namespace InventarioInstitutoMariaMontessori.Servicios
{
    public class UsuarioService
    {
        private readonly UsuarioRepositorio usuarioRepositorio;

        public UsuarioService()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public Usuario ValidarUsuario(string nombreUsuario, string contrasena)
        {
            return usuarioRepositorio.ValidarUsuario(nombreUsuario, contrasena);
        }
    }
}