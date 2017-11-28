using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShameTheThronesV2.Controllers;
using ShameTheThronesV2.DB;
using ShameTheThronesV2.Repositories;
using ShameTheThronesV2.Repositories.Interfaces;

namespace ShameTheThronesV2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShameTheThronesContext>(options =>
            {
                var conString = Configuration.GetConnectionString("ShameTheThronesDatabase");
                options.UseSqlServer(conString);
            });

   
            services.AddTransient<IRestroomsRepository, RestroomRepository>();
            services.AddTransient<RatingRepository, RatingRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Configuration = getConfiguration(env);
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ShameTheThronesContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
        
            app.UseMvc();
        }

        protected IConfiguration getConfiguration(IHostingEnvironment env)
        {

            string basePath = Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();
            return builder.Build();
        }
    }
}