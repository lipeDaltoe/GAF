using GAF.Api.Data;
using GAF.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Serviço de Conexão com Banco de Dados
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySQL(
        builder.Configuration.GetConnectionString("Conexao")
    )
);

// Serviço de Identidade (Identity - Usuários)
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    // Configurações de Senha
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;

    // Configurações de Bloqueio
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options .Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

    // Configurações de Usuário
    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

// Serviço de Configuração do JWT
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"];

builder.Services.AddAuthentication(options =>
{
    
})

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "GAF API V1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
