using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            string frase;
            string[] fraseArray;
            char[] delimitadores = { ';', ',', '|', ' ', '.', '-', '_' };

            Console.WriteLine("Operaciones con Arrays y Manejo de Strings - Ejercicio 2 - Leo Rios - 2º DAM");
            Console.WriteLine(Environment.NewLine);
            do
            {   
                //1. Introducir Frase.
                frase = FraseValida();

                //2. Convertir la frase en un array
                    //StringSplitOptions.RemoveEmptyEntries ignora si hay delimitadores consecutivos
                fraseArray = frase.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine($"Número de palabras: {fraseArray.Length}");

                //3. Mostrar número de palabras y la frase en orden inverso
                    //Reverse() regresa un IEnumerable<T>. Yo hago un .ToArray() solo por mantener el formato string[]
                string[] fraseInvertida = fraseArray.Reverse().ToArray();

                string fraseYaInvertida = string.Empty;

                foreach (string palabra in fraseInvertida)
                {
                    fraseYaInvertida += palabra + " ";
                }
                Console.WriteLine($"Palabras en orden inverso: {fraseYaInvertida}");
                
                //4. Remplazo de palabra por REDACTADO segun el usuario
                int numeroRedactador = numeroValido(fraseArray.Length);

                    //Se muestra el total de palabras y resto -1 porque el array comienza de 0
                fraseArray[numeroRedactador-1] = "REDACTADO";

                string fraseYaRedactada = string.Empty;

                foreach (string palabra in fraseArray)
                {
                    fraseYaRedactada += palabra + " ";
                }

                Console.WriteLine($"Resultado: {fraseYaRedactada}");

                //Fin del progrma ?
                end = FinDePrograma();
            } while (!end);
        }

        //Función para válidar la frase
        public static string FraseValida()
        {
            bool valido = false;
            string frase = string.Empty;
            do {
                try {
                    Console.Write("Introduce una frase: ");
                    string fraseAux = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(fraseAux))
                    {
                        throw new Exception("Erro: Entrada vacia.");
                    }
                    else if (fraseAux.Length > 50)
                    {
                        throw new Exception("Error: Entrada superior a 50 caracteres");
                    }
                    else 
                    {
                        frase = fraseAux;
                        valido = true;
                    }
                } 
                catch (Exception e) {
                    Console.WriteLine(e.Message);                
                }

            }while (!valido);

            return frase;
        }

        //Función para válidar el número de la palabra a redactar
        public static int numeroValido(int fraseLenght) {

            int numero = -1;
            bool valido = false;

            do {
                try 
                {
                    Console.Write("Introduce el número de la palabra a remplazar: ");
                    string numeroRedactador = Console.ReadLine();
                    if (!int.TryParse(numeroRedactador, out numero))
                    {
                        throw new Exception("Error: Número no válido");
                    }
                    else if(numero > fraseLenght)
                    {
                        throw new Exception("Error: Número no corresponde a una posición válida");
                    }
                    else {
                        valido = true;
                    }
                } 
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            } while (!valido);

            return numero;
        }

        //Fin del programa ? Salir : Seguir provando 
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
