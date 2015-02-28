using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Isaris
{
    public partial class Visor : Form
    {
        public Visor()
        {
            InitializeComponent();
        }
        public ReportDocument informe = new ReportDocument();
        private void reporte_Load(object sender, EventArgs e)
        {
            reporte.ReportSource = informe;
            reporte.Zoom(1);
            reporte.Update();
        }
    }
}
