using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
