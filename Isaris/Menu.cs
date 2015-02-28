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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void hacerFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar f = new Facturar();
            f.Show();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarFact b = new BuscarFact();
            b.Show();
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
            Inventario i = new Inventario();
            i.Show();
        }
    }
}
