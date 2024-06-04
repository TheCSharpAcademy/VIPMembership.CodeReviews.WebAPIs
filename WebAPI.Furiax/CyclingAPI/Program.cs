using CyclingAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<CyclingDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();


app.Run();


/*
 * read me:
 * created project
 * installed nuget packages
 * clean up program.cs, removing unneccessary code
 * added code to program.cs to add controllers
 * created context file
 * added connectionstring to appsettings.json
 * registered context to program.cs
 * created model
 * added dbset in context file
 * created the database with add-migration and update-database command
 * just realized distance has to be double, so changed and added new migration and update db
 * 
 */
