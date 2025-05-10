using Microsoft.EntityFrameworkCore;
using Module.Products.Infrastructure.Persistence;
using Module.Products.Infrastructure.Services;
using Module.Products.Infrastructure.Tools;
using Module.Products.Shared.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//connection to db 
builder.Services.AddDbContext<ProductDbContext>(options=> 
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//AutoMapper
builder.Services.AddAutoMapper(config => config.AddProfile<ProductMappingProfile>());

//Services
builder.Services.AddScoped<IProductService,ProductService>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.MapControllers();

app.Run();
