using System;

namespace Ex19Vetor {
    class Program {
        static void Main (string[] args) {
            System.Console.Write ("Digite a quantidade de inteiros no vetor: ");
            int quantidade = int.Parse (Console.ReadLine ());
            int[] N = new int[quantidade];

            System.Console.WriteLine ();
            for (int cont = 0; cont <= (quantidade - 1); cont++) {
                Console.Write ($"Posição {cont} digite um número: ");
                N[cont] = int.Parse (Console.ReadLine ());
            }
            System.Console.WriteLine();
            foreach (int x in N) {
                Console.WriteLine (x);
            }
        }
    }
}