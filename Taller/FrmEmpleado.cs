using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller.Clases;

namespace Taller
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = Loggin.nickname;
            cbxsexo.Text = "--Seleccione--";
            cbxestadocivil.Text = "--Seleccione--";
            cbxCargo.Text = "--Seleccione--";            
            
            cargar();
        }

        private bool validar(string dato)
        {
            if (dato == string.Empty)
            {
                MessageBox.Show("Ingrese el dato!");
                return false;
            }
            return true;
        }

        public bool cargar() 
        {
            bool band = false;
            dtAgregarEmpleado.DataSource = Empleado.Empleados;
            dtAgregarEmpleado.Columns[4].Visible = false;
            return band;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarPersona();
            MessageBox.Show("Empleado Ingresado");
        }

        private void AgregarPersona()
        {
            Empleado emp = new Empleado();

            emp.Nombres = txtnombre.Text;
            emp.Apellidos = txtapellido.Text;
            emp.Direccion = txtDireccion.Text;
            emp.Sexo = cbxsexo.Text[0];
            emp.Correo = txtCorreo.Text;
            emp.Telefono = maskTelef.Text;
            emp.FechaNac = dtfechaNac.Value.Date;
            emp.Cedula = maskCedula.Text;
            emp.EstadoCivil = cbxestadocivil.Text;

            emp.Codigo = txtCodigo.Text;
            emp.FechaInicio = dtFechaInicio.Value.Date;
            emp.Cargo = cbxCargo.Text;
            emp.AnosExperiencia = int.Parse(txtExp.Text);

            Empleado.Empleados.Add(emp);
            dtAgregarEmpleado.DataSource = null;
            dtAgregarEmpleado.DataSource = Empleado.Empleados;
            dtAgregarEmpleado.Columns[4].Visible = false;
            Limpiar();
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
            txtCodigo.Clear();
            dtFechaInicio.Value = DateTime.Now;
            cbxCargo.Text = "--Seleccione--";
            txtExp.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleado f = new FrmEditarEmpleado();
            f.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporte report = new FrmReporte();
            report.Show();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dtAgregarEmpleado.DataSource = FrmEditarEmpleado.listaEd;
        }
    }
}
