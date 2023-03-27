using Microsoft.EntityFrameworkCore;
using TesteAlbertoOpenCore.Context;
using TesteAlbertoOpenCore.Domain.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateClienteHandler).Assembly));

builder.Services.AddTransient<ICreatePedidoHandler, CreatePedidoHandler>();
builder.Services.AddTransient<ICreateProdutoHandler, CreateProdutoHandler>();
builder.Services.AddTransient<IFindPedidoPerClientHandler, FindPedidoPerClientHandler>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "API Teste",
        Description = "API Teste Alberto - Empresa Open",
        Version = "v1"
    });
});

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

//app.UseDeveloperExceptionPage();

app.Run();
