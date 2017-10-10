using Isaris.BusinessLayer;
using Isaris.Entities;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Isaris
{
    public partial class ProductForm : MetroForm
    {

        private readonly ProductManager productManager;

        public ProductForm(ProductManager productManager)
        {
            this.productManager = productManager;

            InitializeComponent();

            this.nudPrice.Maximum = decimal.MaxValue;
            this.nudPrice.Minimum = 0;

            this.nudQuantity.Maximum = int.MaxValue;
            this.nudQuantity.Minimum = 0;
        }

        public ProductoEntity Product { get; set; }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (this.Product != null)
            {
                this.DisableQuantityFiled();
                this.LoadFields();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var product = new Entities.ProductoEntity
            {
                existencia = nudQuantity.Value,
                nombre = txtName.Text,
                precio = nudPrice.Value,
                proveedor = txtProvider.Text,
                IdProd = this.Product?.IdProd ?? 0
            };

            this.productManager.Save(product);
            Utility.Borrar(this, txtName);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("¡Producto actualizado!");
        }

        private void DisableQuantityFiled()
        {
            this.nudQuantity.Enabled = false;
        }

        private void DisableFileds()
        {
            this.txtName.Enabled = false;
            this.nudPrice.Enabled = false;
            this.txtProvider.Enabled = false;
            this.nudQuantity.Enabled = false;
        }

        private void LoadFields()
        {
            var product = ProductManager.GetById(this.Product.IdProd);

            this.Product = product;

            txtName.Text = product.nombre;
            txtProvider.Text = product.proveedor;
            nudPrice.Value = product.precio;
            nudQuantity.Value = product.existencia;
        }
    }
}
