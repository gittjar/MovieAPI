using Microsoft.EntityFrameworkCore;
// Data -folder includes DBContext!
using MovieAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// UseSqlServer
builder.Services.AddDbContext<ElokuvaDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ElokuvaDBContext") ??
    throw new InvalidOperationException("Connection string 'ElokuvaDBContext' not found.")));

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

