using BookStoreApi1.Services;
using BookStoreApi1.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<BookStore1DatabaseSettings>(
    builder.Configuration.GetSection("BookStore1Database"));

builder.Services.AddSingleton<BooksService>();
builder.Services.AddControllers()
  .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
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
