// frmProductos.cs
using System;
using System.Windows.Forms;
using InventarioInstitutoMariaMontessori.Modelos;
using InventarioInstitutoMariaMontessori.Servicios;
using System.Collections.Generic;
using InventarioInstitutoMariaMontessori.Validaciones;

namespace InventarioInstitutoMariaMontessori.Formularios.Gestion
{
    public partial class frmProductos : Form
    {
        private readonly ProductoService _productoService;
        private readonly CategoriaService _categoriaService;
        private readonly UbicacionService _ubicacionService;
        private Producto productoSeleccionado;
        private object cmbCategoria;
        private object cmbUbicacion;
        private object dgvProductos;
        private object txtCodigo;
        private object txtNombre;
        private object txtStock;
        private object txtDescripcion;
        private object txtStockMinimo;

        public frmProductos()
        {
            InitializeComponent();
            _productoService = new ProductoService();
            _categoriaService = new CategoriaService();
            _ubicacionService = new UbicacionService();
            ConfigurarFormulario();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void ConfigurarFormulario()
        {
            CargarCategorias();
            CargarUbicaciones();
            CargarProductos();
            LimpiarCampos();
        }

        private void CargarCategorias()
        {
            try
            {
                cmbCategoria.DataSource = _categoriaService.ObtenerTodos();
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "ID_Categoria"; // Asegúrate que este sea el nombre correcto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUbicaciones()
        {
            try
            {
                cmbUbicacion.DataSource = _ubicacionService.ObtenerTodos();
                cmbUbicacion.DisplayMember = "UbicacionFisica"; // Ajusta según el modelo
                cmbUbicacion.ValueMember = "ID_Ubicacion"; // Asegúrate que este sea el nombre correcto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ubicaciones: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = _productoService.ObtenerProductos();
                ConfigurarColumnasDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasDGV()
        {
            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["CodigoPatrimonio"].HeaderText = "Código Patrimonio";
            dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
            dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvProductos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvProductos.Columns["Precio"].HeaderText = "Precio";
            dgvProductos.Columns["ID_Categoria"].Visible = false;
            dgvProductos.Columns["ID_Ubicacion"].Visible = false;

            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var producto = new Producto
                {
                    IdProducto = productoSeleccionado?.IdProducto ?? 0,
                    CodigoPatrimonio = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Cantidad = int.Parse(txtStock.Text),
                    Precio = decimal.Parse(txtStockMinimo.Text),
                    ID_Categoria = (int)cmbCategoria.SelectedValue,
                    ID_Ubicacion = (int)cmbUbicacion.SelectedValue
                };

                ValidacionProducto.Validar(producto); // Validación aquí

                if (productoSeleccionado == null)
                    _productoService.Agregar(producto);
                else
                    _productoService.Actualizar(producto);

                MessageBox.Show("Producto guardado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _productoService.Eliminar(productoSeleccionado.IdProducto);
                    MessageBox.Show("Producto eliminado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                CargarDatosProducto();
            }
        }

        private void CargarDatosProducto()
        {
            if (productoSeleccionado != null)
            {
                txtCodigo.Text = productoSeleccionado.CodigoPatrimonio;
                txtNombre.Text = productoSeleccionado.Nombre;
                txtDescripcion.Text = productoSeleccionado.Descripcion;
                txtStock.Text = productoSeleccionado.Cantidad.ToString();
                txtStockMinimo.Text = productoSeleccionado.Precio.ToString("F2");
                cmbCategoria.SelectedValue = productoSeleccionado.ID_Categoria;
                cmbUbicacion.SelectedValue = productoSeleccionado.ID_Ubicacion;
            }
        }

        private void LimpiarCampos()
        {
            productoSeleccionado = null;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtStockMinimo.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbUbicacion.SelectedIndex = -1;
            txtCodigo.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser un número válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            if (!decimal.TryParse(txtStockMinimo.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStockMinimo.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            if (cmbUbicacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una ubicación", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUbicacion.Focus();
                return false;
            }

            return true;
        }
    }
}
