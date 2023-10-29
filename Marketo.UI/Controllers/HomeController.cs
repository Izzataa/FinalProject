using Marketo.Core.Entities;
using Marketo.DataAccess.Contexts;
using Marketo.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List <Slider> sliders= _context.Sliders.ToList();
        List<Category> categories = _context.Categories.ToList();
        List<Furniture>furnitures= _context.Furnitures.ToList();

        HomeVM vm = new HomeVM
        {
            Sliders = sliders,
            Categories = categories,
            Furnitures=furnitures,
        };
        return View(vm);
    }
}
