using System;

namespace Ex2Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os celsius: ");
            double C = Double.Parse(Console.ReadLine());
            double F = (C* 9/5) + 32;
            System.Console.WriteLine($"São: {F} em Fahrenheit.");
        }
    }
}
