using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace qa_services.nancy_example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .UseKestrel()
               .UseStartup<Startup>()
               .Build();

            host.Run();
        }
    }
}
