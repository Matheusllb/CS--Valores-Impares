using System;
using System.Globalization;

namespace CsE18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 18
            Console.Write("Encontrando valores ímpares\n\nInforme um valor: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
