using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos1
{
    class ConjuntoDePersonas
    {
        private List<Persona> personas;

        public ConjuntoDePersonas()
        {
            personas = new List<Persona>();
        }

        public string listado()
        {
            string retorno = "";

            foreach (Persona persona in personas)
            {
                retorno = retorno + persona.ToString() + "\n";
            }

            return (retorno);
        }

        public bool agregar(Persona persona)
        {
            if (!personas.Contains(persona))
            {
                personas.Add(persona);
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public Persona obtener(int documento)
        {
            Persona retorno = null;
            Persona aBuscar = new Persona(documento, "", "", default, null);

            int posicion = this.personas.IndexOf(aBuscar);

            if (posicion != -1)
            {
                retorno = personas[posicion];
            }

            return (retorno);
        }
    }
}
