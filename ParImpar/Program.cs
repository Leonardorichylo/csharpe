using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i=0;
            int cont=0;

            do {
                for (i=0;cont<100;i++) {
                    num=100;
                if (num>0) {
                    Console.WriteLine(i);
                    cont+=1;
                }


                }
                Console.WriteLine("Diga um número ou 0 para sair: ");
                num = int.Parse(Console.ReadLine());
                    if (num !=0) { 
                    if (num % 2 ==0) {
                        Console.WriteLine("O numero é par.");
                    }
                    else  {
                        Console.WriteLine("O número é impar.");
                    }
                    }
            
            }
            
            while (num !=0);
            
        }
    }
}
