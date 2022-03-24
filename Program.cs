

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");
app.MapGet("/marketplace/{category?}/{product?}", (int? category, int? product) => $"Hello World {category} {product}!");
app.MapGet("/marketplace2/{category=666}/{product=777}", (int category, int product) => $"Hello World {category} {product}!");
app.MapGet("/blog/{**slug=home}", (string slug) => $"Hello World {slug}!");
app.MapGet("/blog2/{**slug}", (string slug) => $"Hello World {slug}!");
app.Run();

