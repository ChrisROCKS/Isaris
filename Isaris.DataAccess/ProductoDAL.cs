using System;
using System.Data;
using Isaris.Entities;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Isaris.DataAccess
{
    public class ProductoDAL
    {
        public ProductoDAL()
        {

        }

        public static ProductoEntity GetById(int id)
        {
            ProductoEntity prod = new ProductoEntity();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"SELECT * 
                                FROM inventario 
                                WHERE codproducto = @codcliente";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codcliente", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    prod.idProd = Convert.ToInt32(reader["codproducto"]);
                    prod.nombre = Convert.ToString(reader["nombre"]);
                    prod.proveedor = Convert.ToString(reader["proveedor"]);
                    prod.existencia = Convert.ToInt32(reader["existencia"]);

                    prod.unidad = Convert.ToString(reader["unidad"]);
                    prod.precioTerranova = Convert.ToDecimal(reader["precioTerranova"]);
                    prod.precio = Convert.ToDecimal(reader["precio"]);
                }

            }

            return prod;

        }

        public static ProductoEntity Update(ProductoEntity prod)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"UPDATE inventario SET  
                                            nombre = @nombre, 
                                            precio = @precio,
                                            precioTerranova = @precioTerranova,
                                            unidad = @unidad,
                                            proveedor = @provider
                                    WHERE codproducto = @idProd";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombre", prod.nombre);

                cmd.Parameters.AddWithValue("@precio", prod.precioTerranova);
                cmd.Parameters.AddWithValue("@unidad", prod.unidad);
                cmd.Parameters.AddWithValue("@provider", prod.proveedor);
                cmd.Parameters.AddWithValue("@precioTerranova", prod.precioTerranova);
                cmd.Parameters.AddWithValue("@idProd", prod.idProd);


                cmd.ExecuteNonQuery();
            }

            return prod;
        }
        public static ProductoEntity GetByName(string nombre,string campoPrecio)
        {
            ProductoEntity prod = new ProductoEntity();
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"SELECT * FROM inventario where nombre = '" + nombre+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    prod.idProd = Convert.ToInt32(reader["codproducto"]);
                    prod.nombre = Convert.ToString(reader["nombre"]);
                    prod.proveedor = Convert.ToString(reader["proveedor"]);
                    prod.existencia = Convert.ToInt32(reader["existencia"]);

                    prod.unidad = Convert.ToString(reader["unidad"]);
                    prod.precioTerranova = Convert.ToDecimal(reader[campoPrecio]);
                }
            }

            return prod;
        }
        public static bool Exists(int id)
        {
            int nrorecord = 0;

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"SELECT Count(*)
                                FROM inventario 
                                WHERE codproducto = @customerId";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("customerId", id);

                nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return nrorecord > 0;

        }
        public static ProductoEntity Create(ProductoEntity prod)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                string sql = @"INSERT INTO inventario (nombre, precio,precioTerranova,existencia,unidad, proveedor) 
                                    VALUES (@nombre, @precio,@precioTerranova,@existencia,@unidad, @provider)";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombre", prod.nombre);
                cmd.Parameters.AddWithValue("@precio", prod.precio);
                cmd.Parameters.AddWithValue("@precioTerranova", prod.precioTerranova); 
                cmd.Parameters.AddWithValue("@existencia", prod.existencia);
                cmd.Parameters.AddWithValue("@provider", prod.proveedor);
                cmd.Parameters.AddWithValue("@unidad", prod.unidad);

                cmd.ExecuteNonQuery();
            }

            return prod;
        }
        public static DataSet LoadDataSet(DataSet dt)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                MySqlDataAdapter daDatos = new MySqlDataAdapter("select * from inventario", conn);
                daDatos.FillSchema(dt, SchemaType.Source, "productos");
                daDatos.Fill(dt, "productos");
                daDatos.Dispose();
            }
            return dt;
        }
        public static void UpdateStock(int idProduct, float Quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand("UPDATE inventario SET existencia = @nuevaExistencia WHERE codproducto = @idProd",conn);
                cmd.Parameters.AddWithValue("@nuevaExistencia", Quantity);
                cmd.Parameters.AddWithValue("@idProd", idProduct);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
    }
}