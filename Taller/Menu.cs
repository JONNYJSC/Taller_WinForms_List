using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller.Clases;

namespace Taller
{
    public partial class Menu : Form
    { 
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = Loggin.nickname;
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleado frmEditarEmpleado = new FrmEditarEmpleado();
            frmEditarEmpleado.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que desea salir?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {                
                Application.Exit();
            }
        }
    }
}
