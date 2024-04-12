using InjectionApi.Extensions;
using InjectionApi.Services;

var builder = WebApplication.CreateBuilder(args);
builder.AddServAndRepo();
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();
