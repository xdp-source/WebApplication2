var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/h", () => "Hello World!");

app.Run();