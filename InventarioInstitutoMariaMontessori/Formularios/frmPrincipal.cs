using System;
using System.Windows.Forms;
using InventarioInstitutoMariaMontessori.Modelos;

namespace InventarioInstitutoMariaMontessori.Formularios
{
    public partial class frmPrincipal : Form
    {
        private readonly Usuario usuarioActual;

        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Configurar la barra de estado
            toolStripStatusUsuario.Text = $"Usuario: {usuarioActual.Nombre}";
            toolStripStatusFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Configurar permisos según el rol del usuario
            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            // Aquí puedes configurar la visibilidad de los menús según el rol
            switch (usuarioActual.Rol)
            {
                case "Administrador":
                    // Acceso total
                    break;
                case "Usuario":
                    // Restricciones para usuario normal
                    menuUsuarios.Visible = false;
                    menuConfiguracion.Visible = false;
                    break;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProductos = new frmProductos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCategorias = new frmCategorias();
            frmCategorias.MdiParent = this;
            frmCategorias.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmInventario = new frmInventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                new frmLogin().Show();
            }
        }
    }
}