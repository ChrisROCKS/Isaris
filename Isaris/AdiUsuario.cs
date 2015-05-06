using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Isaris.BusinessLayer;
using Isaris.Entities;

namespace Isaris
{
    public partial class AdiUsuario : MetroForm
    {
        public AdiUsuario()
        {
            InitializeComponent();
        }
        UserEntity user = new UserEntity();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            user.name = txtNombre.Text;
            user.permisos = cmbPermiso.Text;
            user.pw = txtPw.Text;
            user.UserName = txtUser.Text;

            UserBO.Create(user);
            MessageBox.Show("Guardado correctamente!");
        }
    }
}
