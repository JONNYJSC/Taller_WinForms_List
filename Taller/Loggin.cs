using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller.Clases;

namespace Taller
{
    public partial class Loggin : Form
    {
        public static string nickname = "", password = "";
        public Loggin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void openMdi(object obj)
        {
            Application.Run(new Menu());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Iniciar()
        {
            foreach (var i in Login.listaUser)
            {
                if (i.NickName == txtnickname.Text && i.Password == txtpass.Text)
                {
                    nickname = i.NickName;
                    password = i.Password;
                }
            }

            Login l = new Login();
            l.NickName = nickname;
            l.Password = password;

            if (l.NickName == txtnickname.Text && l.Password == txtpass.Text)
            {
                MessageBox.Show("Bienvenido!!!");
                this.Close();
                Thread th = new Thread(openMdi);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("No existe el User!!!");
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Iniciar();
            }
        }
    }
}
