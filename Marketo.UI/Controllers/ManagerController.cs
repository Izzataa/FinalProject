using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
