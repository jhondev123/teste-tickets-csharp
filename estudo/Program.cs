using estudo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using estudo.Views.Employees;
using estudo.Controllers;
using System;
using estudo.Repositories;

namespace estudo
{
    public class Program
    {
        private static IServiceProvider serviceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();
            string connectionString = builder.GetConnectionString("DefaultConnection");


            ServiceCollection service = new ServiceCollection();
            service.AddDbContext<EstudoContext>(options => options.UseNpgsql(connectionString));
            ConfigureServices(service);
            serviceProvider = service.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            var form = serviceProvider.GetRequiredService<SearchEmployeesView>();
            Application.Run(form);
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<EmployeeRepository>();
            services.AddScoped<EmployeeController>();
            services.AddTransient<SearchEmployeesView>();

        }
    }
}