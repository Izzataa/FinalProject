using Marketo.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Marketo.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
