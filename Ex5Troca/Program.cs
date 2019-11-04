using System;

namespace Ex5Troca
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero A: ");
            double A = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o numero B: ");
            double B = Double.Parse(Console.ReadLine());
            double C = A;
            A = B;
            B = C;
            System.Console.WriteLine("Agora o numero A é: "+ A);
            System.Console.WriteLine("Agora o numero B é: "+B);

        }
    }
}
