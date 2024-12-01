using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int? number = null;
			do {
				Console.WriteLine("Introduzca un número para calcular su factorial: (Utiliza '0' para salir...)");
				try
				{
					number = Convert.ToInt32(Console.ReadLine());
					if (number == 0)
					{
						continue;

					} else if (number < 0) {
						Console.WriteLine("Tiene que ser un numero mayor que 0");
					}
					else {
						long? factorial = 1;
						string outString = number.ToString() + "! = ";
						for (int? i = number; i >= 1; i--)
						{
							factorial *= i;
						};

						for (int? i = number; i > 0; i--)
						{
							outString += i.ToString() + " x ";
						};
						Console.WriteLine(outString + " = " + factorial);		
					};
				}
				catch (ArithmeticException e)
				{
					Console.WriteLine("ArithmeticException Handler: " + e.ToString() + " = ");
				}
				catch (Exception er)
				{
					Console.WriteLine("Error : "+er.Message+ " Tiene que ser una número.");
				};
			} while (number != 0);

			Console.WriteLine("Fin del programa");
			Console.ReadKey();
		}
	}
}
