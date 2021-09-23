using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos1
{
    class Telefono
    {
        private string tipo;
        private int pais;
        private int area;
        private int numero;

        public Telefono(string tipo, int pais, int area, int numero)
        {
            this.tipo = tipo;
            this.pais = pais;
            this.area = area;
            this.numero = numero;
        }

        public override bool Equals(object obj)
        {
            var telefono = obj as Telefono;
            return telefono != null &&
                   pais == telefono.pais &&
                   area == telefono.area &&
                   numero == telefono.numero;
        }

        public override string ToString()
        {
            return "Tipo: " + tipo + " - Pais: " + pais + " - Area: " + area + " - Número: " + numero;
        }
    }
}
