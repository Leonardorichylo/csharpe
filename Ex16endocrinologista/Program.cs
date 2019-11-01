using System;

namespace Ex16endocrinologista {
    class Program {
        static void Main (string[] args) {
            string paciente;
            double peso;
            double altura;
            double IMC;
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
/*16. Um endocrinologista deseja controlar a saúde de seus pacientes e, para isso, se utiliza do Índice de Massa Corporal (IMC). 
Sabendo-se que o IMC é calculado através da seguinte fórmula:

IMC = peso / altura<sup>2</sup>

Onde: 
- Peso é dado em Kg 
- Altura é dada em metros 

Criar um programa que apresente o nome do paciente e sua faixa de risco, baseando-se na seguinte tabela:

| IMC                   | FAIXA DE RISCO    |
|-----------------------|-------------------|
| abaixo de 20          | abaixo do peso    | 
| a partir de 20 até 25 | normal            |
| acima de 25 até 30    | excesso de peso   | 
| acima de 30 até 35    | obesidade         |
| acime de 35           | obesidade mórbida | */