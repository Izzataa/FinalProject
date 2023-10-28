using Marketo.Core.Entities;
using Marketo.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Marketo.Buisness.Services;

public class LayoutService
{
    private readonly AppDbContext _context;

    public LayoutService(AppDbContext context)
    {
        _context = context;
    }
    public List<Setting> getSettings()
    {
        List<Setting> settings = _context.Settings.ToList();
        return settings;
    }
    public List<Furniture> GetFurnitures()
    {
        List<Furniture> furniture = _context.Furnitures.ToList();
        return furniture;
    }

}
