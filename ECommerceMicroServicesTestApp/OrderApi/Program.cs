using Microsoft.EntityFrameworkCore;
using Order.ApplicationCore.RepositoryContract;
using Order.ApplicationCore.ServiceContract;
using Order.Infrastructure.Data;
using Order.Infrastructure.Repository;
using Order.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IService<,,>), typeof(BaseService<,,>));
builder.Services.AddScoped(typeof(IRepositoryAsync<>), typeof(BaseRepositoryAsync<>));

builder.Services.AddScoped(typeof(HttpClient), typeof(HttpClient));

builder.Services.AddDbContext<EcommerceDbContext>(context => {
    //context.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDb"));
    //context.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDbDocker"));
    context.UseSqlServer(Environment.GetEnvironmentVariable("ECommerceDb"));
});

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
