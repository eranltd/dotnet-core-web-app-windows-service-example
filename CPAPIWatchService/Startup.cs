using CPAPIWatchService.HostedServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CPAPIWatchService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHostedService<CPAPIHostedService>();
            services.AddHostedService<CacheRemoverHostedService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            
            //loggerFactory.AddLog4Net(); //Log4Net
            app.UseStaticFiles();
            app.UseMvc()
            .UseDefaultFiles();

            log4net.Util.LogLog.InternalDebugging = true; //enable internal debugging...
                                                          //Load configuration from log4net.config file
            var logRepository = log4net.LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());

            log4net.Config.XmlConfigurator.Configure(logRepository,
                                                     new System.IO.FileInfo("log4net.config"));

        }
    }
}
