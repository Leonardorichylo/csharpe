using System;
using mateodragão.Models;

namespace mateodragão
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
        do {

                System.Console.WriteLine("==============================");
                System.Console.WriteLine("       Mate o Dragão");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine();

                switch(opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "João";
                        guerreiro.Sobrenome = "Paulo";
                        guerreiro.CidadeNatal = "Acre";
                        guerreiro.DataNascimento = DateTime.Parse("27/07/1966");
                        guerreiro.FerramentaProtecao = "Escudo de Dragão";
                        guerreiro.FerramentaAtaque = "Espada";
                        guerreiro.Forca = 4;
                        guerreiro.Destreza = 2; 
                        guerreiro.Inteligencia = 2; 
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Dragonildo";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;
                        /*INICIO - Primeiro Diálogo  */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-te-lhe!");

                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: kkkk! Humano tolinho. Quem pensas que es?\n");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        
                        /*FIM - Primeiro Diálogo  */
                        
                        /*INICIO - Segundo Diálogo  */
                        Console.Clear();
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu Sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, o criatura morfética");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja ...fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        /*FIM - Segundo Diálogo */

                        Console.Clear();
                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        bool jogadorNaoMorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza :
                        guerreiro.Destreza;

                        /* INICIO - da TRETA */
                        if (jogadorAtacaPrimeiro) {
                            Console.Clear();
                            
                            System.Console.WriteLine("Turno do Jogador");
                            System.Console.WriteLine("Escolha sua ação");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fujir");


                            string opcaobatalhaJogador = Console.ReadLine();

                            switch(opcaobatalhaJogador){
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0,5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0,5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa lagarto MALDJEETO!");
                                        dragao.Vida -= poderAtaqueGuerreiro +5;
                                        System.Console.WriteLine("----------");
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    } else 
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrrou, humanoide tosco!");
                                    }

                                break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW VLWW!");
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: GG IZI PIZI!");
                                break;
                            }

                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();
                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                                Console.Clear();
                                System.Console.WriteLine("***Turno do Dragão**(");
                                Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0,5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0,5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (dragaoDestrezaTotal > guerreiroDestrezaTotal){
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Chamuscou o fiofo?");
                                        guerreiro.Vida -= dragao.Forca;
                                        System.Console.WriteLine("----------");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                        System.Console.WriteLine($"HP Dragão {dragao.Vida}");
                                    } else 
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vem tranquilo, não se afoba não!");
                                    }
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                                    Console.ReadLine();
                                    
                            /*INICIO - Turno Jogador */
                                    Console.Clear();
                            System.Console.WriteLine("Turno do Jogador");
                            System.Console.WriteLine("Escolha sua ação");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fujir");


                            opcaobatalhaJogador = Console.ReadLine();

                            switch(opcaobatalhaJogador){
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0,5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0,5);

                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa lagarto MALDJEETO!");
                                        dragao.Vida -= poderAtaqueGuerreiro +5;
                                        System.Console.WriteLine("----------");
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    } else 
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrrou, humanoide tosco!");
                                    }
                                    if (guerreiro.Vida<=0)
                                    {
                                        System.Console.WriteLine("Jogador Moorreeeeeeeeeu");
                                    }
                                    if (dragao.Vida<=0) {
                                        System.Console.WriteLine("El dragon murio");
                                    }
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                                    Console.ReadLine();
                                    

                                break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW VLWW!");
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: GG IZI PIZI!");
                                break;
                            }

                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();
                        /*FIm - Turno Jogador */
                        }
                            
                        }
                        /* FIM - da TRETA */

                        break;
                    case "0":
                    jogadorNaoDesistiu = false;
                        break;
                    default:
                    System.Console.WriteLine("Comando desconhecido");
                        break;
                } 
            } 
            while(jogadorNaoDesistiu);

        }
    }
}