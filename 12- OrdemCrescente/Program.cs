using System;

namespace _12__OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero 1: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2: ");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 3: ");
            double num3 = Double.Parse(Console.ReadLine());

            double maior = 0;
            double meio = 0;
            double menor = 0;

            if(num1 > num3 && num1 > num2){  //numero1 maior
                maior = num1;
                if (num2>num3){
                    meio = num2;
                    menor = num3;
                }else{
                    menor = num2;
                    meio = num3;
                }
            }else if(num2 > num1 && num2 > num3){ //numero 2 maior
                maior = num2;
                if(num1 > num3){
                    meio = num1;
                    menor = num3;
                }else{
                    meio = num3;
                    menor = num1;
                }
            } else if(num3 > num1 && num3 > num2){ //numero 3 maior
                maior = num3;
                if(num1 > num2){
                    meio = num1;
                    menor = num2;
                }else{
                    meio = num2;
                    menor = num1;
                }
            } 



            System.Console.WriteLine("O maior é: "+maior);
            System.Console.WriteLine("O do meio é: "+meio);
            System.Console.WriteLine("O menor é: "+menor);
        }
    }
}
