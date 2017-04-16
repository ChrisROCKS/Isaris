using Isaris.BusinessLayer;
using Isaris.BusinessLayer.Utilities;
using MetroFramework.Forms;
using Syncfusion.GridHelperClasses;
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
        ProductoBO productLogic = new ProductoBO();
        public StockForm()
        {
            InitializeComponent();

            this.ProductsGrid.TableDescriptor.AllowEdit = false;

            this.ProductsGrid.DataSource = this.productLogic.All().ToList();

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
            var form = new ProductForm
            {
                //TopMost = true
            };
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.ProductsGrid.DataSource = this.productLogic.All().ToList();
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            this.ProductsGrid.TableControlCurrentCellControlDoubleClick += new GridTableControlControlEventHandler(gridGroupingControl1_TableControlCurrentCellControlDoubleClick);
        }

        private void gridGroupingControl1_TableControlCurrentCellControlDoubleClick(object sender, GridTableControlControlEventArgs e)
        {

            ShowEditWindow();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var record = this.ProductsGrid.Table.CurrentRecord;
            if (record != null)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }

            ShowEditWindow();
        }

        private void ShowEditWindow()
        {
            var record = this.ProductsGrid.Table.CurrentRecord;

            var form = new ProductForm
            {
                //TopMost = true
                Product = new Entities.ProductoEntity { idProd = Convert.ToInt32(record.GetValue("idProd")) }
            };

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.ProductsGrid.DataSource = this.productLogic.All().ToList();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            input
        }
    }
}
