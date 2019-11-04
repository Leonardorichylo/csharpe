using System;

namespace Ex1Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a base: ");
            double b = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura: ");
            double a = Double.Parse(Console.ReadLine());
            System.Console.WriteLine();
            double area = b*a;
            double perimetro = 2*(b + a);
            double diagonal = Math.Sqrt(Math.Pow(b,2) + Math.Pow(a,2));
            System.Console.WriteLine("Area: "+area);
            System.Console.WriteLine("Perimetro: "+perimetro);
            System.Console.WriteLine("Diagonal: "+diagonal);
        }
    }
}
