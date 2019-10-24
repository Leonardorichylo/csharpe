using System;

namespace Retangulo {
    class Program {
        static void Main (string[] args) {
            System.Console.Write ("Digite a Base do Retangulo: ");
            int B = int.Parse (Console.ReadLine ());
            System.Console.Write ("Digite a Altura do Retangulo: ");
            int A = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ();

            int Perimetro = A + B * 2;
            System.Console.WriteLine ($"Perímetro do Retângulo: {Perimetro}");

            int Area = B * A / 2;
            System.Console.WriteLine ($"Area do Retângulo: {Area}");

            int Ad = A * 2;
            int Bd = B * 2;
            double Diagonal = Convert.ToSingle(Math.Sqrt((A*A)+(B*B)));
            System.Console.WriteLine ($"Diagonal do Retângulo: {Diagonal}");

            Console.WriteLine ();

        }
    }
}