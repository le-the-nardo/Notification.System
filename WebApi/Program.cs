using Application;
using Application.Interfaces;
using Application.Interfaces.UseCases;
using Application.UseCases;
using Infrastructure;
using Presentation;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var configurationSettings = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISendMessageUseCase, SendMessageUseCase>();

builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddPresentation();

/*builder.Services.AddDbContext<SqliteDbContext>(options =>
    options.UseSqlite(configurationSettings.GetConnectionString("SQLiteConnection")));*/

builder.Host.UseSerilog((context, configuration) => 
    configuration.ReadFrom.Configuration(context.Configuration));




var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
