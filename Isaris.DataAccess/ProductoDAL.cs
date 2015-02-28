using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Isaris.Entities;
using MySql.Data.MySqlClient;
using System.Configuration;
//using System.Windows.Forms;

namespace Isaris.DataAccess
{
    public class ProductoDAL
    {
        //public static List<ProductoEntity> GetAll(string campoPrecio)
        //{
        //    List<ProductoEntity> list = new List<ProductoEntity>(); ;

        //    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
        //    {
        //        conn.Open();

        //        string sql = @"SELECT codproducto, nombre FROM inventario ORDER BY nombre";
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            list.Add(LoadProd(reader,campoPrecio));
        //        }

        //    }

        //    return list;
        //}
        //private static ProductoEntity LoadProd(IDataReader reader,string campoPrecio)
        //{
        //    ProductoEntity track = new ProductoEntity();

        //    track.idProd = Convert.ToInt32(reader["codproducto"]);
        //    track.nombre = Convert.ToString(reader["nombre"]);
        //    track.proveedor = Convert.ToString(reader["proveedor"]);
        //    track.existencia = Convert.ToInt32(reader["existencia"]);

        //    track.unidad = Convert.ToString(reader["unidad"]);
        //    track.precio = Convert.ToSingle(reader[campoPrecio]);


        //    return track;
        //}
        public static ProductoEntity Update(ProductoEntity prod)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"UPDATE inventario SET  
                                            nombre = @nombre, 
                                            precio = @precio,
                                            precioTerranova = @precioTerranova,
                                            unidad = @unidad
                                    WHERE codproducto = @idProd";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombre", prod.nombre);

                cmd.Parameters.AddWithValue("@precio", prod.precioTerranova);
                cmd.Parameters.AddWithValue("@unidad", prod.unidad);
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
                    prod.precioTerranova = Convert.ToSingle(reader[campoPrecio]);
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
                string sql = @"INSERT INTO inventario (codproducto, nombre, precio,existencia,proveedor,unidad) 
                                    VALUES (@codprod, @nombre, @precio,@existencia,@proveedor,@unidad)";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codprod", prod.idProd);
                cmd.Parameters.AddWithValue("@nombre", prod.nombre);
                cmd.Parameters.AddWithValue("@precio", prod.precioTerranova); 
                
                cmd.Parameters.AddWithValue("@existencia", prod.existencia);
                cmd.Parameters.AddWithValue("@proveedor", prod.proveedor);
                cmd.Parameters.AddWithValue("@unidad", prod.unidad);

                cmd.ExecuteNonQuery();
                //cliente.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static void UpdateStock(int idProduct,float Quantity)
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