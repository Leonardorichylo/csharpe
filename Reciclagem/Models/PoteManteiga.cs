using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class PoteManteiga: ILixeiraVermelho
    {
        public bool JogarNoLixoVermelho()
        {
            Console.WriteLine("Pote Manteiga na Lixeira Vermelho");
        return true;
    }
    }
}