using Microsoft.EntityFrameworkCore;
using Module.Orders.Infrastructure.Persistence;
using Module.Orders.Infrastructure.Services;
using Module.Orders.Infrastructure.Tools;
using Module.Orders.Shared.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//connection to db 
builder.Services.AddDbContext<OrderDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//AutoMapper
builder.Services.AddAutoMapper(config => config.AddProfile<OrderMappingProfile>());

//Services
builder.Services.AddScoped<IOrderService, OrderService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//execute migrations
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<OrderDbContext>();
    dbContext.Database.Migrate();
}


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
