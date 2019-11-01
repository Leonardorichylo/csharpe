using System;

namespace Ex22Matriz3x3 {
    class Program {
        static void Main (string[] args) {
            int[, , ] Matriz = new int[3, 3, 3];
            Random Rand = new Random ();
            int final = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    for (int k = 0; k < 3; k++) {
                        int aleatorio = Rand.Next (0, 10);
                        Matriz[i, j, k] = aleatorio;
                        final += aleatorio;
                        Console.Write($" {aleatorio} ");
                    }
                }
            }
            System.Console.WriteLine ($"= {final}");
        }
    }
}