using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sample1.Data;
using Sample1.Mappings;
using Sample1.Repository;
using Sample1.Services.HotelService;
using Sample1.Services.RoomService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyDbContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("MyDB")
));

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IRoomService, RoomService>();


builder.Services.AddScoped<HotelRepository>();
builder.Services.AddScoped<RoomRepository>();


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
