using System;

namespace salarioaumento
{
    class Program
    {
        static void Main(string[] args)
        {
                double salario;
                double aumento=30.0/100.0;//30%

                Console.WriteLine("Digite o salario: ");
                salario = double.Parse(Console.ReadLine());
                
            if (salario<500)
                {
                    aumento = salario * 0.3;

                    salario += aumento;

                Console.WriteLine("Salario reajustado");
                Console.WriteLine("Seu novo salario é de R$" + salario);
                }
            else 
                {
                Console.WriteLine("Salario não sofreu nenhum reajuste.");
                }

        }

        
    }
}