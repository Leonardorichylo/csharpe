﻿using System;

namespace Ex12numerocrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numero = new int [3];
            for (int cont = 0; cont <= 2; cont++) {
                Console.Write ("Digite o Numero: ");
                numero[cont] = int.Parse(Console.ReadLine ());

            }

            Array.Sort (numero);

            foreach (int x in numero)

            {

                Console.WriteLine (x);

            }
        }
    }
}
/*12. Criar uma aplicação que entre com três números e 
imprimi-los em ordem crescente (suponha números diferentes). */
