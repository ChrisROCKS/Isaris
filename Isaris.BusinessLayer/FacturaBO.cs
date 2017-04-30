using System.Data;
using System.Linq;
using System.Transactions;
using Isaris.Entities;
using Isaris.DataAccess;
using Isaris.DataAccess.Repositories;
using Isaris.DataAccess.Contexts;
using Isaris.DataAccess.Models;
using System.Collections.Generic;

namespace Isaris.BusinessLayer
{
    public class FacturaBO
    {
        private readonly ProductoBO productManager;
        private readonly InvoiceRepository invoiceRepository;
        private readonly IsarisContext context;

        public FacturaBO()
        {
            this.context = new IsarisContext();
            this.invoiceRepository = new InvoiceRepository(context);
            this.productManager = new ProductoBO();
        }

        public void RegistrarFacturacion(FacturaEntity invoice)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                FacturaDAL.Create(invoice);

                invoice.Lineas.ForEach(x => productManager.SubtractQuantity(x.IdProd, x.Cantidad));

                FacturaDAL.UpdateTotal(invoice.IdFactura, invoice.Total);

                scope.Complete();
            }

        }
        public static void RegistrarCotizacion(FacturaEntity invoice)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                FacturaDAL.Create(invoice);

                CotizacionDAL.UpdateTotal(invoice.IdFactura, invoice.Total);

                scope.Complete();
            }
        }

        public IQueryable<Invoice> FindInvoiceById(int invoiceId)
        {
            return this.invoiceRepository.Filter(x => x.Id == invoiceId);
        }

        public IEnumerable<InvoiceReportModel> FindInvoiceReportById(int invoiceId)
        {
            return this.FindInvoiceById(invoiceId).SelectMany(i => i.InvoiceDetails, (invoice, detail) => new InvoiceReportModel
            {
                Address = invoice.Customer.Address,
                ClientName = invoice.Customer.Name,
                Date = invoice.Date,
                Discount = invoice.Discount,
                InvoiceId = invoice.Id,
                Price = detail.Price,
                ProductId = detail.ProductId,
                ProductName = detail.Product.Name,
                Quantity = detail.Quantity,
                SellerName = invoice.SellerName,
                Telephone = invoice.Customer.Telephone,
                Total = invoice.Total,
                Unit = detail.Unit,
                Value = detail.Value ?? 0
            });
        }

        public static DataTable CreateDataTable()
        {
            DataTable table = new DataTable()
            {
                TableName = "myDataTable"
            };
            DataColumn myColumn;

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.String");
            myColumn.ColumnName = "codigo";
            table.Columns.Add(myColumn);

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.String");
            myColumn.ColumnName = "descripcion";
            table.Columns.Add(myColumn);

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.Single");
            myColumn.ColumnName = "cantidad";
            table.Columns.Add(myColumn);

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.Double");
            myColumn.ColumnName = "precio";
            table.Columns.Add(myColumn);

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.String");
            myColumn.ColumnName = "unidad";
            table.Columns.Add(myColumn);

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.Double");
            myColumn.ColumnName = "valor";
            myColumn.Expression = "precio * cantidad";
            table.Columns.Add(myColumn);

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.Single");
            myColumn.ColumnName = "existencia";
            table.Columns.Add(myColumn);

            myColumn = new DataColumn();
            myColumn.DataType = System.Type.GetType("System.Single");
            myColumn.ColumnName = "nuevaExistencia";
            myColumn.Expression = "existencia - cantidad";
            table.Columns.Add(myColumn);

            return table;
        }
    }

}
