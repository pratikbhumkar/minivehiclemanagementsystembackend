using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace VehicleManagementSystem
{
    public static class Configuration
    {
        public static IConfiguration Generate()
        {
            var builder = new ConfigurationBuilder();
            return builder
                .AddJsonFile($"{Directory.GetCurrentDirectory()}/appsettings.json")
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
