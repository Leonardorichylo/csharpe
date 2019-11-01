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
/*18. Criar uma aplicação que leia um número que será o limite superior de um intervalo e 
imprimir todos os números ímpares menores do que esse número.
Exemplo: 

Limite superior: 15  Impressão: 1,2,5,7,9,11,13 */