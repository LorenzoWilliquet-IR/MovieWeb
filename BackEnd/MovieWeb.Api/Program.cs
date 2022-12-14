using Microsoft.EntityFrameworkCore;
using MovieWeb.Api.Profiles;
using MovieWeb.Application.Common;
using MovieWeb.Application.Common.Actors;
using MovieWeb.Application.Common.Interfaces;
using MovieWeb.Application.Services;
using MovieWeb.Infrastructure.Persistence;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IMovieService, MovieService>();

builder.Services.AddAutoMapper(typeof(MovieProfile));

builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IActorService, ActorService>();
builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddAutoMapper(typeof(ActorProfile));
builder.Services.AddAutoMapper(typeof(MovieProfile));

builder.Services.AddExtensions();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbInitializer = scope.ServiceProvider.GetRequiredService<MovieDbContext>();
    DbInitializer.Initialize(dbInitializer);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieWeb v1"));
}

app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
