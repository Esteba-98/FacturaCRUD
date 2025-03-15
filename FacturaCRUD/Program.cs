using FacturaCRUD.Services;
using Microsoft.EntityFrameworkCore;
using FacturaCRUD.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GestionFacturasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion")));

// Registrar la capa de servicios
builder.Services.AddScoped<FacturaService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Facturas}/{action=Index}/{id?}");

app.Run();
