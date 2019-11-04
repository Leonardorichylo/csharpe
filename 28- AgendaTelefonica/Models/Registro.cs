using System;
namespace _28__AgendaTelefonica.Models{
    class Registro
        {
            private string Nome {get;set;}
            private string Telefone {get;set;}
            private string Aniversario {get;set;}

            public Registro(string nome, string telefone, string aniversario){
                this.Nome = nome;
                this.Telefone = telefone;
                this.Aniversario = aniversario;
            }
        }
}
    