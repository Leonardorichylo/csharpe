using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class Latinha: ILixeiraAmarelo
    {
        public bool JogarNoLixoAmarelo()
        {
            Console.WriteLine("Latinha na Lixeira Amarelo");
        return true;
    }
}
}