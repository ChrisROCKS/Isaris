﻿namespace Isaris
{
    partial class Facturar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dgD = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtIsv = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.btnReporte = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtTel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtP = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgD)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Cliente:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(171, 625);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 34);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Registrar Factura";
            this.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCliente.DropDownHeight = 1;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.Color.Black;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.Location = new System.Drawing.Point(115, 78);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(161, 26);
            this.cmbCliente.TabIndex = 10;
            this.cmbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCliente_KeyDown);
            // 
            // dgD
            // 
            this.dgD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column1,
            this.Column13,
            this.Column14});
            this.dgD.Location = new System.Drawing.Point(23, 267);
            this.dgD.MultiSelect = false;
            this.dgD.Name = "dgD";
            this.dgD.Size = new System.Drawing.Size(944, 281);
            this.dgD.TabIndex = 13;
            this.dgD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgD_CellEndEdit);
            this.dgD.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgD_CellValidating);
            this.dgD.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dgD.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "codigo";
            dataGridViewCellStyle1.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column8.HeaderText = "Codigo Producto";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "descripcion";
            this.Column9.HeaderText = "Descripcion";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 200;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "cantidad";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column10.HeaderText = "Cantidad";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "precio";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.HeaderText = "Precio";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "unidad";
            this.Column12.HeaderText = "Unidad";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "valor";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Valor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "existencia";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column13.HeaderText = "Existencia";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "nuevaExistencia";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column14.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column14.HeaderText = "Nueva Existencia";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 245);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Detalle:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(703, 572);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "SUB-TOTAL:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtSubtotal
            // 
            // 
            // 
            // 
            this.txtSubtotal.CustomButton.Image = null;
            this.txtSubtotal.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtSubtotal.CustomButton.Name = "";
            this.txtSubtotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubtotal.CustomButton.TabIndex = 1;
            this.txtSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtotal.CustomButton.UseSelectable = true;
            this.txtSubtotal.CustomButton.Visible = false;
            this.txtSubtotal.Lines = new string[0];
            this.txtSubtotal.Location = new System.Drawing.Point(799, 568);
            this.txtSubtotal.MaxLength = 32767;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.ShortcutsEnabled = true;
            this.txtSubtotal.Size = new System.Drawing.Size(119, 23);
            this.txtSubtotal.Style = MetroFramework.MetroColorStyle.Red;
            this.txtSubtotal.TabIndex = 15;
            this.txtSubtotal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtotal.UseSelectable = true;
            this.txtSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(703, 640);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(34, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "ISV:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtIsv
            // 
            // 
            // 
            // 
            this.txtIsv.CustomButton.Image = null;
            this.txtIsv.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtIsv.CustomButton.Name = "";
            this.txtIsv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIsv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIsv.CustomButton.TabIndex = 1;
            this.txtIsv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIsv.CustomButton.UseSelectable = true;
            this.txtIsv.CustomButton.Visible = false;
            this.txtIsv.Lines = new string[0];
            this.txtIsv.Location = new System.Drawing.Point(799, 636);
            this.txtIsv.MaxLength = 32767;
            this.txtIsv.Name = "txtIsv";
            this.txtIsv.PasswordChar = '\0';
            this.txtIsv.ReadOnly = true;
            this.txtIsv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIsv.SelectedText = "";
            this.txtIsv.SelectionLength = 0;
            this.txtIsv.SelectionStart = 0;
            this.txtIsv.ShortcutsEnabled = true;
            this.txtIsv.Size = new System.Drawing.Size(119, 23);
            this.txtIsv.Style = MetroFramework.MetroColorStyle.Red;
            this.txtIsv.TabIndex = 17;
            this.txtIsv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIsv.UseSelectable = true;
            this.txtIsv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIsv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(703, 674);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Total:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(799, 670);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(119, 23);
            this.txtTotal.Style = MetroFramework.MetroColorStyle.Red;
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(23, 625);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 34);
            this.btnCalcular.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCalcular.UseSelectable = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(319, 625);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(117, 34);
            this.btnReporte.Style = MetroFramework.MetroColorStyle.Red;
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "Ver Factura";
            this.btnReporte.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnReporte.UseSelectable = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(23, 123);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Direccion:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(115, 123);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(161, 61);
            this.txtDireccion.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDireccion.TabIndex = 23;
            this.txtDireccion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(23, 207);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(71, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.TabIndex = 26;
            this.metroLabel8.Text = "Telefono:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtTel
            // 
            // 
            // 
            // 
            this.txtTel.CustomButton.Image = null;
            this.txtTel.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtTel.CustomButton.Name = "";
            this.txtTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTel.CustomButton.TabIndex = 1;
            this.txtTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTel.CustomButton.UseSelectable = true;
            this.txtTel.CustomButton.Visible = false;
            this.txtTel.Lines = new string[0];
            this.txtTel.Location = new System.Drawing.Point(115, 203);
            this.txtTel.MaxLength = 32767;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel.SelectedText = "";
            this.txtTel.SelectionLength = 0;
            this.txtTel.SelectionStart = 0;
            this.txtTel.ShortcutsEnabled = true;
            this.txtTel.Size = new System.Drawing.Size(161, 23);
            this.txtTel.Style = MetroFramework.MetroColorStyle.Red;
            this.txtTel.TabIndex = 25;
            this.txtTel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTel.UseSelectable = true;
            this.txtTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(703, 606);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(48, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Desc.:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.Lines = new string[] {
        "0"};
            this.txtDesc.Location = new System.Drawing.Point(799, 602);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ReadOnly = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(119, 23);
            this.txtDesc.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDesc.TabIndex = 27;
            this.txtDesc.Text = "0";
            this.txtDesc.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(451, 572);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(124, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel10.TabIndex = 30;
            this.metroLabel10.Text = "Porcentaje Desc.:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtP
            // 
            // 
            // 
            // 
            this.txtP.CustomButton.Image = null;
            this.txtP.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txtP.CustomButton.Name = "";
            this.txtP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtP.CustomButton.TabIndex = 1;
            this.txtP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtP.CustomButton.UseSelectable = true;
            this.txtP.CustomButton.Visible = false;
            this.txtP.Lines = new string[] {
        "0"};
            this.txtP.Location = new System.Drawing.Point(581, 568);
            this.txtP.MaxLength = 4;
            this.txtP.Name = "txtP";
            this.txtP.PasswordChar = '\0';
            this.txtP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtP.SelectedText = "";
            this.txtP.SelectionLength = 0;
            this.txtP.SelectionStart = 0;
            this.txtP.ShortcutsEnabled = true;
            this.txtP.Size = new System.Drawing.Size(72, 23);
            this.txtP.Style = MetroFramework.MetroColorStyle.Red;
            this.txtP.TabIndex = 29;
            this.txtP.Text = "0";
            this.txtP.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtP.UseSelectable = true;
            this.txtP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_KeyPress);
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 705);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtIsv);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dgD);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Facturar";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.facturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridView dgD;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtIsv;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroButton btnCalcular;
        private MetroFramework.Controls.MetroButton btnReporte;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtTel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;

    }
}