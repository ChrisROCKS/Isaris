using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isaris
{
    public partial class SalesByDateForm : MetroForm
    {
        public SalesByDateForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Visor v = new Visor();
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = $@"SELECT f.vendedor,f.fecha,f.total,d.*,f.descuento,c.nombre as cliente,c.direccion,c.telefono, i.nombre as producto 
                                FROM facturas as f, clientes as c, inventario as i,detallefactura as d 
                                WHERE f.codcliente = c.codcliente and d.codproducto = i.codproducto and f.codfactura = d.codfactura and date(f.fecha) = '{dtpDate.Value.Date.ToString("yyyy-MM-dd") }' ";

                MySqlDataAdapter daFactura = new MySqlDataAdapter(sql, conn);
                daFactura.Fill(v.dataSet11, "repfactura");

            }
            v.informe.Load("repVentas.rpt");
            v.informe.SetDataSource(v.dataSet11);
            v.Show();
        }
    }
}
