using System;

namespace _21__CaixaDeSaque
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor a ser sacado");
            int Valor = int.Parse(Console.ReadLine());
            while(Valor > 0){
                if(Valor >= 100){
                    System.Console.WriteLine("Nota de 100");
                    Valor -= 100;
                }else if(Valor < 100 && Valor >= 50){
                    System.Console.WriteLine("Nota de 50");
                    Valor -= 50;
                }else if(Valor < 50 && Valor >= 20){
                    System.Console.WriteLine("Nota de 20");
                    Valor -= 20;
                }else if(Valor < 20 && Valor >= 10){
                    System.Console.WriteLine("Nota de 10");
                    Valor -= 10;
                }else if(Valor < 10 && Valor >= 5){
                    System.Console.WriteLine("Nota de 5");
                    Valor -= 5;
                }else if(Valor < 5 && Valor >= 2){
                    System.Console.WriteLine("Nota de 2");
                    Valor -= 2;
                }else if(Valor < 2 && Valor >= 1){
                    System.Console.WriteLine("Moeda de 1");
                    Valor -= 1;
                }
            }

        }
    }
}
