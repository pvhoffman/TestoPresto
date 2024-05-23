using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "PrestoTesto API", Description = "Testing the things you love", Version = "v1" });
});
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PrestoTesto API V1");
});

app.MapGet("/", () => "Hello World!");

app.Run();
