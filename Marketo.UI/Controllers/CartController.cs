using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
