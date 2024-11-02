using AutoTrade.Services;
using AutoTrade.Services.Database;
using Microsoft.EntityFrameworkCore;
using Mapster;
using Microsoft.Extensions.FileProviders;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICantonService, CantonService>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<ICarBrandService, CarBrandService>();
builder.Services.AddTransient<ICarCategoryService, CarCategoryService>();
builder.Services.AddTransient<ICarModelService, CarModelService>();
builder.Services.AddTransient<ICommentService, CommentService>();
builder.Services.AddTransient<IFavoriteService, FavoriteService>();
builder.Services.AddTransient<IFuelTypeService, FuelTypeService>();
builder.Services.AddTransient<IReservationService, ReservationService>();
builder.Services.AddTransient<ITransmissionTypeService, TransmissionTypeService>();
builder.Services.AddTransient<IVehicleConditionService, VehicleConditionService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AutoTradeContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddMapster();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "uploads")),
    RequestPath = "/uploads"
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
