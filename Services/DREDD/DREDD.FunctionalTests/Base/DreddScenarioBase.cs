using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;

namespace DREDD.FunctionalTests.Base
{
    public class DreddScenarioBase
    {
        private const string ApiUrlBase = "api/v1/dredd";

        public TestServer CreateServer()
        {
            var path = Assembly.GetAssembly(typeof(DreddScenarioBase))
               .Location;

            var hostBuilder = new WebHostBuilder()
                .UseContentRoot(Path.GetDirectoryName(path))
                .ConfigureAppConfiguration(cb =>
                {
                    cb.AddJsonFile("appsettings.json", optional: false)
                    .AddEnvironmentVariables();
                }).UseStartup<DreddTestStartup>();

            return new TestServer(hostBuilder);
        }

        public static class Get
        {
            public static string GetTestNumber()
            {
                return $"{ApiUrlBase}";
            }
        }

        public static class Post
        {
            public static string Dredd = $"{ApiUrlBase}/";
        }
    }
}
