var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "api/{controller=Home}/{action=Get}/{id?}");

app.Run();


