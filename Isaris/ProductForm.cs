using Isaris.BusinessLayer;
using Isaris.Entities;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Isaris
{
    public partial class ProductForm : MetroForm
    {

        private readonly ProductoBO productManager = new ProductoBO();

        public ProductForm()
        {
            InitializeComponent();

            this.nudPrice.Maximum = decimal.MaxValue;
            this.nudPrice.Minimum = 0;

            this.nudTerranovaPrice.Maximum = decimal.MaxValue;
            this.nudTerranovaPrice.Minimum = 0;

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
                precioTerranova = nudTerranovaPrice.Value,
                proveedor = txtProvider.Text,
                idProd = this.Product?.idProd ?? 0
            };

            //if (this.Product != null)
            //{
            //    ProductoBO.Update(product);
            //    metodos.Borrar(this, txtName);
            //    this.DialogResult = DialogResult.OK;
            //    MessageBox.Show("¡Producto actualizado!");
            //}
            //else
            //{
            //    ProductoBO.Create(product);
            //    metodos.Borrar(this, txtName);
            //    this.DialogResult = DialogResult.OK;
            //    MessageBox.Show("¡Producto guardado!");
            //}

            this.productManager.Save(product);
            metodos.Borrar(this, txtName);
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
            this.nudTerranovaPrice.Enabled = false;
            this.nudQuantity.Enabled = false;
        }

        private void LoadFields()
        {
            var product = ProductoBO.GetById(this.Product.idProd);

            this.Product = product;

            txtName.Text = product.nombre;
            txtProvider.Text = product.proveedor;
            nudPrice.Value = product.precio;
            nudQuantity.Value = product.existencia;
            nudTerranovaPrice.Value = product.precioTerranova;
        }
    }
}
