using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Ingresa un número: ");
                numero = int.Parse(Console.ReadLine());
             
                if (numero > 0)
                {
                    for (int i = 1; i <= numero; i++)
                    {
                        for (int j = 1; j <= numero * 2; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }              
            } while (numero != 0);
        }              
    }
}
