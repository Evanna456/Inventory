using Inventory.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyMiddleware>();
builder.Services.AddControllers();
var app = builder.Build();

app.UseWhen(context => context.Request.Path.StartsWithSegments("/"), appBuilder =>
{
    appBuilder.UseMiddleware<MyMiddleware>();
});

app.MapControllers();
app.Run();
