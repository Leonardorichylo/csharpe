using System;

namespace _13__Lados_de_um_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            double num3 = Double.Parse(Console.ReadLine());

            if(num3 >= 0 && num2 >= 0 && num1 >= 0){
                System.Console.WriteLine("Podem ser lados de um triangulo");
            }else{
                System.Console.WriteLine("Estes não podem ser lados de um triangulo");
            }
        }
    }
}
