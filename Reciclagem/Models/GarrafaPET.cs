using System;
using Reciclagem.Interface;

namespace Reciclagem.Models

{
    public class GarrafaPET: ILixeiraVermelho
    {
        public bool JogarNoLixoVermelho()
        {
            Console.WriteLine("Garrafa Pet na Lixeira Vermelho");
        return true;
        }
    }
}