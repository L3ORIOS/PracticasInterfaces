using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool promagrama = false;

            Console.WriteLine("Ejercicio 18");



            do {

                ArrayList numeros = new ArrayList();

                Console.WriteLine("Introduzca su nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine($"De acuerdo [{nombre.Trim()}]");
                Console.WriteLine(Environment.NewLine);

                for (int i = 0; i < 5; i ++){
                    Console.WriteLine("Diga un número: ");
                    try
                    {
                        numeros.Add(IfThrowNewNumberException());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error ;: {ex.Message}");
                        i--; // Reintenta la misma iteración
                    }
                };

                int mayor = numeros.IndexOf(0);

                foreach (int numero in numeros) {
                    if (numero > mayor) {
                        mayor = numero; 
                    }
                };

                Console.WriteLine($"El mayor número de los introducidos es: {mayor}");

                Console.WriteLine(Environment.NewLine);
                promagrama = FinDePrograma();
               

            } while (promagrama != false);

            Console.WriteLine("Fin del programa");
            Console.ReadKey();

     
        }

        public static int IfThrowNewNumberException() {
            
            int aux = 0;

            try
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out aux))// Intenta convertir el texto a número.
                {
                    
                    throw new Exception("El valor ingresado no es un número válido.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message); // Lanza una excepción con el mensaje del error.
            }

            return aux;
        }

        public static bool FinDePrograma()
        {

            bool returnn = false;
            bool error = false;

            do
            {
                Console.WriteLine("¿Desea continuar? ( Y / N )");
                string opcion = Console.ReadLine();

                if (opcion == "y" | opcion == "Y")
                {
                    returnn = true;
                    error = false;
                }
                else if (opcion == "n" | opcion == "N")
                {
                    returnn = false;
                    error = false;
                }
                else
                {
                    Console.WriteLine("Opción no valida");
                    error = true;
                }
            } while (error != false);

            return returnn;
        }
    }
}
