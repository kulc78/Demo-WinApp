using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Demo_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Demo Chat Start!!!");

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
