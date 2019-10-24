using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            float tempo, velocidademedia,distancia,litrosusados;

            System.Console.Write("Digite o Tempo: ");
            tempo = float.Parse(Console.ReadLine());
            System.Console.Write("Digite a Velocidade Media: ");
            velocidademedia = float.Parse(Console.ReadLine());
            System.Console.WriteLine();

            distancia = tempo * velocidademedia;

            litrosusados = distancia /12;

            System.Console.WriteLine($"Tempo Gasto {tempo}.");
            System.Console.WriteLine($"velocidade média {velocidademedia}");
            System.Console.WriteLine($"distância percorrida {distancia}");
            System.Console.WriteLine($"Litros utilizados na viagem {litrosusados}");
            System.Console.WriteLine();
        }
    }
}