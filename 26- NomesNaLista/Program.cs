using System;
using System.Collections.Generic;

namespace _26__NomesNaLista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Lista = new List<string>();
            string opcao = "n";
            int quantidade = 0;
            do{

                System.Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                Lista.Add(nome);
                quantidade++;
                System.Console.WriteLine("Para adicionar um nome digite s, para sair digite n");
                opcao = Console.ReadLine();
            }while(opcao != "n");
            System.Console.WriteLine("Você adicionou: "+quantidade++);
        }
    }
}
