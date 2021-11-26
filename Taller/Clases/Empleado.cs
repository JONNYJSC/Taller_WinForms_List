using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    public class Empleado : Persona
    {
        public Empleado() : base()
        {
        }

        public Empleado(int id, string nombres, string apellidos, string direccion, char sexo, string correo, string telefono, DateTime fechaNac, string cedula, string estadoCivil, string codigo, DateTime fechaInicio, string cargo, int anosExperiencia) : base(id, nombres, apellidos, direccion, sexo, correo, telefono, fechaNac, cedula, estadoCivil)
        {
            Codigo = codigo;
            FechaInicio = fechaInicio;
            Cargo = cargo;
            AnosExperiencia = anosExperiencia;
        }
        public string Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Cargo { get; set; }
        public int AnosExperiencia { get; set; }

        private static List<Empleado> misEmpleados = new List<Empleado>();

        public static List<Empleado> Empleados
        {
            get { return misEmpleados; }
        }
    }
}
