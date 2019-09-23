using System;

namespace IdadeFE
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade=0;
            int FaixaEtaria;
            int AnoAtual=2019;

            Console.WriteLine("Em que ano você nasceu com 4 digitos:");
            Idade= int.Parse(Console.ReadLine());

            FaixaEtaria= AnoAtual-Idade;
            
            if (FaixaEtaria>65) {
                Console.WriteLine("Idoso"); 
            }
            else if ((FaixaEtaria >=20) && (FaixaEtaria<=65)){
                Console.WriteLine("Adulto");
            }
            else if ((FaixaEtaria >=12) && (FaixaEtaria<=19)){
                Console.WriteLine("adolescente");
            }
            else if ((FaixaEtaria >=3) && (FaixaEtaria<=11)){
                Console.WriteLine("criança");
            }
            else if ((FaixaEtaria >=0) && (FaixaEtaria<=2)){
                Console.WriteLine("recém-nascido");
            }
        }
    }
}
