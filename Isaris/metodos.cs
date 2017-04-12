using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Threading.Tasks;
//using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Isaris
{
    class metodos
    {
        public static DataTable Datos(string tabla)
        {
            DataTable dt;

            using(MySqlConnection conexion =new MySqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conexion.Open();
                dt = new DataTable();
                MySqlCommand comando = new MySqlCommand("Select * From " + tabla, conexion);

                MySqlDataAdapter adap = new MySqlDataAdapter(comando);

                adap.Fill(dt);
                
            }
            return dt;
        }
        public static AutoCompleteStringCollection Autocomplete(string tabla)
        {
            DataTable dt2 = Datos(tabla);
            //auto complete con sql
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row["nombre"]));
            }

            return coleccion;
        }
        public static void Borrar(Form frm, Control control)
        {
            foreach(MetroTextBox mtxt in frm.Controls.OfType<MetroTextBox>())
            {
                mtxt.Clear();
            }

            control.Focus();
        }
    }
}
