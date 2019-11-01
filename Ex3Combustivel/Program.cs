using System;

namespace Ex3Combustivel
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
/*3. Criar um programa que efetue o cálculo da quantidade de litros
de combustível gastos em uma viagem, sabendo-se que o carro 
faz 12 km com um litro. Deverão ser fornecidos o tempo em horas 
gasto na viagem e a velocidade média em kilometros por hora. 
Utilizar as seguintes fórmulas:

* Distância = tempo x velocidade. 
* Litros usados = distância / 12. 
O programa deverá apresentar os valores da velocidade média,
tempo gasto na viagem, distância percorrida e a 
quantidade de litros utilizados na viagem.*/