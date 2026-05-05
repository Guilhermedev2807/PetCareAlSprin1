using Microsoft.EntityFrameworkCore;
using PetCareAI.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<PetCareAI.Data.AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));
    builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
        app.UseSwaggerUI(options => {
            options.SwaggerEndpoint("/openapi/v1.json", "PetCare AI+ v1");
        });
    }

app.UseHttpsRedirection();

app.MapControllers();

// Adicione esta linha no final para o servidor não fechar sozinho
app.Run(); 

// Você pode apagar o record WeatherForecast (linhas 30 a 33), 
// ele não faz parte do PetCare AI+.