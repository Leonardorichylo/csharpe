using System;

namespace _10__Multiplode3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double numero = Double.Parse(Console.ReadLine());
            if(numero % 3 == 0){
                System.Console.WriteLine("É multiplo de 3");
            }else{
                System.Console.WriteLine("Não é multiplo de 3");
            }
        }
    }
}
