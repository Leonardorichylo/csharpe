using System;

namespace _14__Verbos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um verbo no infinitivo: ");
            string verbo = Console.ReadLine();
            string ultimaletra = verbo.Substring(verbo.Length-1, 1);
            string ultimasduas = verbo.Substring(verbo.Length-2, 2);
            if(ultimaletra == "r"){
                string radical = verbo.Replace(ultimasduas,"");
                System.Console.WriteLine("Primeira conjulgação: Eu "+radical+"o");
                System.Console.WriteLine("Segunda conjulgação: Eu "+radical+"a");
                System.Console.WriteLine("Terceira conjulgação: "+radical+"e");
            }else{
                System.Console.WriteLine("Não é um verbo no infinitivo");
            }
        }
    }
}
