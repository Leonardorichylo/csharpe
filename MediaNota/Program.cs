using System;

namespace MediaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota = 0,nota1,nota2,nota3,nota4,media;

            Console.Write("Entre a primmeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre a terceira nota:");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Entre a quarta nota:");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1+nota2+nota3+nota4)/4;
            nota = media;

            Console.WriteLine("Sua media é " +media);

            if (media>=7) {

                Console.WriteLine("APROVADO");
                }
            
            else {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
