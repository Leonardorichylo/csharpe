using System;
using System.Collections.Generic;
using _28__AgendaTelefonica.Models;

namespace _28__AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Registro> registros = new List<Registro>();
            Console.WriteLine("Digite o nome do usuario");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do usuario");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite o aniversario do usuario");
            string aniversario = Console.ReadLine();
            Registro cliente1 = new Registro(nome,telefone,aniversario);
            registros.Add(cliente1);
            System.Console.WriteLine(registros[0].nome);

            
        }
    }
}
