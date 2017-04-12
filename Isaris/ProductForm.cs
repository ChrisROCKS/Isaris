using Isaris.BusinessLayer;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isaris
{
    public partial class ProductForm : MetroForm
    {

        private readonly ProductoBO productLogic = new ProductoBO();

        public ProductForm()
        {
            InitializeComponent();
        }

        public bool IsEditing { get; set; }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (this.IsEditing)
            {
                this.DisableQuantityFiled();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ProductoBO.Create(new Entities.ProductoEntity
            {
                existencia = Convert.ToInt32(txtQuantity.Text),
                nombre = txtName.Text,
                precio = Convert.ToDecimal(txtPrice.Text),
                precioTerranova = Convert.ToDecimal(txtTerranovaPrice.Text),
                proveedor = txtProvider.Text,
            });

            metodos.Borrar(this, txtName);
        }

        private void DisableQuantityFiled()
        {
            this.txtQuantity.ReadOnly = true;
        }

        private void DisableFileds()
        {
            this.txtName.ReadOnly = true;
            this.txtPrice.ReadOnly = true;
            this.txtProvider.ReadOnly = true;
            this.txtTerranovaPrice.ReadOnly = true;
            this.txtQuantity.ReadOnly = true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Onlynumwithsinglepoint(sender, e);
        }

        public void Onlynumwithsinglepoint(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

    }
}
