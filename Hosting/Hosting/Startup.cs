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
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder app)
        {
            var ordem = string.Empty;


            // Executa pela sequencia dos números das Ordens.

            app.Use(async(context, next)=>

            {
                ordem += "1";

                //Ordem 1
                await next.Invoke(); // Chama o proximo Middware que é o proximo app.Use
       


                //Ordem 4
                //await context.Response.WriteAsync("Bem vindo 1");
                ordem += "4";
                await context.Response.WriteAsync($"Ordem {ordem}");


            });

            app.Use(async (context, next) =>

            {
                ordem += "2";

                //Ordem 2
                await next.Invoke();


                ordem += "3";


                //Ordem 3
                //await context.Response.WriteAsync($"Ordem {ordem}");


            });

        }
      
    }
   
}