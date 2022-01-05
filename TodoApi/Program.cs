using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using TodoApi;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
