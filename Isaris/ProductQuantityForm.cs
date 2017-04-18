using Isaris.BusinessLayer;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Isaris
{
    public partial class ProductQuantityForm : MetroForm
    {
        private readonly ProductoBO productLogic = new ProductoBO();

        public int ProductId { get; set; }

        public ProductQuantityForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.productLogic.AddQuantity(this.ProductId, Convert.ToInt32(txtQuantity.Text));
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("¡Cantidad actualizada!");
        }

        private void ProductQuantityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
