using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController:Controller
    {
        PedidoRepository pedidoReposytory = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();

        ShakeRepository shakeRepository = new ShakeRepository();
        public IActionResult Index()
        {
                var hamburgueres = hamburguerRepository.ObterTodos();
                var shake = shakeRepository.ObterTodos();
                PedidoViewModel pedido = new PedidoViewModel();
                pedido.Hamburgueres = hamburgueres;
                pedido.Shake = shake;
                return View(pedido);
        }
        public IActionResult Registrar(IFormCollection form)
        {
        
            Pedido pedido = new Pedido();
            Shake shake = new Shake();
            var nomeShake =  form["shake"];
            shake.Nome = nomeShake;
            shake.Preco = shakeRepository.ObterPrecode(nomeShake);
            pedido.Shake = shake;

            var nomeHamburguer = form["hambuguer"];
            Hamburguer hamburguer = new Hamburguer(form["hamburguer"],hamburguerRepository.ObterPrecode(form["hamburguer"]));
            pedido.Hamburguer = hamburguer;
            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form [""],
                Telefone = form["telefone"],
                Email = form["email"]
            };
            pedido.Cliente = cliente;
            pedido.DatadoPedido = DateTime.Now;
            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;
            pedidoReposytory.Inserir(pedido);
            return View("Sucesso");
        }
    }
}