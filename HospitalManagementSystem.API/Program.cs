
using HospitalManagementSystem.BLL.Mapper;
using HospitalManagementSystem.BLL.Services;
using HospitalManagementSystem.BLL.Services.Interfaces;
using HospitalManagementSystem.DAL.Data;
using HospitalManagementSystem.DAL.Repository;
using HospitalManagementSystem.DAL.Repository.Interfaces;
using HospitalManagementSystem.DAL.UnitOfWork;
using HospitalManagementSystem.DAL.UnitOfWork.Interface;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HospitalManagementSystem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDbContext>(opts =>
            {
                opts.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnectionString"));
            });
            builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            builder.Services.AddScoped(typeof(IGenericService<,>),typeof(GenericService<,>));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(CustomProfile)));
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
        }
    }
}
