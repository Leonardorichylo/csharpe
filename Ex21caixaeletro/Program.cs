using System;

namespace Ex21caixaeletro
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            System.Console.WriteLine("=========================");
            System.Console.WriteLine("=== CAIXA ELETRONICO ===");
            System.Console.WriteLine("=========================");
            System.Console.WriteLine("Notas Disponiveis: 2, 5, 10, 20, 50, 100.");
            System.Console.Write("Digite o valor a sacar: ");
            valor=int.Parse(Console.ReadLine());

        }
    }
}
/*21. Criar um programa que simule o uso de um caixa eletronico, onde 
o usuário pode entrar um valor, e o programa calcula o número de notas 
a serem entregues pelo dispositivo. 
O dispositivo deve minimizar o número de notas entregues para o usuário. */