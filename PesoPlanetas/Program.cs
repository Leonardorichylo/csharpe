using System;

namespace PesoPlanetas {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Planetas: ");
            System.Console.WriteLine ("1 - Mercúrio");
            System.Console.WriteLine ("2 - Vênus");
            System.Console.WriteLine ("3 - Marte");
            System.Console.WriteLine ("4 - Júpiter");
            System.Console.WriteLine ("5 = Saturno");
            System.Console.WriteLine ("6 - Urano");

            System.Console.WriteLine ("Digite o numero do planta desejado ou Fim para Sair:");
            string codigo = Console.ReadLine ();
            do{
            switch (codigo) {
                case "1":
                System.Console.Write("Digite seu peso: ");
                double peso = double.Parse(Console.ReadLine());
                peso=peso*0.37/9.8;
                System.Console.WriteLine($"Seu peso em Mercúrio é: {peso}");
                    break;
                case "2":
                System.Console.Write("Digite seu peso: ");
                peso = double.Parse(Console.ReadLine());
                peso=peso*0.88/9.8;
                System.Console.WriteLine($"Seu peso em Vênus é: {peso}");
                    break;
                case "3":
                System.Console.Write("Digite seu peso: ");
                peso = double.Parse(Console.ReadLine());
                peso=peso*0.38/9.8;
                System.Console.WriteLine($"Seu peso em Marte é: {peso}");
                    break;
                case "4":
                System.Console.Write("Digite seu peso: ");
                peso = double.Parse(Console.ReadLine());
                peso=peso*2.64/9.8;
                System.Console.WriteLine($"Seu peso em Júpiter é: {peso}");
                    break;
                case "5":
                System.Console.Write("Digite seu peso: ");
                peso = double.Parse(Console.ReadLine());
                peso=peso*1.15/9.8;
                System.Console.WriteLine($"Seu peso em Saturno é: {peso}");
                    break;
                case "6":
                System.Console.Write("Digite seu peso: ");
                peso = double.Parse(Console.ReadLine());
                peso=peso*1.17/9.8;
                System.Console.WriteLine($"Seu peso em Urano é: {peso}");
                    break;
            }
            System.Console.WriteLine();
            } while(codigo !="Fim");

        }
    }
}