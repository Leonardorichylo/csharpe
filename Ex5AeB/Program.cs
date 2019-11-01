using System;

namespace Ex5AeB {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine("Digite o numero A: ");
            double A = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o numero B: ");
            double B = Double.Parse(Console.ReadLine());
            double C = A;
            A = B;
            B = C;
            System.Console.WriteLine($"Agora o numero A é: {A}");
            System.Console.WriteLine($"Agora o numero B é: {B}");
        }
    }
}
/*5. Criar uma aplicação que leia dois valores para as variáveis A e B,
efetuar a troca dos valores de forma que a variável A passe a ter o 
valor da variável B e a variável B passe a ter o valor da variável A. 
Apresentar os valores trocados.

Faça Um Algoritimo Com as Quatro Instruções Abaixo Seguidas
1) A=A+B====Novo Valor De A=3
2) B=B+A====Novo Valor De B=5
3) A=B- A====Novo Valor De A=2
4) B=B-2*A===Novo Valor De B=1
*/