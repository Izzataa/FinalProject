using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
