using Microsoft.EntityFrameworkCore;
using PIA_EQJOSEPE.Models;
using Microsoft.EntityFrameworkCore;
using BD_Juegos.Models; // ? Usa SOLO donde esté tu BdJuegosContext

var builder = WebApplication.CreateBuilder(args);

// Servicios MVC
builder.Services.AddControllersWithViews();

// Conexión a SQL Server (usa tu cadena llamada "conexion")
builder.Services.AddDbContext<BdJuegosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));

var app = builder.Build();

// Configuración pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();