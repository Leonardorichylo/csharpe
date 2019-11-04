using System;

namespace _15__Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero entre 1 e 12");
            int escolha = int.Parse(Console.ReadLine());
            if(escolha > 0 && escolha <= 12 ){
                if(escolha == 1){
                    System.Console.WriteLine("Janeiro");
                }else if(escolha == 2){
                    System.Console.WriteLine("Fevereiro");
                }else if(escolha == 3){
                    System.Console.WriteLine("Março");
                }else if(escolha == 4){
                    System.Console.WriteLine("Abril");
                }else if(escolha == 5){
                    System.Console.WriteLine("Maio");
                }else if(escolha == 6){
                    System.Console.WriteLine("Junho");
                }else if(escolha == 7){
                    System.Console.WriteLine("Julho");
                }else if(escolha == 8){
                    System.Console.WriteLine("Agosto");
                }else if(escolha == 9){
                    System.Console.WriteLine("Setembro");
                }else if(escolha == 10){
                    System.Console.WriteLine("Outubro");
                }else if(escolha == 11){
                    System.Console.WriteLine("Novembro");
                }else if(escolha == 12){
                    System.Console.WriteLine("Dezembro");
                }

            }
        }
    }
}
