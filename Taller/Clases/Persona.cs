using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public char Sexo { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNac { get; set; }
        public string Cedula { get; set; }
        public string EstadoCivil { get; set; }

        public Persona() { }

        public Persona(int id, string nombres, string apellidos, string direccion, char sexo, string correo, string telefono, DateTime fechaNac, string cedula, string estadoCivil)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Sexo = sexo;
            Correo = correo;
            Telefono = telefono;
            FechaNac = fechaNac;
            Cedula = cedula;
            EstadoCivil = estadoCivil;
        }
    }
}
