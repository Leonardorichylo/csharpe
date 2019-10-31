using System;

namespace Ex20Vetor10Int {
    class Program {
        static void Main (string[] args) {
            int[] Vetor = new int[10];
            int valor = 0;
            Random NumRandom = new Random ();

            for (int i = 0; i < 10; i++) {
                valor = NumRandom.Next ();
                Vetor[i] = valor;
                Console.Write($"{valor} ");
            }System.Console.WriteLine();
            
            System.Console.WriteLine();
            for (int i = 0; i < 10; i++) {
                if (Vetor[i] % 2 == 0)
                    System.Console.WriteLine($"Os numeros pares são: {Vetor[i]}");
            }System.Console.WriteLine();
            for (int i = 0; i < 10; i++) {
                if (Vetor[i] % 2 != 0)
                    System.Console.WriteLine($"Os numeros impares são: {Vetor[i]}");
            }System.Console.WriteLine();
        }
    }
}
/*Criar um programa que inicialize uma vetor de 10 
inteiros com números aleatórios gerados com o método 
ranndom e imprima duas listas, uma com os números 
pares outra com numeros impares. */