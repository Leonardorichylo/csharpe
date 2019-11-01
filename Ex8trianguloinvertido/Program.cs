using System;

namespace Ex8trianguloinvertido {
    class Program {
        static void Main (string[] args) {

            Console.Write ("Digite a Altura da piramide: ");
            int altura = int.Parse (Console.ReadLine ());
            int largura = altura;

            for (int i = 0; i < altura; i++) {
                for (int x = 0; x < largura; x++) {
                    System.Console.Write ("*");

                }

                System.Console.WriteLine ();
                largura--;
            }
        }
    }
}
/*8. Criar uma aplicação console que peça ao usuário a altura de um 
triangulo, desenhe na tela o triangulo invertido, como abaixo:
Altura do Triangulo: 4

****
***
**
*
 */