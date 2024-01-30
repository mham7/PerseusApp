using Contouring_App.Application.Services;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Repos
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<ITraineeRepo, TraineeRepo>();
builder.Services.AddScoped<IDivisionRepo, DivisionRepo>();
builder.Services.AddScoped<ITraineeRepo, TraineeRepo>();
builder.Services.AddScoped<IManagerRepo, ManagerRepo>();
builder.Services.AddScoped<IDevRepo, DevRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
// Unit of Work
builder.Services.AddScoped<IUnitofWork, UnitofWork>();
//Services
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IDevService, DevService>();
builder.Services.AddScoped<IManagerService, ManagerService>();
builder.Services.AddScoped<ITraineeService, TraineeService>();
builder.Services.AddScoped<IDivisionService, DivisionService>();
builder.Services.AddScoped<IDivisionService, DivisionService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "https://localhost:44370/", // Replace with your issuer
        ValidAudience = "https://localhost:44370/", // Replace with your audience
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_base64_encoded_secret_keysdfagasgasgasgasgasgagasgasgsagsa")) // Replace with your key
    };
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme { 
        In=ParameterLocation.Header,
        Name="Authorization",
        Type=SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();

}

);
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JWTAuthDemo v1"));
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
