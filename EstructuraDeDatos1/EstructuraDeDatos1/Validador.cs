﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EstructuraDeDatos1
{
    class Validador
    {
        public string pedirOpcionDeMenu()
        {
            string menu = "";
            string opcionMenu = "";
            const string opcionUno = "1";
            const string opcionDos = "2";
            const string opcionTres = "3";

            do
            {
                Console.WriteLine("Menu Principal");
                menu = "1 - Nueva persona" + "\n";
                menu = menu + "2 - Listar personas cargadas" + "\n";
                menu = menu + "3 - Salir" + "\n";
                opcionMenu = pedirString(menu);
                if (opcionMenu != opcionUno && opcionMenu != opcionDos && opcionMenu != opcionTres)
                {
                    Console.WriteLine("Debe ingresar una opción válida" + "\n");
                }
            } while (opcionMenu != opcionUno && opcionMenu != opcionDos && opcionMenu != opcionTres);

            return opcionMenu;
        }

        public string pedirString(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();
                if (retorno == "")
                {
                    Console.WriteLine("El string no puede estar vacio" + "\n");
                }
            } while (retorno == "");
            return (retorno);
        }

        public int pedirInteger(string mensaje, int minimo, int maximo)
        {
            int numero = minimo - 1;
            bool pudeConvertir;

            do
            {
                Console.WriteLine(mensaje);
                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                if (pudeConvertir)
                {
                    if (numero < minimo || numero > maximo)
                    {
                        Console.WriteLine(mensaje);
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numerico" + "\n");
                    numero = minimo - 1;
                }
            } while (numero < minimo || numero > maximo);

            return numero;
        }

        public double pedirDouble(string mensaje, double minimo, int maximo)
        {
            double retorno = 0;
            do
            {
                Console.WriteLine(mensaje);
                if (Double.TryParse(Console.ReadLine(), out retorno))
                {
                    if (retorno < minimo && retorno > maximo)
                    {
                        Console.WriteLine("El valor debe estar entre " + minimo + " y " + maximo + "\n");
                    }
                }
                else
                {
                    retorno = minimo - 1;
                }
            } while (retorno < minimo && retorno > maximo);
            return (retorno);
        }

        public string pedirSoN(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine().ToUpper();
                if (retorno != "S" && retorno != "N")
                {
                    Console.WriteLine("El string debe ser S o N" + "\n");
                }
            } while (retorno != "S" && retorno != "N");
            return (retorno);
        }

        public string pedirChar(string mensaje, int maximo)
        {
            string retorno = "";
            Regex Val = new Regex(@"^[a-zA-Z]+$");
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();
                if (retorno == "")
                {
                    Console.WriteLine("El campo no puede estar vacio" + "\n");
                    continue;
                }
                if (!Val.IsMatch(retorno))
                {
                    Console.WriteLine("El campo solo debe contener letras" + "\n");
                    continue;
                }
                if (retorno.Length > maximo)
                {
                    Console.WriteLine("El campo solo admite 30 caracteres" + "\n");
                    continue;
                }
            } while (retorno == "" || !Val.IsMatch(retorno) || retorno.Length > maximo);
            return (retorno);
        }

        public DateTime pedirFecha(string mensaje)
        {
            do
            {
                Console.WriteLine(mensaje);
                var ingreso = Console.ReadLine();
                if (!DateTime.TryParse(ingreso, out var fechaNacimiento))
                {
                    Console.WriteLine("No es una fecha válida");
                    continue;
                }
                if (fechaNacimiento > DateTime.Now)
                {
                    Console.WriteLine("La fecha debe ser menor a la actual");
                    continue;
                }
                return fechaNacimiento;
            }
            while (true);
        }

        public string pedirTipo(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine().ToUpper();
                if (retorno != "CASA" && retorno != "TRABAJO" && retorno != "OTRO")
                {
                    Console.WriteLine("El tipo debe ser CASA/TRABAJO/OTRO" + "\n");
                }
            } while (retorno != "CASA" && retorno != "TRABAJO" && retorno != "OTRO");
            return (retorno);
        }
    }
}
