using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MyAWSLambda
{
    public class ConfigurationService : IConfigurationService
    {
        public IEnvironmentService EnvService { get; }

        public ConfigurationService(IEnvironmentService envService)
        {
            EnvService = envService;
        }

        public IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{EnvService.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

    }
}
