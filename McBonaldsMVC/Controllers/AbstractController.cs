using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "email_Cliente";
        protected const string SESSION_CLIENTE_NOME = "nome_Cliente";
        protected string ObterUsuarioSession()
        {
            var email = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL); //HttpContext.Session == recebe um (chave,conteudo)
            if(!string.IsNullOrEmpty(email))
            {
                return email;
            }
            else{
                return "";
            }
        }
        protected string ObterUsuario_Nome_Session()
        {
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_NOME); //HttpContext.Session == recebe um (chave,conteudo)
            if(!string.IsNullOrEmpty(nome))
            {
                return nome;
            }
            else{
                return "";
            }
        }

        
    }
}