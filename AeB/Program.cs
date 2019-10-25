using System;

namespace AeB {
    class Program {
        static void Main (string[] args) {
            int a;
            int b;

            System.Console.Write("Digite o valor A: ");
            a = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor B: ");
            b = int.Parse(Console.ReadLine());

            System.Console.WriteLine ($"A = {a}");
            System.Console.WriteLine ($"B = {b}");
            System.Console.WriteLine ();
            int A=a+b;
            int B=b+a;

            A=A-a;
            B=B-b;
            System.Console.WriteLine($"A = {A}");
            System.Console.WriteLine($"B = {B}");
        }
    }
}





/* Faça Um Algoritimo Com as Quatro Instruções Abaixo Seguidas
1) A=A+B====Novo Valor De A=3
2) B=B+A====Novo Valor De B=5
3) A=B- A====Novo Valor De A=2
4) B=B-2*A===Novo Valor De B=1
*/