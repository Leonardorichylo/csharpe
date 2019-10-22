using System;
using Reciclagem.Interface;
using Reciclagem.Models;

namespace Reciclagem
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Selecione item desejado para jogar no lixo: ");
            Console.WriteLine("1 - Garrafa");
            Console.WriteLine("2 - Garrafa PET");
            Console.WriteLine("3 - Guarda Chuva");
            Console.WriteLine("4 - Latinha");
            Console.WriteLine("5 - Papelão");
            Console.WriteLine("6 - Pote Manteiga");
            
            int Codigo = int.Parse(Console.ReadLine());
        }
    }
}

/*
Garrafa
GarrafaPET
GuardaChuva
Latinha
Papelão
PoteManteiga

Lixeira
Plastico - Vermelho
Papeis - Azul
Metais - Amarelo
Vidros - Verde
Organico - Marron
*/
