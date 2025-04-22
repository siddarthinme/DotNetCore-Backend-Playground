var builder = WebApplication.CreateBuilder(args);

// Register OpenAPI and controller support
builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Redirect HTTP to HTTPS
app.UseHttpsRedirection();

// Map controllers (like WeatherForecastController)
app.MapControllers();

app.Run();



