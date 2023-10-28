using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
