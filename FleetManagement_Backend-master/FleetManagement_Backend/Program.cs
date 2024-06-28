
using FleetManagement_Backend.DAL;
using FleetManagement_Backend.DAL.AirportComponent;
using FleetManagement_Backend.DAL.BillingComponent;
using FleetManagement_Backend.DAL.BookingComponent;
using FleetManagement_Backend.DAL.CarCategoryComponent;
using FleetManagement_Backend.DAL.CarComponent;
using FleetManagement_Backend.DAL.CityComponent;
using FleetManagement_Backend.DAL.HubComponent;
using FleetManagement_Backend.DAL.StateComponent;
using FleetManagement_Backend.DAL.UserComponent;
using FleetManagement_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddTransient<IStateInterface, SQLStateRepository>();
            builder.Services.AddTransient<IAirportInterface, SQLAirportRepository>();
            builder.Services.AddTransient<ICityInterface, SQLCityRepository>();
            builder.Services.AddTransient<IHubInterface, SQLHubRepository>();
            builder.Services.AddTransient<ICarInterface, SQLCarRepository>();
            builder.Services.AddTransient<ICarCategoryInterface, SQLCarCategoryRepository>();
            builder.Services.AddTransient<IBookingInterface, SQLBookingRepository>();
            builder.Services.AddTransient<IBillingInterface, SQLBillingRepository>();
            builder.Services.AddTransient<IUsersInterface, SQLUsersRepository>();



            var configure_builder = builder.Configuration.GetConnectionString("PROJECT_DB");

            builder.Services.AddDbContextPool<AppDbContext>((op) => op.UseSqlServer(configure_builder));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyAllowSpecificOrigins",
                                  builder =>
                                  {
                                      builder.WithOrigins("*")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  });
            });

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
            app.UseCors("MyAllowSpecificOrigins");


            app.MapControllers();

            app.Run();
        }
    }
}