using System;

namespace Ex1Retangulo {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine("----------Retangulo----------");
            System.Console.Write ("Digite a Base: ");
            int B = int.Parse (Console.ReadLine ());
            System.Console.Write ("Digite a Altura: ");
            int A = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ();

            int Perimetro = (A + B )*2;
            System.Console.WriteLine ($"Perímetro do Retângulo: {Perimetro}");

            int Area = B * A;
            System.Console.WriteLine ($"Area do Retângulo: {Area}");

            double Diagonal = Math.Sqrt(Math.Pow(B,2) + Math.Pow(A,2));
            System.Console.WriteLine ($"Diagonal do Retângulo: {Diagonal}");

            Console.WriteLine ();

        }
    }
}
/*1. Criar uma aplicação que permita ao usuário entrar com a 
base e a altura de um retângulo e imprimir a seguinte saída:
* Perímetro
* Área 
* Diagonal */