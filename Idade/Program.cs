using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade =0;

            Console.WriteLine("Qual a sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"{idade} Anos * {12} Meses = {idade * 12} Meses");
            Console.WriteLine($"{idade} Anos * {365} Dias = {idade * 365} Dias");
            Console.WriteLine($"{idade} Anos * {8760} Horas = {idade * 8760} Horas");
            Console.WriteLine($"{idade} Anos * {525600} Minutos = {idade * 525600} Minutos");
        }
    }
}
