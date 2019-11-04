using System;
using System.Collections.Generic;
namespace _27__Agenda_de_Aniversarios
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<string> Nomes = new List<string>();
            List<string> Datas = new List<string>();
            string opcao = "0";
            do {
                Console.WriteLine("Digite 1 para cadastrar um usuario");
                System.Console.WriteLine("Digite 2 para apagar um usuario");
                System.Console.WriteLine("Digite 3 para procurar um usuario");
                System.Console.WriteLine("Digite 4 para mostrar todos os usuarios");
                System.Console.WriteLine("Digite 5 para sair");
                opcao = Console.ReadLine();
                switch(opcao){
                    case "1":
                        System.Console.WriteLine("Digite o nome do usuario: ");
                        string nome = Console.ReadLine();
                        Nomes.Add(nome);
                        System.Console.WriteLine("Digite sua data de aniversario: ");
                        string data = Console.ReadLine();
                        Datas.Add(data);
                        System.Console.WriteLine("Cadastrado com sucesso");
                        break;


                    case "2":
                        System.Console.WriteLine("Digite o nome do usuario a ser apagado: ");
                        string apagado = Console.ReadLine();
                        int escolhido = -5;
                        for(int i = 0; i < Nomes.Count; i++){
                            if(apagado == Nomes[i]){
                                escolhido = i;

                            }
                        }
                        if(escolhido != -5){
                            Nomes.RemoveAt(escolhido);
                            Datas.RemoveAt(escolhido);
                        }
                        break;


                    case "3":
                        System.Console.WriteLine("Digite o nome do usuario a ser encontrado: ");
                        string encontrar = Console.ReadLine();
                        int numeroencontrar = -5;
                        for(int i = 0; i < Nomes.Count; i++){
                            if(encontrar == Nomes[i]){
                                numeroencontrar = i;
                                
                            }
                        }
                        if(numeroencontrar != -5){
                            System.Console.WriteLine();
                            System.Console.WriteLine("Usuario encontrado: ");
                            System.Console.WriteLine("Nome: "+encontrar);
                            System.Console.WriteLine("Data de aniversario: "+Datas[numeroencontrar]);
                            System.Console.WriteLine();
                        }
                        break;
                    

                    case "4":
                        System.Console.WriteLine();
                        System.Console.WriteLine("Lista de todos os usuarios: ");
                        for(int i = 0; i < Nomes.Count; i++){
                            System.Console.WriteLine(Nomes[i]);
                        }
                        break;

                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }while(opcao !="5");

        }
    }
}
