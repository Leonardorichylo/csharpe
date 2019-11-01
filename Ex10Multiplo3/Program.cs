using System;

namespace Ex10Multiplo3 {
    class Program {
        static void Main (string[] args) {
            int numero;

            System.Console.WriteLine ("Digite um número: ");
            numero = int.Parse (Console.ReadLine ());

            if (numero % 3 == 0) {
                System.Console.WriteLine ($"{numero} é multiplo de 3.");
            } else {
                System.Console.WriteLine ($"{numero} não é multiplo de 3.");
            }
        }
    }
}
/*10. Crie um programa que peça para o usuário 
entrar com um número e imprimir uma das mensagens: 
é multiplo de 3 ou não é multiplo de 3. */