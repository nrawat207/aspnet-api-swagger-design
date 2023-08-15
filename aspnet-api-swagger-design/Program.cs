using aspnet_api_swagger_design.Middlewares;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(conf =>
{
    conf.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Api documentation",
        Version = "1.0.0",
        Description = "Sample API with Swaggger Specification",
        License = new OpenApiLicense
        {
            Name = "Licence name",
            Url = new Uri("https://licence_Terms_URL.com")
        },
        Contact = new OpenApiContact
        {
            Name = "Narendra Rawat",
            Email = "rawat207@gmail.com",
            Url = new Uri("https://github.com/rawat207")
        }
    });

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetEntryAssembly()?.GetName()?.Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    conf.IncludeXmlComments(xmlPath);
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

app.UseMiddleware<CustomExceptionHandlerMiddleware>();

app.Run();

