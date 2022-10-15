using Microsoft.EntityFrameworkCore;
using Net6MVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// SQL Connection
builder.Services.AddDbContext<TestDBContext>(
    o => o.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identify Cooike
builder.Services.AddAuthentication(options =>
{
    options.DefaultSignInScheme = "TestNetCoreCookie";
    options.DefaultAuthenticateScheme = "TestNetCoreCookie";
    options.DefaultChallengeScheme = "TestNetCoreCookie";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
