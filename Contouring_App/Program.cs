using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.Repositories;
using Contouring_App.Persistance.UnitOfWork;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Repos
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<ITraineeRepo, TraineeRepo>();    
builder.Services.AddScoped<IDivisionRepo,DivisionRepo>();
builder.Services.AddScoped<ITraineeRepo, TraineeRepo>();
builder.Services.AddScoped<IManagerRepo, ManagerRepo>();
builder.Services.AddScoped<IDevRepo, DevRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
// Unit of Work
builder.Services.AddScoped<IUnitofWork, UnitofWork>();
//Services
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IDevService,DevService>();
builder.Services.AddScoped<IManagerService, ManagerService>();
builder.Services.AddScoped<ITraineeService,TraineeService>();
builder.Services.AddScoped<IDivisionService, DivisionService>();
builder.Services.AddScoped<IDivisionService, DivisionService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();

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
