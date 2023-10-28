using Marketo.Buisness.Services;
using Marketo.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<LayoutService>();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=dashboard}/{action=Index}/{id?}"
                );
app.MapControllerRoute
    (
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
 