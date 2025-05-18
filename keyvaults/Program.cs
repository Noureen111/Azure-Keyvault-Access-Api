using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var keyVaultUri = builder.Configuration["KeyVault:VaultUri"];                               //Get keyvaults secrets uri
var secretClient = new SecretClient(new Uri(keyVaultUri), new DefaultAzureCredential());    //Create client to access secrets
builder.Services.AddSingleton(secretClient);                                                //Create dependency injection
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
