namespace InventarioInstitutoMariaMontessori.Formularios
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gestionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesPermisosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertasMenuItem;

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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gestionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesPermisosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.gestionMenuItem,
                this.configuracionMenuItem
            });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // gestionMenuItem
            this.gestionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.productosMenuItem,
                this.proveedoresMenuItem,
                this.usuariosMenuItem,
                this.reportesMenuItem
            });
            this.gestionMenuItem.Name = "gestionMenuItem";
            this.gestionMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionMenuItem.Text = "Gestión";

            // configuracionMenuItem
            this.configuracionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.rolesPermisosMenuItem,
                this.categoriasMenuItem,
                this.ubicacionesMenuItem,
                this.mantenimientosMenuItem,
                this.alertasMenuItem
            });
            this.configuracionMenuItem.Name = "configuracionMenuItem";
            this.configuracionMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionMenuItem.Text = "Configuración";

            // productosMenuItem
            this.productosMenuItem.Name = "productosMenuItem";
            this.productosMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosMenuItem.Text = "Productos";
            this.productosMenuItem.Click += new System.EventHandler(this.productosMenuItem_Click);

            // proveedoresMenuItem
            this.proveedoresMenuItem.Name = "proveedoresMenuItem";
            this.proveedoresMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedoresMenuItem.Text = "Proveedores";
            this.proveedoresMenuItem.Click += new System.EventHandler(this.proveedoresMenuItem_Click);

            // usuariosMenuItem
            this.usuariosMenuItem.Name = "usuariosMenuItem";
            this.usuariosMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosMenuItem.Text = "Usuarios";
            this.usuariosMenuItem.Click += new System.EventHandler(this.usuariosMenuItem_Click);

            // reportesMenuItem
            this.reportesMenuItem.Name = "reportesMenuItem";
            this.reportesMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportesMenuItem.Text = "Reportes";
            this.reportesMenuItem.Click += new System.EventHandler(this.reportesMenuItem_Click);

            // rolesPermisosMenuItem
            this.rolesPermisosMenuItem.Name = "rolesPermisosMenuItem";
            this.rolesPermisosMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolesPermisosMenuItem.Text = "Roles y Permisos";
            this.rolesPermisosMenuItem.Click += new System.EventHandler(this.rolesPermisosMenuItem_Click);

            // categoriasMenuItem
            this.categoriasMenuItem.Name = "categoriasMenuItem";
            this.categoriasMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasMenuItem.Text = "Categorías";
            this.categoriasMenuItem.Click += new System.EventHandler(this.categoriasMenuItem_Click);

            // ubicacionesMenuItem
            this.ubicacionesMenuItem.Name = "ubicacionesMenuItem";
            this.ubicacionesMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ubicacionesMenuItem.Text = "Ubicaciones";
            this.ubicacionesMenuItem.Click += new System.EventHandler(this.ubicacionesMenuItem_Click);

            // mantenimientosMenuItem
            this.mantenimientosMenuItem.Name = "mantenimientosMenuItem";
            this.mantenimientosMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mantenimientosMenuItem.Text = "Mantenimientos";
            this.mantenimientosMenuItem.Click += new System.EventHandler(this.mantenimientosMenuItem_Click);

            // alertasMenuItem
            this.alertasMenuItem.Name = "alertasMenuItem";
            this.alertasMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alertasMenuItem.Text = "Alertas";
            this.alertasMenuItem.Click += new System.EventHandler(this.alertasMenuItem_Click);

            // frmPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.Text = "Panel Principal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
