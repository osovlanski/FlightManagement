using FlightAlertManagement.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(); 

var app = builder.Build();

app.MapAlertEndpoints();

app.Run();