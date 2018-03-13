using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace w2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureAppConfiguration(LoadConfiguration)
                .ConfigureLogging(ConfigureLogging)
            .Build();

        private static void ConfigureLogging(ILoggingBuilder logggingBuilder)
        {
            logggingBuilder.AddConsole();
        }

        private static void LoadConfiguration(IConfigurationBuilder configuration)
        {
            configuration.AddJsonFile("db-configuration.json");
        }
    }
}
