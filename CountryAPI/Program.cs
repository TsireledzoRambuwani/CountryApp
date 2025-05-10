using CountryAPI.Repositories;
using CountryAPI.Repositories.Interface;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<ICountryRespoitory, CountryRespoitory>();

builder.Services.AddHttpClient("CountryApi", httpClient =>
{
   
   var uri = builder.Configuration.GetValue<string>("API:CountryApi");

    httpClient.BaseAddress = new Uri(uri);
    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc(
        "v1",
        new OpenApiInfo { Title = "Country API", Version = "1.0.0" });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(o =>
o.WithOrigins("http://localhost:4200")
.AllowAnyMethod()
.AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
