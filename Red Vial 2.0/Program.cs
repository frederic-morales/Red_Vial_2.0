using Red_Vial_2._0.Components;
using Microsoft.EntityFrameworkCore;
using Red_Vial_2._0; // Asegúrate que este sea el namespace de AppDbContext

var builder = WebApplication.CreateBuilder(args);

// ✅ Configurar conexión a SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


////PRUEBA NOMÁS
//using (var scope = app.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//    try
//    {
//        db.Database.CanConnect(); // True si está conectada
//        Console.WriteLine("✅ ¡Conexión a la base de datos establecida!");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("❌ Error de conexión: " + ex.Message);
//    }
//}


app.Run();
