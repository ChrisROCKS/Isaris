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
using MySql.Data.MySqlClient;
using System.Configuration;
using Isaris.Entities;

namespace Isaris
{
    public partial class BuscarFact : MetroForm
    {
        public BuscarFact()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Visor v = new Visor();
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = "SELECT f.vendedor,f.fecha,f.total,d.*,f.descuento,c.nombre as cliente,c.direccion,c.telefono, i.nombre as producto " +
                "FROM facturas as f, clientes as c, inventario as i,detallefactura as d " +
                "WHERE f.codcliente = c.codcliente and d.codproducto = i.codproducto and f.codfactura = d.codfactura and f.codfactura = " + txtn.Text;

                MySqlDataAdapter daFactura = new MySqlDataAdapter(sql, conn);
                //daFactura.FillSchema(v.dataSet11, SchemaType.Source, "repfactura");
                daFactura.Fill(v.dataSet11, "repfactura");
                               
            }
            v.informe.Load("repFactura.rpt");
            v.informe.SetDataSource(v.dataSet11);
            v.Show();
        }
    }
}
