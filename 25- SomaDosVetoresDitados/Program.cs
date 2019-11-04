using System;
using System.Collections.Generic;
using System.Linq;
namespace _25__SomaDosVetoresDitados
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio;
            System.Console.WriteLine("Digite o tamanho da lista A: ");
            int A = int.Parse(Console.ReadLine());
            List<int> ALista = new List<int>(new int[A]);
            System.Console.WriteLine("Digite o tamanho da lista B: ");
            int B = int.Parse(Console.ReadLine());
            List<int> BLista = new List<int>(new int[B]);
            List<int> CLista = new List<int>(new int[A+B]);

            Random Rand = new Random();
            for(int i = 0; i < A; i++){
                aleatorio = Rand.Next(0,1000);
                ALista[i] = aleatorio;
            }
            for(int i = 0; i < B; i++){
                aleatorio = Rand.Next(0,1000);
                BLista[i] = aleatorio;
            }
            CLista = ALista.Concat(BLista).ToList();

            System.Console.WriteLine();
            System.Console.WriteLine("Lista A: ");
            for(int i = 0; i < A; i++){
                System.Console.WriteLine(ALista[i]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Lista B: ");
            for(int i = 0; i < B; i++){
                System.Console.WriteLine(BLista[i]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Listas somadas: ");
            for(int i = 0; i < A+B; i++){
                System.Console.WriteLine(CLista[i]);
            }
        }
    }
}
