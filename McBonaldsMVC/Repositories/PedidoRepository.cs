using System;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using McBonaldsMVC.Models;
namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository: RepositoryBase
    {
        private const string PATH = "Database/Pedidos.csv";
        public PedidoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public bool Inserir(Pedido pedido)
        {
            var linha = new string[] { PrepararRegistroCSV(pedido) };
            File.AppendAllLines(PATH, linha);
            return  false;
        }
        public List<Pedido> ObterTodos()
        {
            var linhas =File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();
            foreach(var linha in linhas)
            {
                Pedido pedido = new Pedido();
                pedido.Cliente.Nome=ExtrairValorDoCampo("cliente_nome",linha);
                pedido.Cliente.Endereco=ExtrairValorDoCampo("cliente_endereco",linha);
                pedido.Cliente.Telefone=ExtrairValorDoCampo("cliente_telefone",linha);
                pedido.Cliente.Email=ExtrairValorDoCampo("cliente_email",linha);
                pedido.Hamburguer.Nome=ExtrairValorDoCampo("hamburguer_nome",linha);
                pedido.Hamburguer.Preco= double.Parse(ExtrairValorDoCampo("hamburguer_preco",linha));
                pedido.Shake.Nome=ExtrairValorDoCampo("shake_preco",linha);
                pedido.Shake.Preco=double.Parse(ExtrairValorDoCampo("shake_preco",linha));
                pedido.DatadoPedido=DateTime.Parse(ExtrairValorDoCampo("dta_pedido",linha));
                pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total",linha));
                
            }
            return pedidos;
        }
        public List<Pedido> ObeterTodosPorCliente(string email)
        {
            var pedidosTotais = ObterTodos();
            List<Pedido> PedidosCliente = new List<Pedido>();
            foreach(var pedido in pedidosTotais)
            {
                if(pedido.Cliente.Email.Equals(email))
                {
                    PedidosCliente.Add(pedido);
                }
            }
            return PedidosCliente;
        }
        
        private string PrepararRegistroCSV(Pedido pedido)
        {
            Cliente cliente = pedido.Cliente;
            Hamburguer hamburguer = pedido.Hamburguer;
            Shake shake = pedido.Shake;
            return $"cliente_nome={cliente.Nome};cliente_endereco={cliente.Endereco};cliente_telefone={cliente.Telefone};cliente_email={cliente.Email}:hamburguer_nome{hamburguer.Nome};hamburguer_preco={hamburguer.Preco};shake_nome={shake.Nome};shake_preco{shake.Preco};dta_pedido={pedido.DatadoPedido};preco_total={pedido.PrecoTotal}";
            
            
        }
    }
}