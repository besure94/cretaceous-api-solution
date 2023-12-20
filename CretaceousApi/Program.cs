using CretaceousApi.Models;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
  options.AddPolicy(name: MyAllowSpecificOrigins,
  policy =>
  {
    policy.WithOrigins("http://localhost:5500");
  });
});

builder.Services.AddControllers();

builder.Services.AddDbContext<CretaceousApiContext>(
  dbContextOptions => dbContextOptions
    .UseMySql(
      builder.Configuration["ConnectionStrings:DefaultConnection"],
      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
      )
    )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
