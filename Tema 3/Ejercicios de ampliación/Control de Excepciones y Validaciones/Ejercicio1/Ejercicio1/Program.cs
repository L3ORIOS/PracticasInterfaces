using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            string nombre;
            string correo;
            int edad;

            Console.WriteLine("Control de Excepciones y Validaciones - Ejercicio 1 - Leo Rios - 2º DAM");
            Console.WriteLine(Environment.NewLine);
            do {
                
                nombre = NombreValido();
                correo = CorreoValido();
                edad = EdadValida();
                Console.WriteLine($"Registro completo: Nombre -{nombre}, Correo -{correo}, Edad -{edad}");
                end = FinDePrograma();

            } while (!end);

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();

        }

        public static string CorreoValido() {

            bool valido = false;
            string correo = string.Empty;
            string patter = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            do {

                try {
                    
                    Console.Write("Introduce tu correo: ");
                    string correoValido = Console.ReadLine();

                    if (string.IsNullOrEmpty(correoValido))
                    {
                        throw new Exception("Cadena vacia o nula");
                    }
                    else if (Regex.IsMatch(correoValido, patter))
                    {
                        valido = true;
                        correo = correoValido;
                    }
                    else
                    {
                        throw new Exception("Formato no correcto.");
                    }
                }
                catch(Exception e) 
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            
            } while (!valido);

            return correo;
        }

        public static int EdadValida() {
            int edad = -1;
            bool valido = false;
            do {
                try {
                    
                    Console.Write("Introduce tu edad: ");
                    string edadAux = Console.ReadLine();
                    if (!int.TryParse(edadAux, out edad))
                    {
                        throw new Exception("Error: No es una entrada valida.");
                    }
                    else if (edad <= 0 | edad >= 120)
                    {
                        throw new Exception("Error: Edad no valida");
                    }
                    else {
                        valido = true;
                    }

                } catch (Exception e) {
                    Console.WriteLine(e.Message);   
                }
               
            } while (!valido);

            return edad;
        }

        public static string NombreValido() 
        {
            string nombreValido = string.Empty;
            bool valido = false;

            do {
                
                Console.Write("Introduce un nombre: ");
                string nombreAux = Console.ReadLine().Trim();
                string pattern = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]{3,}(?:\s[a-zA-ZáéíóúÁÉÍÓÚñÑ]{3,})*$";

                try
                {
                    if (string.IsNullOrEmpty(nombreAux))
                    {
                        throw new Exception("Error: entrada vacia.");
                    }
                    else if (Regex.IsMatch(nombreAux, pattern))
                    {
                        nombreValido = nombreAux;
                        valido = true;
                    }
                    else 
                    {
                        throw new Exception("Error: Formato no valido");                    
                    }
                } 
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);   
                } 

            } while (!valido);
            return nombreValido;

        }

        public static bool FinDePrograma()
        {

            bool returnn = false;
            bool error = false;

            do
            {
                Console.WriteLine(Environment.NewLine); 
                Console.WriteLine("¿Desea terminar el programa? ( Y / N )");
                string opcion = Console.ReadLine().Trim().ToLower();

                if (opcion == "y")
                {
                    returnn = true;
                    error = false;

                }
                else if (opcion == "n")
                {
                    returnn = false;
                    error = false;
                  
                }
                else
                {
                    Console.WriteLine("Opción no valida");
                    error = true;
                }

            } while (error);

            return returnn;
        }

    }
}
