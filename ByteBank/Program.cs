using System;
namespace ByteBank {
    class Program {
        static void Main (string[] args) {

            System.Console.WriteLine ("===============================");
            Console.WriteLine ("     Cadastro de Clientes");
            System.Console.WriteLine ("===============================");
            Console.WriteLine ();
            Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            Console.Write ("cpf: ");
            string cpf = Console.ReadLine ();
            Console.Write ("Email: ");
            string email = Console.ReadLine ();
            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool senhaok = false;
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

            System.Console.WriteLine ();
            System.Console.WriteLine ("===============================");
            Console.WriteLine ("  Cadastro de Conta Corrente");
            System.Console.WriteLine ("===============================");
            Console.WriteLine ();
            Console.Write ("Agencia: ");
            int agencia = int.Parse (Console.ReadLine ());
            Console.Write ("Conta: ");
            int conta = int.Parse (Console.ReadLine ());
            //Console.Write ("Titular: ");
            //string titular = Console.ReadLine ();

            bool saldoValido = false;
            double saldo;
            do {
                Console.Write ("Digite o Saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldoValido = true;
                } else {
                    Console.WriteLine ("O saldo não pode ser negativo");
                }

            } while (!saldoValido);

            System.Console.WriteLine("________________________________");

            ContaCorrente contacorrente = new ContaCorrente (agencia, conta, cliente1);
            contacorrente.Saldo = saldo;

            Console.WriteLine("ByteBank - Deposito");
            Cliente usuario = contacorrente.titular;
            Console.WriteLine($"Bem vindo - {usuario.nome}");
            Console.WriteLine($"Agencia: {contacorrente.agencia}     conta: {contacorrente.numero}");
            Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            
            saldo = contacorrente.Deposito(valor);
            
            Console.WriteLine("________________________________");
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine("Qual o valor do Saque");
            valor = double.Parse(Console.ReadLine());
            if(contacorrente.Saque(valor)){
                Console.WriteLine("Saque realizado com sucesso, retire as notas");

            }
            System.Console.WriteLine("________________________________");

            Console.WriteLine("BytenBank - Transferencias");
            Console.Write("Digite o valor da transferencia: ");
            valor = double.Parse(Console.ReadLine());
            Cliente cliente2 = new Cliente("Alexandre","123.123.123-54","abc.com");
            ContaCorrente contacorrente2 = new ContaCorrente(224,45773925,cliente2);

            if (contacorrente.Transferencia(contacorrente2,valor)){
                Console.WriteLine("Transferencia efetuada com sucesso.");
            } else {
                Console.WriteLine("Operação não pode ser realizado.");
            }
        }
    }
}