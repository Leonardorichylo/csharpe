using System;
using System.Collections.Generic;

namespace _11__Ordem_Alfabetica
{
    class Program
    {
	    static void Main(string[] args) {
        
        List<string> abcdario = new List<string>() {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

        System.Console.WriteLine("Digite um nome: ");
        string nome1 = Console.ReadLine();
        System.Console.WriteLine("Digite outro: ");
        string nome2 = Console.ReadLine();

        string caracter1 = nome1.Substring(0,1);
        string caracter2 = nome2.Substring(0,1);
        int inteiro1 =0;
        int inteiro2 =0;

        for(int i = 0; i < 26; i++){
            if(caracter1 == abcdario[i]){
                inteiro1 = i;
            }
            if(caracter2 == abcdario[i]){
                inteiro2 = i;
            }
        }
        System.Console.WriteLine("O numero 1: "+inteiro1);
        System.Console.WriteLine("O numero 2: "+inteiro2);

        if(inteiro1 > inteiro2){
            System.Console.WriteLine(nome2);
            System.Console.WriteLine(nome1);
            
        }else{
            
            System.Console.WriteLine(nome1);
            System.Console.WriteLine(nome2);
        }

        
	    }

    }
}
