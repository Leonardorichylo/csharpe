using System;
using System.Collections.Generic;

namespace _19__DitarEListarArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da sua lista de inteiros");
            int Tamanho = int.Parse(Console.ReadLine());
            List<int> Lista = new List<int>(new int[Tamanho]);
            for(int i = 0; i < Tamanho; i++){
                Console.WriteLine("Digite o valor para o lugar "+i+" :");
                int Valor = int.Parse(Console.ReadLine());
                Lista[i] = Valor;
            }
            System.Console.WriteLine();
            for(int i = 0; i < Tamanho; i++){
                Console.WriteLine("O Valor na posição "+i+" é: "+Lista[i]);
            }
        }
    }
}
