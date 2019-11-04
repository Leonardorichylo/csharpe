using System;
using System.Collections.Generic;
namespace _20__RandomicoImpoPa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            List<int> Lista = new List<int>(new int[10]);
            
            for(int i = 0; i < 10; i++){
                int Numero = Rand.Next(0,1000);
                
                Lista[i] = Numero;
            }
            //PARES
            System.Console.WriteLine("Pares: ");
            for(int i = 0; i < 10; i ++){
                if(Lista[i] % 2 == 0){
                    System.Console.WriteLine(Lista[i]);
                }
            }
            System.Console.WriteLine();
            //IMPARES
            System.Console.WriteLine("Impares: ");
            for(int i = 0; i < 10; i ++){
                if(Lista[i] % 2 != 0){
                    System.Console.WriteLine(Lista[i]);
                }
            }
            
        }
    }
}
