using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos1
{
    class Telefonos
    {
        private List<Telefono> telefonos;

        public Telefonos()
        {
            telefonos = new List<Telefono>();
        }

        public string listado()
        {
            string retorno = "";

            foreach (Telefono telefono in telefonos)
            {
                retorno = retorno + telefono.ToString() + "\n";
            }

            return (retorno);
        }

        public bool agregar(Telefono telefono)
        {
            if (!telefonos.Contains(telefono))
            {
                telefonos.Add(telefono);
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public Telefono obtener(int pais, int area, int numero)
        {
            Telefono retorno = null;
            Telefono aBuscar = new Telefono("", pais, area, numero);

            int posicion = this.telefonos.IndexOf(aBuscar);

            if (posicion != -1)
            {
                retorno = telefonos[posicion];
            }

            return (retorno);
        }
    }
}
}
