var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Servir archivos estáticos desde la carpeta wwwroot
app.UseStaticFiles();

// Ruta para la vista de login
app.MapGet("/login", async context =>
{
    await context.Response.SendFileAsync("login/index.html");
});

app.Run();