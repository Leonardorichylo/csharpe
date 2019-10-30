using System;

namespace verificartriangulo {
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