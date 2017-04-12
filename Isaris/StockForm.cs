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
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.TopMost = true;
            form.ShowDialog();
        }
    }
}
