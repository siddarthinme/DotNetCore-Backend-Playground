using MinimalHostDemo.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseRequestTiming();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
