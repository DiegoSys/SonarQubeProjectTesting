using Microsoft.AspNetCore.Mvc;

namespace TestingGestionProductos.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
