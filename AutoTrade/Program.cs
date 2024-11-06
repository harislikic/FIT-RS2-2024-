using AutoTrade.Services;
using AutoTrade.Services.Database;
using Microsoft.EntityFrameworkCore;
using Mapster;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Authentication;
using AutoTrade;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()  // Allows any origin to access the resources
              .AllowAnyHeader()  // Allows any headers
              .AllowAnyMethod(); // Allows any HTTP methods (GET, POST, etc.)
    });
});

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
builder.Services.AddTransient<IAutomobileAdService, AutomobileAdService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {
        new OpenApiSecurityScheme{
            Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme, Id = "basicAuth"}
        },
        new string[]{}
   }});
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AutoTradeContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddMapster();

builder.Services.AddAuthentication("BasicAuthentication")
.AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

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

//cors
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
