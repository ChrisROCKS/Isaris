using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Isaris
{
    public partial class frm1 : MetroForm
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visor v = new Visor();
            MySqlConnection conex = new MySqlConnection("Database=chinook;Data Source=localhost;User Id=root;Password=");
            conex.Open();
            MySqlDataAdapter da_album;
            da_album = new MySqlDataAdapter("SELECT AlbumId,Title,artist.ArtistId,name as nombre from album,artist where album.AlbumId=artist.ArtistId", conex);
            da_album.FillSchema(v.dataSet11, SchemaType.Source, "repalbum");
            da_album.Fill(v.dataSet11, "repalbum");

            v.informe.Load("crystalrep.rpt");
            v.informe.SetDataSource(v.dataSet11);

            v.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Visor v = new Visor();
            MySqlConnection conex = new MySqlConnection("Database=chinook;Data Source=localhost;User Id=root;Password=");
            conex.Open();
            MySqlDataAdapter da_album;
            da_album = new MySqlDataAdapter("SELECT AlbumId,Title,artist.ArtistId,name as nombre from album,artist where album.AlbumId=artist.ArtistId", conex);
            da_album.FillSchema(v.dataSet11, SchemaType.Source, "repalbum");
            da_album.Fill(v.dataSet11, "repalbum");

            v.informe.Load("crystalrep.rpt");
            v.informe.SetDataSource(v.dataSet11);

            v.Show();
        }
    }
}
