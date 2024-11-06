using InventarioInstitutoMariaMontessori.Modelos;
using InventarioInstitutoMariaMontessori.Servicios;
using System;
using System.Windows.Forms;

public partial class frmProductos : Form
{
    private int? productoSeleccionadoId = null;
    private ProductoService _productoService;

    public frmProductos()
    {
        InitializeComponent();
        _productoService = new ProductoService(); // Instancia de la clase que maneja la lógica de productos
        CargarCombos();
        ActualizarGrid();
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
        var producto = new Producto
        {
            ID_Producto = productoSeleccionadoId ?? 0,
            CodigoPatrimonio = txtCodigoPatrimonio.Text,
            Nombre = txtNombre.Text,
            Cantidad = (int)numCantidad.Value,
            Estado = cboEstado.Text,
            Precio = numPrecio.Value,
            FechaAdquisicion = dtpFechaAdquisicion.Value,
            ID_Proveedor = (int?)cboProveedor.SelectedValue,
            Descripcion = txtDescripcion.Text,
            ID_Categoria = (int?)cboCategoria.SelectedValue,
            ID_Ubicacion = (int?)cboUbicacion.SelectedValue,
            Modelo = txtModelo.Text,
            Serie = txtSerie.Text
        };

        var resultado = _productoService.Guardar(producto);
        if (string.IsNullOrEmpty(resultado))
        {
            MessageBox.Show("Producto guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
            ActualizarGrid();
        }
        else
        {
            MessageBox.Show($"Error al guardar el producto: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnEliminar_Click(object sender, EventArgs e)
    {
        if (productoSeleccionadoId == null)
        {
            MessageBox.Show("Seleccione un producto para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var resultado = _productoService.Eliminar(productoSeleccionadoId.Value);
        if (string.IsNullOrEmpty(resultado))
        {
            MessageBox.Show("Producto eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
            ActualizarGrid();
        }
        else
        {
            MessageBox.Show($"Error al eliminar el producto: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            var idProducto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ID"].Value);
            CargarProducto(idProducto);
        }
    }

    private void CargarProducto(int idProducto)
    {
        var producto = _productoService.ObtenerProducto(idProducto);
        if (producto != null)
        {
            productoSeleccionadoId = producto.ID_Producto;
            txtCodigoPatrimonio.Text = producto.CodigoPatrimonio;
            txtNombre.Text = producto.Nombre;
            numCantidad.Value = producto.Cantidad;
            cboEstado.Text = producto.Estado;
            numPrecio.Value = producto.Precio;
            dtpFechaAdquisicion.Value = producto.FechaAdquisicion;
            cboProveedor.SelectedValue = producto.ID_Proveedor;
            txtDescripcion.Text = producto.Descripcion;
            cboCategoria.SelectedValue = producto.ID_Categoria;
            cboUbicacion.SelectedValue = producto.ID_Ubicacion;
            txtModelo.Text = producto.Modelo;
            txtSerie.Text = producto.Serie;
        }
    }

    private void CargarCombos()
    {
        // Aquí se cargarán los datos de proveedores, categorías y ubicaciones
        cboProveedor.DataSource = _productoService.ObtenerProveedores();
        cboCategoria.DataSource = _productoService.ObtenerCategorias();
        cboUbicacion.DataSource = _productoService.ObtenerUbicaciones();
    }

    private void ActualizarGrid()
    {
        dgvProductos.DataSource = _productoService.ObtenerTodosLosProductos();
    }

    private void LimpiarFormulario()
    {
        productoSeleccionadoId = null;
        txtCodigoPatrimonio.Clear();
        txtNombre.Clear();
        numCantidad.Value = 1;
        cboEstado.SelectedIndex = -1;
        numPrecio.Value = 0;
        dtpFechaAdquisicion.Value = DateTime.Today;
        cboProveedor.SelectedIndex = -1;
        txtDescripcion.Clear();
        cboCategoria.SelectedIndex = -1;
        cboUbicacion.SelectedIndex = -1;
        txtModelo.Clear();
        txtSerie.Clear();
    }
}
