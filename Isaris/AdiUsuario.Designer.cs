namespace Isaris
{
    partial class AdiUsuario
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
            this.txtPw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbPermiso = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(83, 327);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(245, 49);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Iniciar Sesion";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(70, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Contraseña:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPw
            // 
            this.txtPw.Lines = new string[0];
            this.txtPw.Location = new System.Drawing.Point(172, 204);
            this.txtPw.MaxLength = 32767;
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '\0';
            this.txtPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPw.SelectedText = "";
            this.txtPw.Size = new System.Drawing.Size(154, 23);
            this.txtPw.TabIndex = 8;
            this.txtPw.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(70, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Usuario:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtUser
            // 
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(172, 112);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(154, 23);
            this.txtUser.TabIndex = 6;
            this.txtUser.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(70, 259);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Permiso:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmbPermiso
            // 
            this.cmbPermiso.FormattingEnabled = true;
            this.cmbPermiso.ItemHeight = 23;
            this.cmbPermiso.Items.AddRange(new object[] {
            "Administrador",
            "Propietario",
            "Usuario"});
            this.cmbPermiso.Location = new System.Drawing.Point(172, 249);
            this.cmbPermiso.Name = "cmbPermiso";
            this.cmbPermiso.Size = new System.Drawing.Size(154, 29);
            this.cmbPermiso.TabIndex = 13;
            this.cmbPermiso.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(70, 162);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Nombre:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtNombre
            // 
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(172, 162);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(154, 23);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.UseSelectable = true;
            // 
            // AdiUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 420);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbPermiso);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUser);
            this.Name = "AdiUsuario";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Adicion de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPw;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbPermiso;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNombre;
    }
}