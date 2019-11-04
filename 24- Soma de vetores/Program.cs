using System;
using System.Collections.Generic;
namespace _24__Soma_de_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio;
            List<int> ALista = new List<int>(new int[10]);
            List<int> BLista = new List<int>(new int[10]);
            List<int> CLista = new List<int>(new int[10]);

            Random Rand = new Random();
            for(int i = 0; i < 10; i++){
                aleatorio = Rand.Next(0,1000);
                ALista[i] = aleatorio;
                aleatorio = Rand.Next(0,1000);
                BLista[i] = aleatorio;
                CLista[i] = ALista[i] + BLista[i];
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Lista A: ");
            for(int i = 0; i < 10; i++){
                System.Console.WriteLine(ALista[i]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Lista B: ");
            for(int i = 0; i < 10; i++){
                System.Console.WriteLine(BLista[i]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Listas somadas: ");
            for(int i = 0; i < 10; i++){
                System.Console.WriteLine(CLista[i]);
            }
        }
    }
}
