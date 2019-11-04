using System;

namespace _18___ImparesAteLimite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o limite: ");
            double limite = Double.Parse(Console.ReadLine());
            for(int i = 0; i < limite; i++){
                if(i % 2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
