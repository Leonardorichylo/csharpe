using System;

namespace Ex4ImparOrPar {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Digite um numero: ");
            double numero = Double.Parse (Console.ReadLine ());

            if (numero % 2 == 0) {
                System.Console.WriteLine ($"{numero} é par");
            } else {
                System.Console.WriteLine ($"{numero}é impar");
            }
        }
    }
}