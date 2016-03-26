using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Isaris.Entities;
using Isaris.DataAccess;
using Isaris.DataAccess.Models;

namespace Isaris.BusinessLayer
{
    public static class FacturaBO
    {
        public static IEnumerable<facturas> GetAll()
        {
            return FacturaDAL.GetAll();
        }

        public static void RegistrarFacturacion(FacturaEntity invoice)
        {
            //
            // inicializo la transacciones
            //
            using (TransactionScope scope = new TransactionScope())
            {
                //
                // Creo la factura y sus lineas
                //
                FacturaDAL.Create(invoice);
                //
                // Actualizo el total
                //

                FacturaDAL.UpdateTotal(invoice.idFactura, invoice.total);

                scope.Complete();
            }

        }
        public static void RegistrarCotizacion(FacturaEntity invoice)
        {
            //
            // inicializo la transacciones
            //
            using (TransactionScope scope = new TransactionScope())
            {
                //
                // Creo la factura y sus lineas
                //
                FacturaDAL.Create(invoice);
                //
                // Actualizo el total
                //

                CotizacionDAL.UpdateTotal(invoice.idFactura, invoice.total);

                scope.Complete();
            }

        }
        public static DataTable CreateDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "myDataTable";
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
