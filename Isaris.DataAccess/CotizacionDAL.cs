using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Isaris.Entities;
using System.Configuration;

namespace Isaris.DataAccess
{
    public class CotizacionDAL
    {
        public static void Create(FacturaEntity factura)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();
                //
                // Creacion de la Factura
                //
                string sqlFactura = @"INSERT INTO cotizaciones (codcliente, fecha, vendedor,descuento, Total,) VALUES (@idCliente, @fecha, @vendedor,@descuento, @total);
                           SELECT LAST_INSERT_ID()";

                using (MySqlCommand cmd = new MySqlCommand(sqlFactura, conn))
                {

                    cmd.Parameters.AddWithValue("@idCliente", factura.IdCliente);
                    cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                    cmd.Parameters.AddWithValue("@vendedor", factura.Vendedor);
                    cmd.Parameters.AddWithValue("@descuento", factura.Descuento);
                    cmd.Parameters.AddWithValue("@total", 0);
                    
                    factura.IdFactura = Convert.ToInt32(cmd.ExecuteScalar());
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

                        cmd.Parameters.AddWithValue("@invoiceid", factura.IdFactura);
                        cmd.Parameters.AddWithValue("@trackid", detalle.IdProd);
                        cmd.Parameters.AddWithValue("@unitprice", detalle.Precio);
                        cmd.Parameters.AddWithValue("@quantity", detalle.Cantidad);

                        //
                        // Si bien obtenermos el id de linea de factura, este no es usado
                        // en la aplicacion
                        //
                        detalle.IdDetalle = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                }

            }
        }
        public static void UpdateTotal(int idInvoice, decimal total)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sqlUpdateTotal = @"UPDATE cotizaciones SET total = @total WHERE codcotizacion = @InvoiceId";

                using (MySqlCommand cmd = new MySqlCommand(sqlUpdateTotal, conn))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@InvoiceId", idInvoice);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
