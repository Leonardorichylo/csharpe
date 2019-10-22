using System;
using Reciclagem.Interface;


namespace Reciclagem.Models
{
    public class Garrafa: ILixeiraVerde
    {
        public bool JogarNoLixoVerde()
        {
            Console.WriteLine("Garrafa na Lixeira Verde");
        return true;
        }
    }
}