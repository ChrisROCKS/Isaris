using Isaris.BusinessLayer;
using MetroFramework.Forms;
using Syncfusion.GridHelperClasses;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
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
    public partial class StockForm : MetroForm
    {
        private readonly ProductManager productManger;
        private readonly FormFactory formFactory;

        public StockForm(ProductManager productManger, FormFactory formFactory)
        {
            this.formFactory = formFactory;
            this.productManger = productManger;

            InitializeComponent();

            this.ProductsGrid.TableDescriptor.Columns.AddRange(
                    new[]
                    {
                        new GridColumnDescriptor("IdProd", "IdProd", "Id"),
                        new GridColumnDescriptor("nombre", "nombre", "Nombre"),
                        new GridColumnDescriptor("existencia", "existencia", "Existencia"),
                        new GridColumnDescriptor("proveedor", "proveedor", "Proveedor"),
                        new GridColumnDescriptor("precio", "precio", "Precio")
                    }
                );

            this.ProductsGrid.TableDescriptor.AllowEdit = false;

            this.ProductsGrid.DataSource = this.productManger.All().ToList();

            var gridExcelFilter = new GridExcelFilter();
            gridExcelFilter.WireGrid(this.ProductsGrid);

            this.ProductsGrid.AllowProportionalColumnSizing = true;

            foreach (var column in this.ProductsGrid.TableDescriptor.Columns)
            {
                column.AllowFilter = true;
                column.Appearance.AnyRecordFieldCell.ReadOnly = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var form = formFactory.Create<ProductForm>();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.ProductsGrid.DataSource = this.productManger.All().ToList();
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            this.ProductsGrid.TableControlCurrentCellControlDoubleClick += new GridTableControlControlEventHandler(gridGroupingControl1_TableControlCurrentCellControlDoubleClick);
        }

        private void gridGroupingControl1_TableControlCurrentCellControlDoubleClick(object sender, GridTableControlControlEventArgs e)
        {
            var record = this.ProductsGrid.Table.CurrentRecord;
            ShowEditWindow(record);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var record = this.ProductsGrid.Table.CurrentRecord;
            if (record == null)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }

            ShowEditWindow(record);
        }

        private void ShowEditWindow(Record record)
        {
            var form = formFactory.Create<ProductForm>();
            form.Product = new Entities.ProductoEntity {IdProd = Convert.ToInt32(record.GetValue("IdProd"))};

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.ProductsGrid.DataSource = this.productManger.All().ToList();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var record = this.ProductsGrid.Table.CurrentRecord;

            if (record == null)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }

            var quantityForm = formFactory.Create<ProductQuantityForm>();
            quantityForm.ProductId = Convert.ToInt32(record.GetValue("IdProd"));
            //TopMost = true;

            var result = quantityForm.ShowDialog();

            this.ProductsGrid.DataSource = this.productManger.All().ToList();
        }
    }
}
