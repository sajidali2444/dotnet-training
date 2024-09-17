using DotnetAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var dbConnection = builder.Configuration.GetConnectionString("demoDB");
//var dbConnection1 = builder.Configuration.GetSection("dbConnection:db");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// builder.Services.AddEntityFrameworkNpgsql()
//     .AddDbContext<AppDBContext>(options => options.UseNpgsql(dbConnection));
builder.Services.AddDbContext<AppDBContext>(options => options.UseNpgsql(dbConnection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

