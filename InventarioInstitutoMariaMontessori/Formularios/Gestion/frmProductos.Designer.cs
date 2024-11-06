partial class frmProductos
{
    private System.Windows.Forms.DataGridView dgvProductos;
    private System.Windows.Forms.TextBox txtCodigoPatrimonio;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.NumericUpDown numCantidad;
    private System.Windows.Forms.ComboBox cboEstado;
    private System.Windows.Forms.NumericUpDown numPrecio;
    private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion;
    private System.Windows.Forms.ComboBox cboProveedor;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.ComboBox cboCategoria;
    private System.Windows.Forms.ComboBox cboUbicacion;
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.TextBox txtSerie;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnEliminar;

    private void InitializeComponent()
    {
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtCodigoPatrimonio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.Location = new System.Drawing.Point(12, 51);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(760, 250);
            this.dgvProductos.TabIndex = 0;
            // 
            // txtCodigoPatrimonio
            // 
            this.txtCodigoPatrimonio.Location = new System.Drawing.Point(94, 25);
            this.txtCodigoPatrimonio.Name = "txtCodigoPatrimonio";
            this.txtCodigoPatrimonio.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPatrimonio.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(522, 1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(0, 16);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 3;
            // 
            // cboEstado
            // 
            this.cboEstado.Location = new System.Drawing.Point(624, 24);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 4;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(667, 2);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 20);
            this.numPrecio.TabIndex = 5;
            // 
            // dtpFechaAdquisicion
            // 
            this.dtpFechaAdquisicion.Location = new System.Drawing.Point(257, 12);
            this.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            this.dtpFechaAdquisicion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAdquisicion.TabIndex = 6;
            // 
            // cboProveedor
            // 
            this.cboProveedor.Location = new System.Drawing.Point(0, 0);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(121, 21);
            this.cboProveedor.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(0, 0);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Location = new System.Drawing.Point(0, 0);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 9;
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.Location = new System.Drawing.Point(0, 0);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cboUbicacion.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(0, 0);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(0, 0);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(120, 350);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // frmProductos
            // 
            this.ClientSize = new System.Drawing.Size(846, 492);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtCodigoPatrimonio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.dtpFechaAdquisicion);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboUbicacion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
