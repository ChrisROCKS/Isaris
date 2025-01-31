﻿using System;
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
