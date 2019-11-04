using System;

namespace _9__Gravidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            double peso = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Seu peso em Mercurio seria: "+ peso*0.37);
            System.Console.WriteLine("Seu peso em Venus seria: "+ peso*0.88);
            System.Console.WriteLine("Seu peso em Marte seria: "+ peso*0.38);
            System.Console.WriteLine("Seu peso em Jupiter seria: "+ peso*2.64);
            System.Console.WriteLine("Seu peso em Saturno seria: "+ peso*1.15);
            System.Console.WriteLine("Seu peso em Urano seria: "+ peso*1.17);
        }
    }
}
