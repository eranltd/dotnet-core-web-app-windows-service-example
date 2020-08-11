using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;

namespace CPAPIWatchService
{
    #region snippet_Program
    public class Program
    {
        public static void Main(string[] args)
        {
            var isService = !(Debugger.IsAttached || args.Contains("--console"));
            
            if (isService)
            {
                var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                var pathToContentRoot = Path.GetDirectoryName(pathToExe);
                Directory.SetCurrentDirectory(pathToContentRoot);
            }

            var builder = CreateWebHostBuilder(
                args.Where(arg => arg != "--console").ToArray());


            var host = builder.UseUrls("http://+:5050").Build();

            if (isService)
            {
                // To run the app without the CustomWebHostService change the
                // next line to host.RunAsService();
                host.RunAsCustomService();
                //host.RunAsService();
            }
            else
            {
                host.Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)

                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddEventLog();
                    // Requires `using Microsoft.Extensions.Logging;`
                    //logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    //logging.AddConsole();
                    logging.AddDebug();
                    //logging.AddLog4Net();
                    //logging.AddEventSourceLogger();
                    //log4net.Util.LogLog.InternalDebugging = true; //enable internal debugging...

                })
                .ConfigureAppConfiguration((context, config) =>
                {
                    // Configure the app here.
                    var env = context.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                          .AddJsonFile($"appsettings.{env.EnvironmentName}.json",
                              optional: true, reloadOnChange: true);
                    config.AddEnvironmentVariables();

                })
                .UseStartup<Startup>();
    }
    #endregion
}
