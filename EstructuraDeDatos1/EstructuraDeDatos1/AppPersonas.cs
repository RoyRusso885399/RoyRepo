using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos1
{
    class AppPersonas
    {
        private Validador validador;
        private ConjuntoDePersonas personas;
        private Telefonos telefonos;

        public AppPersonas()
        {
            validador = new Validador();
            personas = new ConjuntoDePersonas();
            telefonos = new Telefonos();
        }

        public void ejecutar()
        {
            string opcion = "";

            do
            {
                opcion = validador.pedirOpcionDeMenu();
                if (opcion == "1")
                {
                    nuevaPersona();
                }
                else if (opcion == "2")
                {
                    listarPersonas();
                }
            } while (opcion != "3");
        }

        private void listarPersonas()
        {
            Console.WriteLine(personas.listado());
        }

        private void nuevaPersona()
        {
            int documento = validador.pedirInteger("Ingrese el documento de la persona\n", 1000000, 999999999);

            Persona persona = personas.obtener(documento);

            if (persona != null)
            {
                Console.WriteLine("Esta persona ya fue ingresada anteriormente" + "\n");
            }
            else
            {
                string nombre = validador.pedirChar("Ingrese nombre de la persona\n", 30);
                string apellido = validador.pedirChar("Ingrese apellido de la persona\n", 30);
                DateTime nacimiento = validador.pedirFecha("Ingrese la fecha de nacimiento de la persona\n");
                
                nuevosTelefonos();

                personas.agregar(new Persona(documento, nombre, apellido, nacimiento, telefonos));

                Console.WriteLine("Persona ingresada" + "\n");
            }
        }

        private void nuevosTelefonos()
        {
            string continuar = "S";

            do
            {
                string tipo = validador.pedirTipo("Ingrese el tipo de telefono\n");
                int pais = validador.pedirInteger("Ingrese el código del país\n", 0, 99);
                int area = validador.pedirInteger("Ingrese el código de área\n", 0, 99);
                int numero = validador.pedirInteger("Ingrese el número de telefono\n", 100000, 99999999);

                telefonos.agregar(new Telefono(tipo, pais, area, numero));

                continuar = validador.pedirSoN("Desea ingresar otro telefono?");
            } while (continuar == "S");
        }
    }
}
