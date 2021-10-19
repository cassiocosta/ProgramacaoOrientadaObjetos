using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace StartAspNetByConsole
{
    class Program
    {
        static void Main(string[] args)
        {           
            var host = new WebHostBuilder()
                .UseKestrel()
                .Configure(
                    app => {
                        app.Run(context => context.Response.WriteAsync("<h1>Hello world</h1>"));
                    }
                )
                .Build();
                host.Run();
                
        }
    }
}
