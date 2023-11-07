using Marketo.Core.Entities;
using Marketo.DataAccess.Contexts;
using Marketo.UI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Marketo.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChatController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ChatController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index(string id)
        {
            if (id == null) return NotFound();
            AppUser appUser = _context.Users.FirstOrDefault(x => x.UserName == id);
             
            List<AppUser> users = _context.Users.Where(u => u.UserName != id).ToList();
            List<Message> messages = _context.Messages.ToList();
            ChatVM chatVM = new ChatVM
            {
                AppUsers = users,
                Messages = messages
            };
            return View(chatVM);
        }
        public IActionResult ChatUser(string Userid)
        {
            if (Userid == null) return NotFound();
            AppUser appUser = _context.Users.FirstOrDefault(x => x.Id == Userid);
            ViewBag.User = appUser;
            
            List<AppUser> users = _context.Users.Where(u => u.UserName != User.Identity.Name).ToList();
            List<Message> messages = _context.Messages.Include(m=>m.AppUser).ToList();
            ChatVM chatVM = new ChatVM
            {
                AppUsers = users,
                Messages = messages
            };
            return View(chatVM);
        }
    }
}