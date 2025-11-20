using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using template_form_backed.Application.Users;
using template_form_backed.Domain.Users;
using template_form_backed.Infrastructure;
using template_form_backed.Infrastructure.Users;

var builder = WebApplication.CreateBuilder(args);

// EF Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Apllication
builder.Services.AddScoped<IUserService, UserService>();

// Infrastructure
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Allow CORS
var allowCors = "_myCors";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowCors, policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(allowCors);

app.MapControllers();

app.Run();
