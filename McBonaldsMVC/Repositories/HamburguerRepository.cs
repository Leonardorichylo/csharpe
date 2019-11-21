using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class HamburguerRepository
    {
        private const string PATH ="Database/Hamburguer.csv";

        public HamburguerRepository()
        {
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
        public double ObterPrecode(string nomeHamburguer)
        {
            var lista = ObterTodos();
            double preco = 0.0;
            foreach(var item in lista){
                if (item.Nome.Equals(nomeHamburguer)){
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Hamburguer> ObterTodos() //retorna lista de hamburgeur
        {
            List<Hamburguer> hamburgueres = new List<Hamburguer>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas)
            {
                Hamburguer h = new Hamburguer();
                string[] dados = linha.Split(";"); // se conecta ao csv e separa com o parametro ponto e virgula
                h.Nome = dados[0];
                h.Preco = double.Parse(dados[1]);
                hamburgueres.Add(h);
            }
            return hamburgueres;
        }
    }
}