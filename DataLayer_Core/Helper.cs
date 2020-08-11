using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataBaseService
{
    public class Helper
    {
        //read from App.Config.
        public static string ReadSetting(string key)
        {
            try
            {

                IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfigurationRoot configuration = builder.Build();
                var configurationSection = configuration.GetSection("DataLayer");
                var result = new List<IConfigurationSection>(configurationSection.GetChildren());
                return result.Find(item => item.Key == key)?.Value;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
