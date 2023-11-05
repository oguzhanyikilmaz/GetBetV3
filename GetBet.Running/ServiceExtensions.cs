using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Running
{
    public static class ServiceExtensions
    {
        public static IConfiguration Configure(IConfiguration configuration)
        {
            configuration = new ConfigurationBuilder()
       .AddEnvironmentVariables()
       .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
       .AddJsonFile("appsettings.json")
       .Build();

            ServiceProvider serviceProvider = new ServiceCollection()
        .AddLogging((loggingBuilder) => loggingBuilder
        .AddConfiguration(configuration).SetMinimumLevel(LogLevel.Trace)
            .AddConsole()
            )
        .BuildServiceProvider();

            return configuration;

        }
    }
}
