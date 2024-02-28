using FlyingDutchmanAirlines;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FlyingDutchmanAirlines
{
    internal class Program
    {
        private static void InitializeHost()
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                {

                    builder.UseStartup<Startup>();
                    builder.UseUrls("http://0.0.0.0:8080");
                }).Build().Run();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Application running...");
            InitializeHost();
        }
    }

}
