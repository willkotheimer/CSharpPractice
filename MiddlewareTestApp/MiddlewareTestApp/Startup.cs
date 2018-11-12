using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MiddlewareTestApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.Use(async (context, next) =>
            {
                try
                {
                    await next();

                } catch(Exception e)
                {
                    await context.Response.WriteAsync("Oops, something went wrong...");
                }
                
            });

            app.Use((context, next) =>
            {
                Random randomizer = new Random();
                int chance = randomizer.Next(10);
                if(chance % 2 ==0)
                {
                    throw new Exception("Invalid Operation");

                }
                return next();
            });
            app.Map("/home", appBuilder =>
            {
                appBuilder.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Home page");
                });
            });

            app.Map("/about", appBuilder =>
            {
                appBuilder.Run(async (context) => {
                    await context.Response.WriteAsync("About Page");
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello ASP.NET Core");
            });
        }
    }
}
