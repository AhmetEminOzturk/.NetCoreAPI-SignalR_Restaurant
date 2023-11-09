using Autofac.Extensions.DependencyInjection;
using Autofac;
using Restaurant.Core.Application.Services;
using Restaurant.Core.Application.Services.AboutService;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories.AboutRepository;
using Restaurant.Presentation.WebAPI.Modules;
using Restaurant.Core.Application.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RestaurantDbContext>();
builder.Services.AddAutoMapper(typeof(MapProfile));

//AutoFac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

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
