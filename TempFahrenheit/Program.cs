using System;

namespace TempFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit;
            System.Console.WriteLine("Conversão de Centígrados para Fahrenheit");
            System.Console.WriteLine("Digite a temperatura Centígrados: ");
            double C = double.Parse(Console.ReadLine());

            Fahrenheit = (C*9)/5+32;

            System.Console.WriteLine($"Temperatura em Fahrenheit: {Fahrenheit}");
            
        }
    }
}
