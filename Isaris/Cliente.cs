using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using Isaris.Entities;
using Isaris.BusinessLayer;

namespace Isaris
{
    public partial class Cliente : MetroForm
    {
        public Cliente()
        {
            InitializeComponent();
        }
        ClienteEntity cliente = null;
        public string nombre { get; set; }
        private void Cliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = nombre;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNumero.Text.Length > 9)
                e.Handled = true;
        }

        private void btnGuardarSalir_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "" || txtNombre.Text == "" || txtNumero.Text == "")
                return;

            cliente = new ClienteEntity();
            txtDireccion.Focus();
            cliente.nombre = txtNombre.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono=txtNumero.Text;
            ClienteBO.Save(cliente);
            MessageBox.Show("Guardado correctamente!!","Isaris");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        private void txtActualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }
    }
}
