using Marketo.Core.Entities;
using Marketo.DataAccess.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Marketo.UI.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ContactController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Contact", "This is erorr mesaj");
                return View();
            }

            Contact message = new Contact
            {
                Name = contact.Name,
                Email = contact.Email,
                Subject = contact.Subject,
                Description = contact.Description,
                Here = false
            };
            await _context.Contacts.AddAsync(message);
            await _context.SaveChangesAsync();
            TempData["name"] = "The message was sent successfully";
            return RedirectToAction(nameof(Index));

        }
    }

}
