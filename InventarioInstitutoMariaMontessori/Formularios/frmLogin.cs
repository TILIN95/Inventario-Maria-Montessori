using System;
using System.Windows.Forms;
using InventarioInstitutoMariaMontessori.Servicios;
using InventarioInstitutoMariaMontessori.Modelos;

namespace InventarioInstitutoMariaMontessori.Formularios
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioService usuarioService;

        public frmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.",
                    "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuario usuario = usuarioService.ValidarUsuario(nombreUsuario, contrasena);

                if (usuario != null)
                {
                    this.Hide();
                    var frmPrincipal = new frmPrincipal(usuario);
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}