using ITFCodeWA.API.Binders;
using ITFCodeWA.API.Infrastructure;
using ITFCodeWA.Domain.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(config =>
{
    config.ModelBinderProviders.Insert(0, new FilterInfoModelBinderProvider());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.EnableAnnotations();
    setupAction.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ITFCodeWA.Api",
        Version = "v1",
        Description = $"AssemblyVersion = {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}",
    });
});

builder.Services.AddCors(options => options.AddPolicy(name: "LifeAppOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        policy.WithOrigins("http://localhost:44393").AllowAnyHeader().AllowAnyMethod();
        policy.WithOrigins("https://localhost:5001").AllowAnyHeader().AllowAnyMethod();
        policy.WithOrigins("http://localhost:5001").AllowAnyHeader().AllowAnyMethod();
    }));

builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<LifeDataContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("LifeDataContextConnection")))
                ;

builder.Services.RegisterDependencies();

var app = builder.Build();

app.InitializeProjectData();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("LifeAppOrigins");

app.Map("/test-test", () => "Index Page");

app.MapControllers();

app.Run();
