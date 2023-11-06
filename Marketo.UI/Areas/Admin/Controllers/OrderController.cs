﻿using Marketo.Core.Entities;
using Marketo.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Marketo.UI.Areas.Admin.Controllers;


[Area("Admin")]
public class OrderController : Controller
{
    //[Authorize(Roles = "Admin")]

    private readonly AppDbContext _context;

    public OrderController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        List<Order> orders = await _context.Orders.Include(x => x.OrderItems).Include(x => x.AppUser).ToListAsync();
        return View(orders);
    }

    public async Task<IActionResult> Confirm(int? id)
    {
        if (id == 0 || id == null)
        {
            return View();
        }
        Order orderEx = await _context.Orders.Include(x => x.OrderItems).Include(x => x.AppUser).FirstOrDefaultAsync(x => x.Id == id);

        orderEx.Status = true;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || id == 0) return NotFound();
        Order order = await _context.Orders.FindAsync(id);
        if (order == null) return NotFound();
        _context.Orders.Remove(order);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
