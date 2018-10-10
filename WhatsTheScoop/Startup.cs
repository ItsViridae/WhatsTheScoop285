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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
//Must add new [using] files in start up!
using WhatsTheScoop.Data;
using WhatsTheScoop.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WhatsTheScoop
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
            
            services.Configure<CookiePolicyOptions>(options =>
            {
                //This lambda deetermines wheeather user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = ContextBoundObject => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connection = @"Server=(localdb)\mssqllocaldb;Database=WhatsTheScoop.Data;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<BloggingContext>
                (options => options.UseSqlServer(connection));
            //BloggingContext requires 
            //using "TheNameOfYourProject.Folder(holding data);"
            //UseSqlServer requires
            //using Microsoft.EntityFrameworkCore;

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
