using System;

namespace _16__IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua altura: ");
            double altura = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite seu peso: ");
            double peso = Double.Parse(Console.ReadLine());
            double IMC = Math.Pow(peso,2)/altura;
            System.Console.WriteLine("Seu IMC É: "+IMC);
            if(IMC < 20){
                System.Console.WriteLine("Abaixo do Peso");
            }else if(IMC >= 20 && IMC <= 25){
                System.Console.WriteLine("Normal");
            }else if(IMC >= 25 && IMC <= 30){
                System.Console.WriteLine("Excesso de peso");
            }else if(IMC >= 30 && IMC <= 35){
                System.Console.WriteLine("Obesidade");
            }else if(IMC > 35){
                System.Console.WriteLine("Obesidade mórbida");
            }
        }
    }
}
