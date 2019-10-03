using System;
namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            bool senhaok = false;
            double saldo;
            System.Console.WriteLine("===============================");
            Console.WriteLine ("     Cadastro de Clientes");
            System.Console.WriteLine("===============================");
            Console.WriteLine ();
            Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            Console.Write ("cpf: ");
            string cpf = Console.ReadLine ();
            Console.Write ("Email: ");
            string email = Console.ReadLine ();
            Cliente cliente1 = new Cliente (nome, cpf, email);
            do {
                Console.Write ("Digite a senha: ");
                String senha = Console.ReadLine ();
                senhaok = cliente1.TrocaSenha (senha);
                if (!senhaok) {
                    Console.WriteLine ("Senha não atende aos requisitos");
                } else {
                    Console.WriteLine ("Senha trocada com sucesso!");
                }
            }
            while (!senhaok);
            System.Console.WriteLine();
            System.Console.WriteLine("===============================");
            Console.WriteLine ("  Cadastro de Conta Corrente");
            System.Console.WriteLine("===============================");
            Console.WriteLine ();
            Console.Write ("Agencia: ");
            int agencia = int.Parse (Console.ReadLine ());
            Console.Write ("Conta: ");
            int conta = int.Parse (Console.ReadLine ());
            Console.Write ("Titular: ");
            string titular = Console.ReadLine ();

            bool saldoValido = false;

            do {
                Console.Write ("Digite o Saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldoValido = true;
                } else {
                    Console.WriteLine ("O saldo não pode ser negativo");
                }

            } while (!saldoValido);

            ContaCorrente contacorrente = new ContaCorrente (agencia,conta,titular);
            contacorrente.Saldo = saldo;
        }
    }
}