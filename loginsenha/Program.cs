using System;

namespace loginsenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, senha;

            Console.Write("Digite seu login: ");
            login= (Console.ReadLine());
            Console.Write("Digite sua senha: ");
            senha= (Console.ReadLine());

            if ((login=="admin") && (senha=="admin")) {
                Console.WriteLine("Bem vindo Administrador!");
            }
            else {
                Console.WriteLine("Bem vindo usuario!");
            }
        }
    }
}
