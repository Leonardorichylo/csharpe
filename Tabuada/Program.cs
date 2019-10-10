using System;

namespace Tabuada {
    class Program {
        static void Main (string[] args) {
            for (int i = 0; i <= 10; i++) {
                for (int j = 1; j <= 10; j++) {
                    Console.Write ($"{j,-2} * {i,-2} = {j*i,-3}  ");
                }

                Console.WriteLine ();

            }

        }
    }
}