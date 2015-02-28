using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Isaris.Entities;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace Isaris.DataAccess
{
    public class ClienteDAL
    {
        public static List<ClienteEntity> GetAll()
        {
            List<ClienteEntity> list = new List<ClienteEntity>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"SELECT codcliente, cliente, direccion, telefono FROM clientes ORDER BY cliente";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadCustomer(reader));
                }
            }

            return list;
        }
        public static ClienteEntity GetById(int id)
        {
            ClienteEntity customer = null;

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"SELECT codcliente, nombre, direccion, telefono 
                                FROM clientes 
                                WHERE codcliente = @codcliente";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("codcliente", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    customer = LoadCustomer(reader);
                }
                
            }

            return customer;

        }

        public static bool Exists(int id)
        {
            int nrorecord = 0;

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"SELECT Count(*)
                                FROM clientes 
                                WHERE codcliente = @customerId";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("customerId", id);

                nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return nrorecord > 0;

        }

        public static ClienteEntity Create(ClienteEntity cliente)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();
                string sql = @"INSERT INTO clientes (nombre, direccion, telefono) 
                                    VALUES (@nombre, @direccion, @telefono);
                               SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);

                cliente.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return cliente;
        }

        public static ClienteEntity Update(ClienteEntity cliente)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                string sql = @"UPDATE cliente SET  
                                            cliente = @nombre, 
                                            direccion = @direccion,
                                            telefono = @telefono
                                    WHERE codcliente = @idcliente";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@idcliente", cliente.idCliente);


                cmd.ExecuteNonQuery();

            }

            return cliente;
        }


        private static ClienteEntity LoadCustomer(IDataReader reader)
        {
            ClienteEntity cliente = new ClienteEntity();

            cliente.idCliente = Convert.ToInt32(reader["codcliente"]);
            cliente.nombre = Convert.ToString(reader["nombre"]);
            cliente.direccion = Convert.ToString(reader["direccion"]);
            cliente.telefono = reader["telefono"].ToString();
            
            return cliente;
        }
    }
}
