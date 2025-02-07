using AutoTrade.Services;
using AutoTrade.Services.Database;
using Microsoft.EntityFrameworkCore;
using Mapster;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Authentication;
using AutoTrade;
using Microsoft.OpenApi.Models;
using Helpers;
using Messages;
using EasyNetQ;
using Database;
using System.Text.Json.Serialization;


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



builder.Services.AddScoped<EmailService>();  // EmailService
builder.Services.AddScoped<RabbitMqListener>();   // RabbitMqListener
builder.Services.AddTransient<ReservationApprovalEmail>();

builder.Services.AddSingleton<IBus>(provider =>
    RabbitHutch.CreateBus("host=localhost"));

// Dio koji rjesava kad ima poveznica u tabelama za dupliranje objekata IgnoreCycles
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

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
builder.Services.AddTransient<IEquipmentService, EquipmentService>();

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


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AutoTradeContext>();

        dbContext.Database.Migrate();

    if (!dbContext.AutomobileAdEquipments.Any())
    {
        dbContext.AutomobileAdEquipments.AddRange(DefaultAdditionalEquipmentData.AutomobileAdEquipment);
        dbContext.SaveChanges();
    }
}


// RabitMQ scope
// using (var scope = app.Services.CreateScope())
// {
//     var listener = scope.ServiceProvider.GetRequiredService<RabbitMqListener>();
//     listener.StartListening();  // Start listening for RabbitMQ messages
// }



app.Run();
