using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class StartUp {
        
        public void Configure(IApplicationBuilder app) {
            
            app.Run(context => {
                return context.Response.WriteAsync("hi roll");    
            });

        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<StartUp>()
            .Build();

            host.Run();
        }
    }
}
