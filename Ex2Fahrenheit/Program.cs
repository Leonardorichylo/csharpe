using System;

namespace Ex2Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double F;
            System.Console.WriteLine("Conversão de Centígrados para Fahrenheit");
            System.Console.WriteLine("Digite a temperatura Centígrados: ");
            double C = double.Parse(Console.ReadLine());

            F = (C*9)/5+32;

            System.Console.WriteLine($"Temperatura em Fahrenheit: {F}");
            
        }
    }
}
/*2. Criar um programa que leia uma temperatura em graus centígrados e 
apresentá-la convertida em graus Fahrenheit. A fórmula de conversão é:
F=(9*C + 160)/5
Onde: 

F é a temperatura em Fahrenheit.

C é a temperatura em centígrados. */
