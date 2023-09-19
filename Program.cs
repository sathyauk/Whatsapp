using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Whatsapp.Modal;

namespace Whatsapp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<FrmWhatsapp>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IConfiguration Configuration { get; set; }
        static IHostBuilder CreateHostBuilder()
        {   
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            var conn = Configuration.GetConnectionString("DefaultConnection");
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<CustomerContext>(options => options.UseSqlServer(conn));
                    services.AddScoped<FrmWhatsapp>();
                    services.AddScoped<FrmSendImage>();
                    services.AddScoped<FrmSendText>();
                });
        }
    }
}