using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
