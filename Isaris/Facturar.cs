using System;
using System.Drawing;
using MetroFramework.Forms;
using System.Windows.Forms;
using Isaris.Entities;
using Isaris.BusinessLayer;
using Isaris.Properties;
using System.Drawing.Printing;
using CrystalDecisions.Shared;

namespace Isaris
{
    public partial class Facturar : MetroForm
    {
        private readonly InvoiceManager invoiceManager;
        public Facturar(InvoiceManager invoiceManager)
        {
            this.invoiceManager = invoiceManager;
            InitializeComponent();
        }

        ClienteEntity cliente = null;
        ProductoEntity prod = null;
        FacturaEntity fact = null;
        string campoPrecio = "precio";
        private void facturar_Load(object sender, EventArgs e)
        {
            this.dgD.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            this.dgD.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            CargarCombo();

            dgD.DataSource = InvoiceManager.CreateDataTable();
            
        }
        public void CargarCombo()
        {
            cmbCliente.DataSource = Utility.Datos("clientes");
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "codcliente";

            cmbCliente.AutoCompleteCustomSource = Utility.Autocomplete("clientes");
            cmbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCliente.Text = string.Empty;
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            fact = new FacturaEntity();
            fact.Fecha = DateTime.Now;
            fact.IdCliente = cliente.idCliente;
            fact.Isv = Settings.Default.Isv;

            fact.Vendedor = Settings.Default.Vendedor;
                
            foreach(DataGridViewRow row in dgD.Rows)
            {
                DetalleEntity detalle = new DetalleEntity();

                if(!row.IsNewRow)
                {
                    detalle.IdProd = Convert.ToInt32(row.Cells[0].Value);
                    detalle.Cantidad = Convert.ToDecimal(row.Cells[2].Value);
                    detalle.Precio = Convert.ToDecimal(row.Cells[3].Value);
                    detalle.Unidad = Convert.ToString(row.Cells[4].Value);

                    fact.Lineas.Add(detalle);
                }
            }

            invoiceManager.RegistrarFacturacion(fact);
            txtDesc.Text = fact.Descuento.ToString("c");
            txtIsv.Text = fact.Isv.ToString("c");
            txtSubtotal.Text = fact.Subtotal.ToString("c");
            txtTotal.Text = fact.Total.ToString("c");
            prod = null;

            var invoiceData = this.invoiceManager.FindInvoiceReportById(fact.IdFactura);
            var invoiceReport = new Isaris.Report.Reports.MiniInvoiceReport();
            invoiceReport.SetDataSource(invoiceData);
            invoiceReport.PrintToPrinter(new PrinterSettings(), new PageSettings(), false, new PrintLayoutSettings { Centered = false });

            MessageBox.Show("¡La factura de registro correctamente!");
        }

        void BuscarCliente()
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
            }
        }
        private void cmbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                BuscarCliente();
            }
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            char caracter = e.KeyChar;
            if ((char.IsNumber(caracter)) || (caracter == (char)8 || (caracter == '.') && (txt.Text.Contains(".") == false)))
                e.Handled = false;
            else
                e.Handled = true;
           
        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgD.CurrentRow;
            try
            {
                if (dgD.CurrentCell.ColumnIndex == 2)
                {

                    try
                    {
                        prod = ProductManager.GetByName(fila.Cells[1].Value.ToString(), campoPrecio);

                        fila.Cells[0].Value = prod.IdProd;
                        fila.Cells[1].Value = prod.nombre;
                        fila.Cells[3].Value = prod.precioTerranova;
                        fila.Cells[4].Value = prod.unidad;
                        fila.Cells[6].Value = prod.existencia;
                    }
                    catch
                    { MessageBox.Show("¡Producto no encontrado!"); }
                }
            }
            catch
            { }
                                    
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                var tb = e.Control as TextBox;

                if (dgD.CurrentCell.ColumnIndex == 1)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb.AutoCompleteCustomSource = Utility.Autocomplete("inventario");
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
            if (cliente == null)
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }


            decimal porc = 0, 
                desc =0, 
                subt = 0, 
                isv = 0, 
                tp = 0;

            foreach (DataGridViewRow row in dgD.Rows)
            {
                if (!row.IsNewRow)
                    subt += Convert.ToDecimal(row.Cells[5].Value);
            }

            desc = subt * porc;
            isv = subt * Settings.Default.Isv;
            tp = (subt + isv)-desc;
            txtSubtotal.Text = Math.Round(subt, 2).ToString("c");
            txtDesc.Text = desc.ToString("c");
            txtIsv.Text = Math.Round(isv, 2).ToString("c");
            txtTotal.Text = Math.Round(tp, 2).ToString("c");
                        
        }

        private void dgD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var headerText = dgD.Columns[e.ColumnIndex].HeaderText;

            if (!headerText.Equals("Cantidad")) return;

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
            var invoiceData = this.invoiceManager.FindInvoiceReportById(fact.IdFactura);
            var invoiceReport = new Isaris.Report.Reports.MiniInvoiceReport();
            invoiceReport.SetDataSource(invoiceData);

            invoiceReport.PrintToPrinter(new PrinterSettings(), new PageSettings(), false, new PrintLayoutSettings { Centered = false });
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            campoPrecio = "precioTerranova";
            CargarCombo();
            cmbCliente.Text = "Ceramicas Terranova";
            BuscarCliente();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            campoPrecio = "precio";
            cmbCliente.Text = "";
            txtDireccion.Clear();
            txtTel.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Utility.Borrar(this, cmbCliente);
            dgD.DataSource = InvoiceManager.CreateDataTable();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var invoiceReport = new Report.Reports.DeliveryProofReport();
            var invoiceData = this.invoiceManager.FindInvoiceReportById(fact.IdFactura);
            invoiceReport.SetDataSource(invoiceData);
            invoiceReport.PrintToPrinter(new PrinterSettings(), new PageSettings(), false, new PrintLayoutSettings { Centered = false });
        }
    }
}
