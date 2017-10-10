namespace Isaris
{
    partial class ViewerForm
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
            this.reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataSet11 = new Isaris.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.ActiveViewIndex = -1;
            this.reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte.Location = new System.Drawing.Point(0, 0);
            this.reporte.Name = "reporte";
            this.reporte.Size = new System.Drawing.Size(785, 508);
            this.reporte.TabIndex = 0;
            this.reporte.Load += new System.EventHandler(this.reporte_Load);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 508);
            this.Controls.Add(this.reporte);
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DataSet1 dataSet11;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer reporte;
    }
}