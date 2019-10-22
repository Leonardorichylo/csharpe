using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class GuardaChuva: ILixeiraAmarelo
    {
        public bool JogarNoLixoAmarelo()
        {
            Console.WriteLine("Guarda Chuva na Lixeira Amarelo");
        return true;
        }
    }
}