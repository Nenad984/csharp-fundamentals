using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
using MyLibrary.Shared;
using Microsoft.AspNetCore.Mvc.Formatters;
using NorthwindService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

using static System.Console;

namespace NorthwindService
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
            services.AddCors();

            string databasePath = Path.Combine("..", "Northwind.db");

            services.AddDbContext<Northwind>(options =>
            options.UseSqlite($"Data Source={databasePath}"));

            services.AddControllers(options =>
            {
                WriteLine("Default output formatters:");

                foreach (IOutputFormatter formatter in options.OutputFormatters)
                {
                    var mediaFormatter = formatter as OutputFormatter;

                    if (mediaFormatter == null)
                    {
                        WriteLine($" {formatter.GetType().Name}");
                    }
                    else
                    {
                        WriteLine(" {0}, Media types: {1}", arg0: mediaFormatter.GetType().Name, arg1: string.Join(", ",
                            mediaFormatter.SupportedMediaTypes));
                    }
                }
            })
            .AddXmlDataContractSerializerFormatters()
            .AddXmlSerializerFormatters()
            .SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Northwind Service API", Version = "v1" });
            });

            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddHealthChecks()
                .AddDbContextCheck<Northwind>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Northwind Service API Version 1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(configurePolicy: options =>
            {
                options.WithMethods("GET", "POST", "PUT", "DELETE");

                options.WithOrigins("https://localhost:5002");
            });

            app.UseHealthChecks(path: "/howdoyoufeel");

            app.Use(next => (context) =>
            {
                var endpoint = context.GetEndpoint();

                if (endpoint != null)
                {
                    WriteLine("*** Name: {0}; Route: {1}; Metadata: {2}", arg0: endpoint.DisplayName,
                    arg1: (endpoint as RouteEndpoint)?.RoutePattern, arg2: string.Join(", ", endpoint.Metadata));
                }
                return next(context);
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
