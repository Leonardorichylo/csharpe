using Microsoft.AspNetCore.Mvc;
namespace ExerciciosMVC.Controllers

{
    public class ClienteController : Controller
    {
        public IActionResult Login(){
            return View();
        }
    }
}