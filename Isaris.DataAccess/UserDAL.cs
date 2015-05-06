using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using Isaris.Entities;
using System.Windows.Forms;
using System.Data;

namespace Isaris.DataAccess
{
    public class UserDAL
    {
         static string valorHash(string cadena)
        {
            return cadena.GetHashCode().ToString();
        }
        public static void Create(UserEntity user)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();
                //
                // Creacion de la Factura
                //
                string sql = @"INSERT INTO usuarios (usuario, pw, permisos,nombre) VALUES (@user, @pw, @permiso,@nombre)";

                MySqlCommand cmd = new MySqlCommand(sql,conn);

                string pass = valorHash(user.pw);

                cmd.Parameters.AddWithValue("@user", user.UserName);
                cmd.Parameters.AddWithValue("@pw", pass);
                cmd.Parameters.AddWithValue("@permiso", user.permisos);
                cmd.Parameters.AddWithValue("@nombre", user.name);

                cmd.ExecuteNonQuery();

            }
        }
        public static UserEntity ValidarUsuario(string user, string pw)
        {
            UserEntity userE = null;

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();
                
                
                string sql = @"select * from usuarios where usuarios.usuario = @user and usuarios.pw = @pw";

                string passw = valorHash(pw);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pw", passw);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    userE = LoadUser(reader);
                }

                return userE;
                
            }
        }
        private static UserEntity LoadUser(IDataReader reader)
        {
            UserEntity user = new UserEntity();

            user.name = Convert.ToString(reader["nombre"]);
            user.permisos = Convert.ToString(reader["permisos"]);
            user.pw = "";
            user.UserName = "";
            

            return user;
        }
        public static bool Autenticar(string usuario, string password)
        {
            string sql = @"SELECT *
                      FROM usuarios
                      WHERE usuario = @nombre AND pw = @password";


            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@nombre", usuario);

                //string hash = Helper.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                    return false;
                else
                    return true;

            }
        }

    }
}
