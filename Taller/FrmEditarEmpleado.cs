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
    public partial class FrmEditarEmpleado : Form
    {
        public static List<Empleado> listaEd = Empleado.Empleados.ToList();
        public FrmEditarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            dgEditarEmpleado.DataSource = listaEd;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            grid();
            lbUsuario.Text = Loggin.nickname;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empleado emp = GetEmpleado(txtBuscar.Text);
            if (emp == null)
            {
                MessageBox.Show("No esta registrada!");
            }
            else
            {
                txtnombre.Text = emp.Nombres;
                txtapellido.Text = emp.Apellidos;
                txtDireccion.Text = emp.Direccion;
                cbxsexo.Text = emp.Sexo.ToString();
                txtCorreo.Text = emp.Correo;
                maskTelef.Text = emp.Telefono;
                dtfechaNac.Text = emp.FechaNac.ToString();
                maskCedula.Text = emp.Cedula;
                cbxestadocivil.Text = emp.EstadoCivil;
                cbxCargo.Text = emp.Cargo;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
            }
        }

        private Empleado GetEmpleado(string buscar)
        {
            return listaEd.Find(x => x.Nombres.Contains(buscar));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmEmpleado f = new FrmEmpleado();
            f.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();

            dgEditarEmpleado.DataSource = null;
            dgEditarEmpleado.DataSource = listaEd;

            FrmEmpleado f = new FrmEmpleado();
            f.dtAgregarEmpleado.DataSource = listaEd;

            grid();
        }

        private void Limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            maskTelef.Clear();
            maskCedula.Clear();
            cbxsexo.Text = "--Seleccione--";
            cbxestadocivil.Text = "--Seleccione--";
            dtfechaNac.Value = DateTime.Now;
            cbxCargo.Text = "--Seleccione--";
            txtBuscar.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modificar();
            dgEditarEmpleado.DataSource = null;
            dgEditarEmpleado.DataSource = listaEd;

            FrmEmpleado f = new FrmEmpleado();
            f.dtAgregarEmpleado.DataSource = listaEd;

            grid();
        }

        private void modificar() 
        {
            Empleado empl = GetEmpleado(txtBuscar.Text);
            if (empl == null)
            {
                MessageBox.Show("No esta registrada!");
            }
            else
            {
                foreach (Empleado emp in listaEd)
                {
                    if (emp.Nombres == txtBuscar.Text)
                    {
                        emp.Nombres = txtnombre.Text;
                        emp.Apellidos = txtapellido.Text;
                        emp.Direccion = txtDireccion.Text;
                        emp.Sexo = cbxsexo.Text[0];
                        emp.Correo = txtCorreo.Text;
                        emp.Telefono = maskTelef.Text;
                        emp.FechaNac = dtfechaNac.Value.Date;
                        emp.Cedula = maskCedula.Text;
                        emp.EstadoCivil = cbxestadocivil.Text;
                        emp.Cargo = cbxCargo.Text;  
                    }
                }
            }
        }

        private void eliminar() 
        {
            if (txtnombre.Text == "")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estas seguro de eliminar el registro?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    foreach (Empleado emp in listaEd)
                    {
                        if (emp.Nombres == txtnombre.Text)
                        {
                            listaEd.Remove(emp);
                            break;
                        }
                    }
                    Limpiar();
                }

            }
        }

        private void grid()
        {
            dgEditarEmpleado.Columns[0].Visible = false;
            dgEditarEmpleado.Columns[1].Visible = false;
            dgEditarEmpleado.Columns[4].Visible = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            FrmEmpleado frmEmp = new FrmEmpleado();            
            frmEmp.Show();
            this.Close();
        }
    }
}
