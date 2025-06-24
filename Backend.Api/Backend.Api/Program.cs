using Backend.Api;
using Backend.Application.Services;
using Backend.Core.Interfaces;
using Backend.Infrastructure;
using Backend.Infrastructure.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IAgencyValidationService, AgencyValidationService>();
builder.Services.AddScoped<IAgencyApiClient, AgencyApiClient>();
builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
    logging.AddDebug();
});
// Add to the existing Program.cs
builder.Services.Configure<AgencyApiSettings>(builder.Configuration.GetSection("AgencyApiSettings"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAppDI();

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
