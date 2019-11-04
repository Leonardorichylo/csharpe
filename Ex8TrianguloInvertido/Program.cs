using System;

namespace Ex8TrianguloInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a altura do triangulo: ");
            double Altura = Double.Parse(Console.ReadLine());
            for(int j = 0; j < Altura; j++){

                for(int i = 0; i < Altura-j; i++){
                    System.Console.Write("*");

                }
                System.Console.WriteLine();
            }

        }
    }
}
