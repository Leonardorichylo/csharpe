using System;

namespace Imparpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1=0;
            int resto;


            Console.WriteLine("Digite um número:");
            N1 = int.Parse(Console.ReadLine());
            
            resto= N1%2;

            if (resto==0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
               Console.WriteLine("O número é impar!");
            }

        }
    }
}
