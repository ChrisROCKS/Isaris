using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Isaris.Entities;
using MySql.Data.MySqlClient;
using System.Configuration;
using Isaris.DataAccess.Models;
using DapperExtensions;

namespace Isaris.DataAccess
{
    public class FacturaDAL
    {
        public static IEnumerable<facturas> GetAll()
        {
            using (
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString())
                )
            {
                conn.Open();
                var list = conn.GetList<facturas>();
                return list;
            }
        }

        public static
            void Create(FacturaEntity factura)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();
                //
                // Creacion de la Factura
                //
                string sqlFactura = @"INSERT INTO facturas (codcliente, fecha, vendedor,descuento, Total) VALUES (@idCliente, @fecha, @vendedor,@descuento, @total);
                           SELECT LAST_INSERT_ID()";

                using (MySqlCommand cmd = new MySqlCommand(sqlFactura, conn))
                {

                    cmd.Parameters.AddWithValue("@idCliente", factura.idCliente);
                    cmd.Parameters.AddWithValue("@fecha", factura.fecha);
                    cmd.Parameters.AddWithValue("@vendedor", factura.vendedor);
                    cmd.Parameters.AddWithValue("@descuento", factura.descuento);
                    cmd.Parameters.AddWithValue("@total", 0);

                    factura.idFactura = Convert.ToInt32(cmd.ExecuteScalar());
                }


                string sqlLineaFactura = @"INSERT INTO detallefactura (codfactura, codproducto, precio, cantidad) 
                                            VALUES (@invoiceid, @trackid, @unitprice, @quantity);
                                            SELECT LAST_INSERT_ID()";

                using (MySqlCommand cmd = new MySqlCommand(sqlLineaFactura, conn))
                {

                    foreach (DetalleEntity detalle in factura.Lineas)
                    {
                        //
                        // como se reutiliza el mismo objeto SqlCommand es necesario limpiar los parametros
                        // de la operacion previa, sino estos se iran agregando en la coleccion, generando un fallo
                        //
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@invoiceid", factura.idFactura);
                        cmd.Parameters.AddWithValue("@trackid", detalle.idProd);
                        cmd.Parameters.AddWithValue("@unitprice", detalle.precio);
                        cmd.Parameters.AddWithValue("@quantity", detalle.cantidad);

                        //
                        // Si bien obtenermos el id de linea de factura, este no es usado
                        // en la aplicacion
                        //
                        detalle.idDetalle = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                }

            }
        }
        public static void UpdateTotal(int idInvoice, double total)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sqlUpdateTotal = @"UPDATE facturas SET total = @total WHERE codfactura = @InvoiceId";

                using (MySqlCommand cmd = new MySqlCommand(sqlUpdateTotal, conn))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@InvoiceId", idInvoice);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static int UltimaFact()
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();
                //string sql = @"select ";
                return 0;
            }
        }
        public static DataSet CreateFactReport(DataSet ds1)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = "SELECT f.vendedor,f.fecha,f.total,d.*,c.nombre as cliente,c.direccion, i.nombre as descripcion" +
                "FROM facturas as f, clientes as c, inventario as i,detallefactura as d" +
                "WHERE f.codcliente = c.codcliente and f.codcliente =1 and d.codproducto = i.codproducto and f.codfactura =1";

                MySqlDataAdapter daFactura = new MySqlDataAdapter(sql, conn);
                daFactura.Fill(ds1, @"repfactura");
            }
            return ds1;
        }
    }
}
