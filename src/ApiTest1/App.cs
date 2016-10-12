using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ApiTest1
{
    public static class App
    {
        public static void Main()
        {
            var webHostBuilder = new WebHostBuilder();
            webHostBuilder.UseKestrel(); //TODO: Do we want to use Kestrel?
            webHostBuilder.UseIISIntegration(); //TODO: Do we want to use IIS?
            webHostBuilder.UseContentRoot(Directory.GetCurrentDirectory());
            webHostBuilder.UseStartup<AppStartup>();
            webHostBuilder.Build().Run();
        }
    }

    public class AppStartup
    {
        public void Configure(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseMvc();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcCore();
        }
    }
}
