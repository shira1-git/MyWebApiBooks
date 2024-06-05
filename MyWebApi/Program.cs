using Microsoft.EntityFrameworkCore;
using MyWebApi;
using NLog.Web;
using PresidentsApp.Middlewares;
using Repositories;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IRatingRepository, RatingRepository>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<ShopDb325338135Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("School")));
//builder.Services.AddDbContext<ShopDb325338135Context>(options => options.UseSqlServer("Data Source=srv2\\PUPILS;Initial Catalog=Shop_db_325338135;Trusted_Connection=True;TrustServerCertificate=True"));
<<<<<<< HEAD
=======
// Add services to the container.
>>>>>>> 288bcff (add configuration)
builder.Host.UseNLog();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

<<<<<<< HEAD

app.UseErrorHandlingMiddleware();

=======
>>>>>>> 288bcff (add configuration)
app.UseHttpsRedirection();

app.UseAuthorization();

<<<<<<< HEAD
=======
app.UseErrorHandlingMiddleware();
 
>>>>>>> 288bcff (add configuration)
app.UseRoutingMiddleware();

app.MapControllers();

app.UseStaticFiles();

app.Run();
