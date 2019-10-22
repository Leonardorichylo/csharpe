using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class Papelao: ILixeiraAzul
    {
        public bool JogarNoLixoAzul()
        {
            Console.WriteLine("Papelão na Lixeira Azul");
        return true;
    }
    }
}