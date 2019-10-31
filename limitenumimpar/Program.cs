using System;

namespace limitenumimpar {
    class Program {
        static void Main (string[] args) {
            int num;
            System.Console.WriteLine ("Digite um numero: ");
            num = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ();
            for (int x = 1; x <= num; x+=2) {
                System.Console.WriteLine ($"{x}");
            }
        }
    }
}