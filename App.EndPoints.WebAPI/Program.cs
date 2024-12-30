using App.Domain.AppServices;
using App.Domain.Core.AppServices;
using App.Domain.Core.Data;
using App.Domain.Core.Services;
using App.Domain.Services;
using App.Infra.ExternalServices.CoinMarketCapAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICurrencyInfoAppService, CurrencyInfoAppService>();
builder.Services.AddScoped<ICurrencyInfoService, CurrencyInfoService>();
builder.Services.AddScoped<ICurrencyInfoRepository, CurrencyInfoRepository>();
builder.Services.AddScoped<HttpClient, HttpClient>();
builder.Services.AddScoped<CoinMarketCapAPIConfig, CoinMarketCapAPIConfig>();

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
