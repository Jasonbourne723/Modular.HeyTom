using Shared.Instrastructure.Controllers;
using Module.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUserContext(builder.Configuration);

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
