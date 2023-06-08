using ctrlspec.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ctrlspec.Repos;
using AutoMapper;
using ctrlspec.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CtrlSpecDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IEquipment,EquipmentRepo>();
builder.Services.AddScoped<IProject_Info,Project_InfoRepository>();
builder.Services.AddScoped<ILogin,LoginRepository>();
builder.Services.AddScoped<ITokenHandler,ctrlspec.Repos.TokenHandler>();
builder.Services.AddScoped<ISpec, SpecRepository>();


builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>

{

    // builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
builder.WithOrigins("http://localhost:5078/", "https://localhost:4200/").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();

}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
