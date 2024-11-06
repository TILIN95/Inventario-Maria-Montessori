using InventarioInstitutoMariaMontessori.Formularios.Configuracion;
using InventarioInstitutoMariaMontessori.Formularios.Gestion;
using System;
using System.Windows.Forms;

namespace InventarioInstitutoMariaMontessori.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(Modelos.Usuario usuario)
        {
            InitializeComponent();
        }

        private void productosMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productosForm = new frmProductos();
            productosForm.Show();
        }

        private void proveedoresMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores proveedoresForm = new frmProveedores();
            proveedoresForm.Show();
        }

        private void usuariosMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuariosForm = new frmUsuarios();
            usuariosForm.Show();
        }

        private void reportesMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes reportesForm = new frmReportes();
            reportesForm.Show();
        }

        private void rolesPermisosMenuItem_Click(object sender, EventArgs e)
        {
            frmRolesPermisos rolesPermisosForm = new frmRolesPermisos();
            rolesPermisosForm.Show();
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categoriasForm = new frmCategorias();
            categoriasForm.Show();
        }

        private void ubicacionesMenuItem_Click(object sender, EventArgs e)
        {
            frmUbicaciones ubicacionesForm = new frmUbicaciones();
            ubicacionesForm.Show();
        }

        private void mantenimientosMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientos mantenimientosForm = new frmMantenimientos();
            mantenimientosForm.Show();
        }

        private void alertasMenuItem_Click(object sender, EventArgs e)
        {
            frmAlertas alertasForm = new frmAlertas();
            alertasForm.Show();
        }
    }
}
