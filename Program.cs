using Application.Interfaces;
using Infrastructure.Data;
using Infrastructure.Services.OCR;
using Microsoft.EntityFrameworkCore;
using Presentation.Components;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IOcrService, TesseractOcrService>();

builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlServer(connectionString));



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
//    dbContext.Database.EnsureCreated();
//}

app.Run();
