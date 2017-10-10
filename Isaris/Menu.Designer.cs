namespace Isaris
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDelDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarInventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.facturasToolStripMenuItem,
            this.inventarioToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(791, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::Isaris.Properties.Resources.menu;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 29);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearFacturaToolStripMenuItem,
            this.buscarFacturaToolStripMenuItem1,
            this.ventasDelDíaToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // crearFacturaToolStripMenuItem
            // 
            this.crearFacturaToolStripMenuItem.Name = "crearFacturaToolStripMenuItem";
            this.crearFacturaToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.crearFacturaToolStripMenuItem.Text = "Crear factura";
            this.crearFacturaToolStripMenuItem.Click += new System.EventHandler(this.hacerFacturaToolStripMenuItem_Click);
            // 
            // buscarFacturaToolStripMenuItem1
            // 
            this.buscarFacturaToolStripMenuItem1.Name = "buscarFacturaToolStripMenuItem1";
            this.buscarFacturaToolStripMenuItem1.Size = new System.Drawing.Size(204, 30);
            this.buscarFacturaToolStripMenuItem1.Text = "Buscar factura";
            this.buscarFacturaToolStripMenuItem1.Click += new System.EventHandler(this.buscarFacturaToolStripMenuItem_Click);
            // 
            // ventasDelDíaToolStripMenuItem
            // 
            this.ventasDelDíaToolStripMenuItem.Name = "ventasDelDíaToolStripMenuItem";
            this.ventasDelDíaToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.ventasDelDíaToolStripMenuItem.Text = "Ventas del día";
            this.ventasDelDíaToolStripMenuItem.Click += new System.EventHandler(this.ventasDelDiaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarInventarioToolStripMenuItem1});
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(109, 29);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            // 
            // gestionarInventarioToolStripMenuItem1
            // 
            this.gestionarInventarioToolStripMenuItem1.Name = "gestionarInventarioToolStripMenuItem1";
            this.gestionarInventarioToolStripMenuItem1.Size = new System.Drawing.Size(255, 30);
            this.gestionarInventarioToolStripMenuItem1.Text = "Gestionar inventario";
            this.gestionarInventarioToolStripMenuItem1.Click += new System.EventHandler(this.gestionarInventarioToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Checked = true;
            this.inicioToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelProgramaToolStripMenuItem});
            this.inicioToolStripMenuItem.Image = global::Isaris.Properties.Resources.menu;
            this.inicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(28, 29);
            // 
            // salirDelProgramaToolStripMenuItem
            // 
            this.salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
            this.salirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirDelProgramaToolStripMenuItem.Text = "Salir";
            this.salirDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.salirDelProgramaToolStripMenuItem_Click);
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.facturarToolStripMenuItem.Text = "Facturas";
            // 
            // hacerFacturaToolStripMenuItem
            // 
            this.hacerFacturaToolStripMenuItem.Name = "hacerFacturaToolStripMenuItem";
            this.hacerFacturaToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.hacerFacturaToolStripMenuItem.Text = "Crear factura";
            this.hacerFacturaToolStripMenuItem.Click += new System.EventHandler(this.hacerFacturaToolStripMenuItem_Click);
            // 
            // buscarFacturaToolStripMenuItem
            // 
            this.buscarFacturaToolStripMenuItem.Name = "buscarFacturaToolStripMenuItem";
            this.buscarFacturaToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.buscarFacturaToolStripMenuItem.Text = "Buscar factura";
            this.buscarFacturaToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturaToolStripMenuItem_Click);
            // 
            // ventasDelDiaToolStripMenuItem
            // 
            this.ventasDelDiaToolStripMenuItem.Name = "ventasDelDiaToolStripMenuItem";
            this.ventasDelDiaToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.ventasDelDiaToolStripMenuItem.Text = "Ventas del día";
            this.ventasDelDiaToolStripMenuItem.Click += new System.EventHandler(this.ventasDelDiaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // gestionarInventarioToolStripMenuItem
            // 
            this.gestionarInventarioToolStripMenuItem.Name = "gestionarInventarioToolStripMenuItem";
            this.gestionarInventarioToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.gestionarInventarioToolStripMenuItem.Text = "Gestionar productos";
            this.gestionarInventarioToolStripMenuItem.Click += new System.EventHandler(this.gestionarInventarioToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(791, 341);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasDelDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionarInventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}