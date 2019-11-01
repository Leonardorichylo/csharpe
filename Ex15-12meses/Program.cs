using System;

namespace _12meses {
    class Program {
        static void Main (string[] args) {
            string mes;
            System.Console.Write ("Digite do um número de 1 ate 12: ");
            mes = Console.ReadLine ();
            switch (mes) {
                case "1":
                    System.Console.Write ("Mês Janeiro");
                    break;
                case "2":
                    System.Console.Write ("Mês Fevereiro");
                    break;
                case "3":
                    System.Console.Write ("Mês Março");
                    break;
                case "4":
                    System.Console.Write ("Mês Abril");
                    break;
                case "5":
                    System.Console.Write ("Mês Maio");
                    break;
                case "6":
                    System.Console.Write ("Mês Junho");
                    break;
                case "7":
                    System.Console.Write ("Mês Julho");
                    break;
                case "8":
                    System.Console.Write ("Mês Agosto");
                    break;
                case "9":
                    System.Console.Write ("Mês Setembro");
                    break;
                case "10":
                    System.Console.Write ("Mês Outubro");
                    break;
                case "11":
                    System.Console.Write ("Mês Novembro");
                    break;
                case "12":
                    System.Console.Write ("Mês Dezembro");
                    break;
                default:
                    System.Console.WriteLine ("Não existe mês com este número.");
                    break;
            }
        }
    }
}
/*15. Crie um programa que peça para o usuário um número inteiro entre 1 e 12 e escrever o mês correspondente. 
Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando que não existe mês com este número.  */