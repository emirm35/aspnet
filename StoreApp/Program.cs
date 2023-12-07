var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseHttpsRedirection();
app.UseRouting();

app.MapGet("/", () => "Hello World!");

app.Run();
