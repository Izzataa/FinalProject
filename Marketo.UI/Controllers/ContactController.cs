using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
