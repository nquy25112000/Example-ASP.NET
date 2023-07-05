using AutoMapper;
using HelloMiddleware;
using Microsoft.EntityFrameworkCore;
using Sample1.Data;
using Sample1.Mappings;
using Sample1.Repository;
using Sample1.Services.HotelService;
using Sample1.Services.RoleService;
using Sample1.Services.RoomService;
using Sample1.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
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
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<HotelRepository>();
builder.Services.AddScoped<RoomRepository>();
builder.Services.AddScoped<RoleRepository>();
builder.Services.AddScoped<UserRepositry>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.HelloMiddleware();

app.MapControllers();

app.Run();
