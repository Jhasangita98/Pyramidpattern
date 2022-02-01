// See https://aka.ms/new-console-template for more information
using System;
namespace Diamondpattern
{
    public class Program
    {
        private static void Main()
        {
            int i, j, n;

            Console.Write("\n\n");
            Console.Write("display the pattern like diamond:\n");
            Console.Write("-------------------------------");
            Console.Write("\n\n");
            Console.Write("Input number of rows (half of the diamond) :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}

            

            