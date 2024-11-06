// frmProductos.Designer.cs
partial class frmProductos
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.txtCodigo = new System.Windows.Forms.TextBox();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.txtDescripcion = new System.Windows.Forms.TextBox();
        this.txtStock = new System.Windows.Forms.TextBox();
        this.txtStockMinimo = new System.Windows.Forms.TextBox();
        this.cmbCategoria = new System.Windows.Forms.ComboBox();
        this.cmbUbicacion = new System.Windows.Forms.ComboBox();
        this.lblCodigo = new System.Windows.Forms.Label();
        this.lblNombre = new System.Windows.Forms.Label();
        this.lblDescripcion = new System.Windows.Forms.Label();
        this.lblStock = new System.Windows.Forms.Label();
        this.lblStockMinimo = new System.Windows.Forms.Label();
        this.lblCategoria = new System.Windows.Forms.Label();
        this.lblUbicacion = new System.Windows.Forms.Label();

        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.btnNuevo = new System.Windows.Forms.Button();
        this.btnGuardar = new System.Windows.Forms.Button();
        this.btnEliminar = new System.Windows.Forms.Button();

        this.dgvProductos = new System.Windows.Forms.DataGridView();

        // Configuración de controles
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
        this.SuspendLayout();

        // groupBox1
        this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.lblCodigo, this.txtCodigo,
            this.lblNombre, this.txtNombre,
            this.lblDescripcion, this.txtDescripcion,
            this.lblStock, this.txtStock,
            this.lblStockMinimo, this.txtStockMinimo,
            this.lblCategoria, this.cmbCategoria,
            this.lblUbicacion, this.cmbUbicacion
        });
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(776, 200);
        this.groupBox1.Text = "Datos del Producto";

        // Labels and TextBoxes configuration here...
        this.lblCodigo.Text = "Código:";
        this.lblNombre.Text = "Nombre:";
        this.lblDescripcion.Text = "Descripción:";
        this.lblStock.Text = "Cantidad:";
        this.lblStockMinimo.Text = "Precio:";
        this.lblCategoria.Text = "Categoría:";
        this.lblUbicacion.Text = "Ubicación:";

        // Position and size of controls...
        // Example for txtCodigo:
        this.txtCodigo.Location = new System.Drawing.Point(100, 20);
        this.txtCodigo.Size = new System.Drawing.Size(200, 20);

        // Repeat for other controls...

        // Botones
        this.btnNuevo.Location = new System.Drawing.Point(12, 218);
        this.btnNuevo.Size = new System.Drawing.Size(75, 23);
        this.btnNuevo.Text = "Nuevo";

        this.btnGuardar.Location = new System.Drawing.Point(93, 218);
        this.btnGuardar.Size = new System.Drawing.Size(75, 23);
        this.btnGuardar.Text = "Guardar";

        this.btnEliminar.Location = new System.Drawing.Point(174, 218);
        this.btnEliminar.Size = new System.Drawing.Size(75, 23);
        this.btnEliminar.Text = "Eliminar";

        // dgvProductos
        this.dgvProductos.Location = new System.Drawing.Point(12, 247);
        this.dgvProductos.Size = new System.Drawing.Size(776, 300);
        this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvProductos.MultiSelect = false;
        this.dgvProductos.ReadOnly = true;

        // frmProductos
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 559);
        this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.groupBox1,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.dgvProductos
        });
        this.Name = "frmProductos";
        this.Text = "Gestión de Productos";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        this.groupBox1.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.TextBox txtStock;
    private System.Windows.Forms.TextBox txtStockMinimo;
    private System.Windows.Forms.ComboBox cmbCategoria;
    private System.Windows.Forms.ComboBox cmbUbicacion;
    private System.Windows.Forms.Label lblCodigo;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblDescripcion;
    private System.Windows.Forms.Label lblStock;
    private System.Windows.Forms.Label lblStockMinimo;
    private System.Windows.Forms.Label lblCategoria;
    private System.Windows.Forms.Label lblUbicacion;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.DataGridView dgvProductos;
}
