using System;

namespace Ex13verificartriangulo {
    class Program {
        static void Main (string[] args) {
            int a, b, c;

            System.Console.WriteLine ("Digite o 1ºNumero: ");
            a = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o 2ºNumero: ");
            b = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o 3ºNumero: ");
            c = int.Parse (Console.ReadLine ());

            if ((a < (b + c)) && (b < (a + c)) && (c < (a + b))) {
                Console.WriteLine ("Estes valores formam um triangulo");
            } else {
                System.Console.WriteLine ("os lados não fazem um triângulo.");
            }
        }
    }
}
/*13. Criar uma aplicação que peça para o usuário três números e 
verificar se eles podem ou não ser lados de um triângulo. 
Imprimir a classificação segundo os lados ou uma mesagem dizendo 
que os lados não fazem parte de um triângulo. 
Para ser um triângulo válido, o comprimento de um lado do 
triângulo é sempre menor do que a soma dos outros dois. */