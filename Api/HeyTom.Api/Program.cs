using Shared.Instrastructure.Controllers;
using Module.User;
using System.Reflection;
using System.Runtime.Loader;
using HeyTom.Web.Core;
using Module.User.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUserContext(builder.Configuration)
    .AddInject(AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName("Module.User.Application")), AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName("Module.User.Infrastructure")));

builder.Services.AddControllers()
           .ConfigureApplicationPartManager(manager =>
           {
               manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
           });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
