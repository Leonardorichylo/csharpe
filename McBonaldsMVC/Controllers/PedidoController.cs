using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository ();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakesRepository shakeRepository = new ShakesRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index () {

            var hamburgueres = hamburguerRepository.ObterTodos();
            var shake = shakeRepository.ObterTodos();

            PedidoViewModel pedido = new PedidoViewModel();
            
            pedido.Hamburgueres = hamburgueres;
            pedido.Shake = shake;

            var usuarioLogado = ObterUsuarioSession();

            var NomeUsuarioLogado = ObterUsuario_Nome_Session();

            if (!string.IsNullOrEmpty(NomeUsuarioLogado)) // se o usuario estiver logado, aparecer o nome dele
            {
                pedido.NomeUsuario = NomeUsuarioLogado;
            }

            var clienterLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienterLogado != null)
            {
                pedido.Cliente = clienterLogado;
            }

            pedido.NomeView = "Pedido";
            pedido.UsuarioEmail = ObterUsuarioSession();
            pedido.UsuarioNome = ObterUsuario_Nome_Session();
            return View (pedido);
        }

        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido ();

            
            var precoShake = shakeRepository.ObterPrecoDe(form["shake"]);
            var nomeShake = form["shake"];
            Shake shake = new Shake (nomeShake,precoShake);

            pedido.Shake = shake;

            Hamburguer hamburguer = new Hamburguer (form["hamburguer"],hamburguerRepository.ObterPrecoDe(form["hamburguer"]));
            var precoHamburger = hamburguerRepository.ObterPrecoDe(form["hamburguer"]);
            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente () {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = precoHamburger + precoShake;

            if (pedidoRepository.Inserir (pedido)) {
                return View ("Sucesso", new RespostaViewModel(){
                    NomeView = "Sucesso",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuario_Nome_Session(),
                    Mensagem = "Aguarde a aprovação dos nossos Administradores"
                });
            } else {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Erro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuario_Nome_Session(),
                    Mensagem = "Houve um erro ao processar seu pedido. Por favor, Tente novamente"
                });
            }
        }
    }
}