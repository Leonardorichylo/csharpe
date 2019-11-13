
using System.IO;
using ExerciciosMVC.Models;

namespace ExerciciosMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

            public bool Inserir (Cliente cliente)
            {
            
                /* var nome = cliente.Nome;
                var endereco = cliente.Endereco;
                string[] dados = {$"{nome};{endereco}"};*/

                
                var linha = new string[] { PrepararRegistroCSV(cliente) };

                File.AppendAllLines(PATH, linha);
                return true;
            }

            private string PrepararRegistroCSV(Cliente cliente){
                return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
            }
        }
    }