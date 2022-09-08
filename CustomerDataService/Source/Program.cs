using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CustomerDataService
{

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();//We talked about how is this used to build and run the program but also we would like you to tell how it works.
        }

        public static IHostBuilder CreateHostBuilder(string[] args)//is this method is always used to run any .net core program?
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); webBuilder.UseUrls("http://localhost:44335"); });
        }
    }
}