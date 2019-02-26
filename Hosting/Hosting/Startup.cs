using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hosting
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>

            {
                //await context.Response.WriteAsync("Trabalhando com Classe Startup");
                await context.Response.WriteAsync(_configuration["Application"]);
            });

        }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
    }
   
}