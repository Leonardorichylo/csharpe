using System;

namespace Ex21caixaeletro
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            System.Console.WriteLine("=========================");
            System.Console.WriteLine("=== CAIXA ELETRONICO ===");
            System.Console.WriteLine("=========================");
            System.Console.WriteLine("Notas Disponiveis: 2, 5, 10, 20, 50, 100. ");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor a ser sacado: ");
            valor=int.Parse(Console.ReadLine());
            while(valor > 0){

                if(valor >= 100){
                    System.Console.WriteLine("Nota de 100");
                    valor -= 100;
                }else if(valor < 100 && valor >= 50){
                    System.Console.WriteLine("Nota de 50");
                    valor -= 50;
                }else if(valor < 50 && valor >= 20){
                    System.Console.WriteLine("Nota de 20");
                    valor -= 20;
                }else if(valor < 20 && valor >= 10){
                    System.Console.WriteLine("Nota de 10");
                    valor -= 10;
                }else if(valor < 10 && valor >= 5){
                    System.Console.WriteLine("Nota de 5");
                    valor -= 5;
                }else if(valor < 5 && valor >= 2){
                    System.Console.WriteLine("Nota de 2");
                    valor -= 2;
                }else if(valor < 2 && valor >= 1){
                    System.Console.WriteLine("Moeda de 1");
                    valor -= 1;
                }
            }

        }
    }
}
/*21. Criar um programa que simule o uso de um caixa eletronico, onde 
o usuário pode entrar um valor, e o programa calcula o número de notas 
a serem entregues pelo dispositivo. 
O dispositivo deve minimizar o número de notas entregues para o usuário. */