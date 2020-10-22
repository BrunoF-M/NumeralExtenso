using System;
using Figgle;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine("+-=-=Numeral por Extenso=-=-+");
            Console.ResetColor();
            Console.WriteLine();

            int numero;

            Console.Write("Digite um número..: ");
            numero = int.Parse(Console.ReadLine());

            string numeral1 = numero.ToWords();

            Console.WriteLine();
            
            Console.WriteLine($"{numeral1}");

            Console.WriteLine();
            Console.Write("enter to finish...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}