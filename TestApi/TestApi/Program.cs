using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using Azure.Core;
using Azure;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews();
#region repository_injection
//Repository injection
builder.Services.AddScoped(typeof(IRepositoryAsync<>), typeof(BaseRepositoryAsync<>));
builder.Services.AddScoped<ICategoryRepositoryAsync, CategoryRepositoryAsync>();
builder.Services.AddScoped<IProductRepositoryAsync, ProductRepositoryAsync>();
builder.Services.AddScoped<IShipperRepositoryAsync, ShipperRepositoryAsync>();
builder.Services.AddScoped<IPromotionRepositoryAsync, PromotionRepositoryAsync>();
builder.Services.AddScoped<IReviewRepositoryAsync, ReviewRepositoryAsync>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IShipperRegionRepositoryAsync, ShipperRegionRepositoryAsync>();
//builder.Services.AddScoped<ICategoryVariationRepositoryAsync, CategoryVariationRepositoryAsync>();
#endregion

//service injection
builder.Services.AddScoped<ICategoryServiceAsync, CategoryServiceAsync>();
builder.Services.AddScoped<IProductServiceAsync, ProductServiceAsync>();
builder.Services.AddScoped<IShipperServiceAsync, ShipperServiceAsync>();
builder.Services.AddScoped<IPromotionServiceAsync, PromotionServiceAsync>();
builder.Services.AddScoped<IReviewServiceAsync, ReviewServiceAsync>();
builder.Services.AddScoped<IAccountServiceAsync, AccountServiceAsync>();
builder.Services.AddScoped<IShipperRegionServiceAsync, ShipperRegionServiceAsync>();
//builder.Services.AddScoped<typeof(IService<, , ,  >), typeof(BaseService<, , , >)>();
builder.Services.AddScoped(typeof(IService<,,>), typeof(BaseService<,,>));


builder.Services.AddCors(option => {
    option.AddDefaultPolicy(o => {
        o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddAuthentication(option => {
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option => {
    option.SaveToken = true;
    option.RequireHttpsMetadata = false;
    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});

builder.Services.AddDbContext<EcommerceDbContext>(context => {
    context.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDb"));
    //context.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDbSa"));
    //context.UseSqlServer(Environment.GetEnvironmentVariable("ECommerceDb"));
});

builder.Services.AddIdentity<ApplicationUser,IdentityRole>()
    .AddEntityFrameworkStores<EcommerceDbContext>().AddDefaultTokenProviders();


builder.Services.AddAutoMapper(typeof(Program));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();
