using System;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma;
            do{

            Console.WriteLine("Calcula Area");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triangulo");
            Console.WriteLine("3 - Círculo");
            Console.WriteLine("4 - Trapézio");
            Console.WriteLine("5 - Retângulo");
            Console.WriteLine("6 - Losango");
            Console.WriteLine("Fim para terminar");
            Console.WriteLine("Selecione a forma");
            forma = Console.ReadLine();

        switch(forma) {
            case "1":
            Console.WriteLine("Qual o raio da circunferencia?  ");
            double r = double.Parse(Console.ReadLine());
            double area=3.14 * r * r;
            Console.WriteLine("A area de circunferencia é " + area);
            break;
            
            default:
                    Console.WriteLine("Operação Invalida!");
                    break;
                    }
        }
        while(forma)
        
    }
}
