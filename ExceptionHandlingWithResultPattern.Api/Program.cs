using ExceptionHandlingWithResultPattern.Api;
using ExceptionHandlingWithResultPattern.Api.StartupConfigurations;
using ExceptionHandlingWithResultPattern.Framework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegistrationMediator();
//builder.Services.RegisterClients(builder.Configuration);
//builder.Services.AddCors();
builder.Services.AddControllers();

var app = builder.Build();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.MapGet("/healthz", () => { Results.Ok(); });

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseRouting();
app.RegistrationEndpoints();
app.Run();