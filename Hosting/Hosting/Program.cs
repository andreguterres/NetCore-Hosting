﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;


namespace Hosting
{
    class Program
    {
        public static void Main(string[] args)
        {

            //var host = new WebHostBuilder()
            //.UseKestrel()
            //.UseStartup<Startup>()
            //.Build();
            //host.Run();

        var host = WebHost
            .CreateDefaultBuilder(args)            
            .UseStartup<Startup>()
            .Build();
            host.Run();


            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //    .UseStartup<Startup>()


        }

    }

}