using System;

namespace endocrinologista {
    class Program {
        static void Main (string[] args) {
            /* 
            | IMC                   | FAIXA DE RISCO    |
            |-----------------------|-------------------|
            | abaixo de 20          | abaixo do peso    | 
            | a partir de 20 até 25 | normal            |
            | acima de 25 até 30    | excesso de peso   | 
            | acima de 30 até 35    | obesidade         |
            | acime de 35           | obesidade mórbida |
            */
            string paciente;
            double peso;
            double altura;
            double IMC=0;
            System.Console.Write ("Digite o nome do paciente: ");
            paciente = Console.ReadLine ();
            System.Console.Write ("Digite o Peso: ");
            peso = double.Parse (Console.ReadLine ());
            System.Console.Write ("Digite a Altura: ");
            altura = double.Parse (Console.ReadLine ());
            IMC = peso / (altura *altura);
            System.Console.WriteLine();
            if (IMC <= 0.0020) {
                System.Console.WriteLine ($"{paciente} esta abaixo do peso.");
            } else if ((IMC > 0.0020) && (IMC <= 0.0025)) {
                System.Console.WriteLine ($"{paciente} esta normal.");
            } else if ((IMC > 0.0025) && (IMC <= 0.0030)) {
                System.Console.WriteLine ($"{paciente} esta em excesso de peso.");
            } else if ((IMC > 0.0030) && (IMC <= 0.0035)) {
                System.Console.WriteLine ($"{paciente} esta obeso.");
            } else if (IMC > 0.0035) {
                System.Console.WriteLine ($"{paciente} esta com obesidade mórbida.");
            }
        }
    }
}