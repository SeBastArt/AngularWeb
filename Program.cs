using System;
using System.Linq;
using AngularWeb.Data;
using AngularWeb.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace AngularWeb
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //zuerst der Logger, damit das StartUp geloggt werden kann

            //PowerShell Command:
            //docker run --rm -it -e ACCEPT_EULA=Y -p 5341:80 datalust/seq
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.Seq(
                    Environment.GetEnvironmentVariable("SEQ_URL") ?? "http://localhost:5341")
                .CreateLogger();

            //top-level try/catch
            try
            {
                Log.Information("Starting up");
                CreateHostBuilder(args)
                    .Build()
                    .MigrateDatabase()
                    .Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
