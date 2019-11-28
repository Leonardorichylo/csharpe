using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class DashboardViewModel :BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;}
        public uint pedidosAprovados {get;set;}
        public uint pedidosReprovados {get;set;}
        public uint pedidosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Pedidos = new List<Pedido>();
        }
    }
}