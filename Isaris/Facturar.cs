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
using Isaris.Negocio;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Isaris
{
    public partial class Facturar : MetroForm
    {
        public Facturar()
        {
            InitializeComponent();
        }
        ClienteEntity cliente = null;
        ProductoEntity prod = null;
        FacturaEntity fact = null;
        string campoPrecio = "precio";
        private void facturar_Load(object sender, EventArgs e)
        {
            //Otros colores
            //this.dgD.RowsDefaultCellStyle.BackColor = Color.Bisque;
            //this.dgD.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgD.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            this.dgD.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            CargarCombo();

            dgD.DataSource = FacturaBO.CreateDataTable();
            
        }
        public void CargarCombo()
        {
            cmbCliente.DataSource = metodos.Datos("clientes");
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "codcliente";

            cmbCliente.AutoCompleteCustomSource = metodos.Autocomplete("clientes");
            cmbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCliente.Text = "";
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cliente == null || txtP.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            fact = new FacturaEntity();
            fact.fecha = DateTime.Now;
            fact.idCliente = cliente.idCliente;
            
            fact.vendedor = "Karol";
                
            foreach(DataGridViewRow row in dgD.Rows)
            {
                DetalleEntity detalle = new DetalleEntity();

                if(!row.IsNewRow)
                {
                    //row.Cells[2].Selected = true;
                    detalle.idProd = Convert.ToInt32(row.Cells[0].Value);
                    detalle.cantidad = Convert.ToSingle(row.Cells[2].Value);
                    detalle.precio = Convert.ToDouble(row.Cells[3].Value);
                    detalle.unidad = Convert.ToString(row.Cells[4].Value);

                    fact.Lineas.Add(detalle);

                    //ProductoBO.UpdateStock(detalle.idProd,Convert.ToSingle(row.Cells[7].Value));
                }
            }
            fact.descuento = Convert.ToInt32(txtP.Text);
            FacturaBO.RegistrarFacturacion(fact);
            txtDesc.Text = fact.descuento.ToString("c");
            txtIsv.Text = fact.isv.ToString("c");
            txtSubtotal.Text = fact.subtotal.ToString("c");
            txtTotal.Text = fact.total.ToString("c");
            prod = null;
            
            MessageBox.Show("Guardado");
        }
        void buscarCliente()
        {
            try
            {
                cliente = ClienteBO.GetById(Convert.ToInt32(cmbCliente.SelectedValue));
                txtDireccion.Text = cliente.direccion;
                txtTel.Text = cliente.telefono;
            }
            catch
            {
                DialogResult dr = MessageBox.Show("No se encontro el cliente, ¿Desea agreagarlo?",
                  "Informacion del Cliente", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Cliente cliente = new Cliente();
                        cliente.nombre = cmbCliente.Text;
                        if (cliente.ShowDialog() == DialogResult.Yes)
                        {
                            CargarCombo();
                        }

                        break;
                    case DialogResult.No: break;
                }


                //if(cliente.ShowDialog() == DialogResult.Yes)
                //{
                //    cmbCliente.DataSource = metodos.Datos("clientes");
                //    cmbCliente.DisplayMember = "nombre";
                //    cmbCliente.ValueMember = "codcliente";

                //    cmbCliente.AutoCompleteCustomSource = metodos.Autocomplete("clientes");
                //    cmbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
                //    cmbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //    cmbCliente.Text = "";
                //}
            }
        }
        private void cmbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                buscarCliente();
            }
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio
            //{
            //    // Invalidar la accion
            //    e.Handled = true;
            //    // Enviar el sonido de beep de windows
            //    //System.Media.SystemSounds.Beep.Play();
            //}
            TextBox txt = (TextBox)sender;
            char caracter = e.KeyChar;
            if ((char.IsNumber(caracter)) || (caracter == (char)8 || (caracter == '.') && (txt.Text.Contains(".") == false)))
                e.Handled = false;
            else
                e.Handled = true;
           
        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //if (dgD.SelectedRows.Count == 0) return; // solucion al error de null reference exception cuando se clickear un header cell
            DataGridViewRow fila = dgD.CurrentRow;
            try
            {
                if (dgD.CurrentCell.ColumnIndex == 2)
                {

                    try
                    {
                        prod = ProductoBO.GetByName(fila.Cells[1].Value.ToString(), campoPrecio);

                        fila.Cells[0].Value = prod.idProd;
                        fila.Cells[1].Value = prod.nombre;
                        fila.Cells[3].Value = prod.precio;
                        fila.Cells[4].Value = prod.unidad;
                        fila.Cells[6].Value = prod.existencia;
                    }
                    catch
                    { MessageBox.Show("Producto no encontrado!"); }
                }
            }
            catch
            { }
                                    
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            
            if (tb != null)
            {
                if (dgD.CurrentCell.ColumnIndex == 1)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb.AutoCompleteCustomSource = metodos.Autocomplete("inventario");
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    tb.AutoCompleteMode = AutoCompleteMode.None;
                }

                if (dgD.CurrentCell.ColumnIndex == 2)
                    tb.KeyPress += OnlyNumbers_KeyPress;
                else
                    tb.KeyPress -= OnlyNumbers_KeyPress;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cliente == null || txtP.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }


            double porc = 0;
            porc = Convert.ToDouble(txtP.Text) / 100;
            double desc=0;
            double subt = 0, isv = 0, tp = 0;
            foreach (DataGridViewRow row in dgD.Rows)
            {
                if (!row.IsNewRow)
                    subt += Convert.ToDouble(row.Cells[5].Value);
            }
            desc = subt * porc;
            isv = subt * 0.15;
            tp = (subt + isv)-desc;
            txtSubtotal.Text = Math.Round(subt, 2).ToString("c");
            txtDesc.Text = Math.Round(desc, 2).ToString("c");
            txtIsv.Text = Math.Round(isv, 2).ToString("c");
            txtTotal.Text = Math.Round(tp, 2).ToString("c");
                        
        }

        private void dgD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dgD.Columns[e.ColumnIndex].HeaderText;

            if (!headerText.Equals("Cantidad")) return;

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgD.Rows[e.RowIndex].ErrorText =
                    "Company Name must not be empty";
                e.Cancel = true;
            }
        }

        private void dgD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgD.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            // es la sql
            //SELECT f.vendedor,f.fecha,f.total,d.*,c.nombre as cliente,c.direccion, i.nombre as producto
            //FROM facturas as f, clientes as c, inventario as i,detallefactura as d
            //WHERE f.codcliente = c.codcliente and f.codcliente =1 and d.codproducto = i.codproducto and f.codfactura =1
            Visor v = new Visor();
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"SELECT f.vendedor,f.fecha,f.total,d.*,f.descuento,c.nombre as cliente,c.direccion,c.telefono, i.nombre as producto 
                                FROM facturas as f, clientes as c, inventario as i,detallefactura as d 
                                WHERE f.codcliente = c.codcliente and d.codproducto = i.codproducto and f.codfactura = d.codfactura and f.codfactura = " + fact.idFactura;

                MySqlDataAdapter daFactura = new MySqlDataAdapter(sql, conn);
                //daFactura.FillSchema(v.dataSet11, SchemaType.Source, "repfactura");
                daFactura.Fill(v.dataSet11, "repfactura");

            }
            v.informe.Load("repFactura.rpt");
            v.informe.SetDataSource(v.dataSet11);
            v.Show();
           
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campoPrecio = "precioTerranova";
            CargarCombo();
            cmbCliente.Text = "Ceramicas Terranova";
            buscarCliente();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campoPrecio = "precio";
            cmbCliente.Text = "";
            txtDireccion.Clear();
            txtTel.Clear();
        }

        private void txtP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if ((char.IsNumber(caracter)) || (caracter == (char)8 || (caracter == '.') && (txtP.Text.Contains(".") == false)))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
