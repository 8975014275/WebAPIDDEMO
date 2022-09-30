using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebAPIDDEMO.Entities;
using WebAPIDDEMO.Repositories;
using WebAPIDDEMO.Services;
using Swashbuckle.AspNetCore.Swagger;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:defaultConnction").Value));
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepositoty, CustomerRepository>();

builder.Services.AddCors(options => options.AddDefaultPolicy(
                builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()
            ));





builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SampleWebApi", Version = "v1" });
});




builder.Services.AddControllers();

// Add services to the container.

var app = builder.Build();
app.UseCors();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SampleWebApi v1"));
// Configure the HTTP request pipeline.



app.Run();

// Configure the HTTP request pipeline.







