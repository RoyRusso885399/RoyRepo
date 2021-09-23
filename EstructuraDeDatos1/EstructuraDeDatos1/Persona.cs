using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos1
{
    class Persona
    {
        private int documento;
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private Telefonos telefonos;

        public Persona(int documento, string nombre, string apellido, DateTime nacimiento, Telefonos telefonos)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.telefonos = telefonos;
        }

        public override bool Equals(object obj)
        {
            var persona = obj as Persona;
            return persona != null &&
                   documento == persona.documento;
        }

        public override string ToString()
        {
            return "Documento: " + documento + " - Nombre: " + nombre + " - Apellido: " + apellido + " - Fecha de nacimiento: " + nacimiento + " - Telefonos: " + telefonos.listado();
        }
    }
}
