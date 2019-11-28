using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        [HttpGet]
        public IActionResult DashBoard()
        {
            var pedidos = pedidoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel= new DashboardViewModel();

            foreach (var pedido in pedidos)
            {
                switch(pedido.Status)
                {
                    case (uint) StatusPedido.REPROVADO:
                    dashboardViewModel.pedidosReprovados++;
                    break;
                    case (uint) StatusPedido.APROVADO:
                    dashboardViewModel.pedidosAprovados++;
                    break;
                    default:
                    dashboardViewModel.pedidosPendentes++;
                    dashboardViewModel.Pedidos.Add(pedido);
                    break;
                }
            }
            dashboardViewModel.NomeView="Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();

            return View(dashboardViewModel);

        }
    }
}