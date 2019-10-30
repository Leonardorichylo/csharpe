using System;

namespace ComunidadeTeste

{

    class Program

    {

        static void Main (string[] args)

        {
            //iniciando vetor
            string[] nomes = new string[2];

            //usuario digita o nome na indice
            for (int cont = 0; cont <= 1; cont++) {
                Console.Write ("Digite um nome: ");
                nomes[cont] = Console.ReadLine ();

            }

            Array.Sort (nomes);

            foreach (string x in nomes)

            {

                Console.WriteLine (x);

            }

        }

    }
}