using Microsoft.AspNetCore.Identity;

namespace Marketo.Core.Entities;

public class AppUser:IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool? Admin { get; set; }
    public List<BasketItem> BasketItems { get; set; }
    public List<Order> Orders { get; set; }
}
