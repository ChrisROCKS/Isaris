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
using Isaris.Entities;
using Isaris.BusinessLayer;

namespace Isaris
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        UserEntity user;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            user = UserBO.Login(txtUser.Text, txtPw.Text);
            if(user != null)
            {
                UserBO.nombreUsuario = user.name;
                UserBO.permisos = user.permisos;

                Menu m = new Menu();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no valido!");
            }

            
        }
    }
}
