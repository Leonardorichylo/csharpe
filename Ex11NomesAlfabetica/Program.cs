using System;

namespace Ex11NomesAlfabetica

{

    class Program {
        static void Main (string[] args) {
            //iniciando vetor
            string[] nomes = new string[2];
            //usuario digita o nome na indice
            for (int cont = 0; cont <= 1; cont++) {
                Console.Write ("Digite um nome: ");
                nomes[cont] = Console.ReadLine ();
            }
            //Ordem alfabetica
            Array.Sort (nomes);
            foreach (string x in nomes) {
                Console.WriteLine (x);
            }
        }
    }
}
/*11. Criar uma aplicação que entre com dois nomes 
e imprimi-los em ordem alfabética. */