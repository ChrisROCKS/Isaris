using System;
using System.Windows.Forms;

namespace Isaris
{
    public partial class Menu : Form
    {
        private readonly FormFactory formFactory;

        public Menu(FormFactory formFactory)
        {
            this.formFactory = formFactory;

            InitializeComponent();
        }

        private void hacerFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = this.formFactory.Create<Facturar>();
            form.Show();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = this.formFactory.Create<FindInvoiceForm>();
            form.Show();
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasDia vd = new VentasDia();
            vd.Show();
        }

        private void gestionarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = this.formFactory.Create<StockForm>();

            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = this.formFactory.Create<SalesByDateForm>();
            form.Show();

        }
    }
}
