namespace Isaris
{
    partial class FindInvoiceForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtn = new MetroFramework.Controls.MetroTextBox();
            this.BtnDeliveryProof = new MetroFramework.Controls.MetroButton();
            this.chkShowInvoice = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(39, 201);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(147, 50);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Factura";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Numero de factura:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtn
            // 
            // 
            // 
            // 
            this.txtn.CustomButton.Image = null;
            this.txtn.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtn.CustomButton.Name = "";
            this.txtn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtn.CustomButton.TabIndex = 1;
            this.txtn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtn.CustomButton.UseSelectable = true;
            this.txtn.CustomButton.Visible = false;
            this.txtn.Lines = new string[0];
            this.txtn.Location = new System.Drawing.Point(169, 98);
            this.txtn.MaxLength = 32767;
            this.txtn.Name = "txtn";
            this.txtn.PasswordChar = '\0';
            this.txtn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtn.SelectedText = "";
            this.txtn.SelectionLength = 0;
            this.txtn.SelectionStart = 0;
            this.txtn.ShortcutsEnabled = true;
            this.txtn.Size = new System.Drawing.Size(193, 23);
            this.txtn.TabIndex = 3;
            this.txtn.UseSelectable = true;
            this.txtn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnDeliveryProof
            // 
            this.BtnDeliveryProof.Location = new System.Drawing.Point(198, 201);
            this.BtnDeliveryProof.Name = "BtnDeliveryProof";
            this.BtnDeliveryProof.Size = new System.Drawing.Size(147, 50);
            this.BtnDeliveryProof.TabIndex = 5;
            this.BtnDeliveryProof.Text = "Comprobante de entrega";
            this.BtnDeliveryProof.UseSelectable = true;
            this.BtnDeliveryProof.Click += new System.EventHandler(this.BtnDeliveryProof_Click);
            // 
            // chkShowInvoice
            // 
            this.chkShowInvoice.AutoSize = true;
            this.chkShowInvoice.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkShowInvoice.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkShowInvoice.Location = new System.Drawing.Point(23, 146);
            this.chkShowInvoice.Name = "chkShowInvoice";
            this.chkShowInvoice.Size = new System.Drawing.Size(129, 19);
            this.chkShowInvoice.TabIndex = 6;
            this.chkShowInvoice.Text = "Mostrar factura";
            this.chkShowInvoice.UseSelectable = true;
            // 
            // FindInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 275);
            this.Controls.Add(this.chkShowInvoice);
            this.Controls.Add(this.BtnDeliveryProof);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Name = "FindInvoiceForm";
            this.Text = "Buscar Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtn;
        private MetroFramework.Controls.MetroButton BtnDeliveryProof;
        private MetroFramework.Controls.MetroCheckBox chkShowInvoice;
    }
}