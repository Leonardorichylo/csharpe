using System;
using McBonaldsMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.Repositories;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : Controller
    {

        ClienteRepository clienteRepositorio = new ClienteRepository();
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CadastrarCliente(IFormCollection form)
        
        {
            ViewData["Action"] = "Cadastro"; 
            try{
                Cliente cliente = new Cliente(form["nome"], form["email"],form["senha"], form["endereco"], form["telefone"], DateTime.Parse(form["data-nascimento"]));
                
                clienteRepositorio.Inserir(cliente);

            return View("Sucesso");

            }catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
            
        }
    }
} 