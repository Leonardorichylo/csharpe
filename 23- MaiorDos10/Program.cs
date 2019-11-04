using System;
using System.Collections.Generic;
namespace _23__MaiorDos10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>(new int[10]);
            int maior = 0;
            Random Rand = new Random();
            for(int i = 0; i < 10; i++){
                int aleatorio = Rand.Next(1,1000);
                Lista[i] = aleatorio;
                if (aleatorio > maior){
                    maior = aleatorio;
                }
            }
            System.Console.WriteLine(maior);
        }
    }
}
