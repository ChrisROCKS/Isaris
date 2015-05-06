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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Isaris
{
    public partial class Inventario : MetroForm
    {
        public Inventario()
        {
            InitializeComponent();
        }
        ProductoEntity prod=new ProductoEntity();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            prod.nombre = cmbProducto.Text;
            prod.precio=Convert.ToDouble(txtPrecio.Text);
            prod.precioTerranova=Convert.ToDouble(txtPrecioTerranova.Text);
            prod.unidad=txtUnidad.Text;
            prod.existencia = Convert.ToSingle(txtCantidad.Text);
            //prod.idProd = Convert.ToInt32(txtCodProd.Text);
            ProductoBO.Save(prod);
            prod = null;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cmbProducto.DataSource = metodos.Datos("inventario");
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "codproducto";

            cmbProducto.AutoCompleteCustomSource = metodos.Autocomplete("inventario");
            cmbProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbProducto.Text = "";
            
        }

        private void cmbProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                prod = ProductoBO.GetById(Convert.ToInt32(cmbProducto.SelectedValue));
                txtUnidad.Text = prod.unidad;
                txtPrecio.Text = Math.Round(prod.precio, 2).ToString();
                txtPrecioTerranova.Text = Math.Round(prod.precioTerranova, 2).ToString();
                txtCodProd.Text = prod.idProd.ToString();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"UPDATE inventario SET nombre = '"+cmbProducto.Text+"', precio = "+txtPrecio.Text+", precioTerranova = "+txtPrecioTerranova.Text+", unidad = '"+txtUnidad.Text+"' WHERE codproducto = "+txtCodProd.Text+"";

                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado!!");
            }
        }
    }
}
