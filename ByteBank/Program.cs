using System;


namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("cpf: ");
            string cpf = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente clientes = new Cliente(nome,cpf,email);
            
            do {
                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();
                bool senhaok = cliente1.trocasenha(senha);
                if (!senhaok)
                {
                    Console.WriteLine("Senha não atende aos requisitos");
                } 
                else 
                {
                    Console.WriteLine("senha trocada com sucesso");
                }
            }
            while(!senhaok);
        }
    }
}