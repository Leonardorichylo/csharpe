using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class HistoricoViewModel : BasaViewModel
    {
        public List<Pedido> Pedidos {get;set;}
    }
}