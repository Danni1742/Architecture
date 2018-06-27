using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using WebApiCore.Interfaces;
using WebApiCore.Repositories;
using WebApiCore.Services;

namespace WebApiCore
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
            services.AddCors(o =>
             o.AddPolicy("MyPolicy", builder =>
             {
                 builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials();
             }));

            services.AddMvc();

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("MyPolicy"));
            });


            // Repositories
            services.AddTransient<IMobileRepository, MobileRepository>();

            //Services
            services.AddTransient<IMobileService, MobileService>();

            //Swagger debug configuration
#if DEBUG
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new Info { Title = "MobileTest API", Version = "v1" }); });
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var localizationOption = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(localizationOption.Value);
            app.UseAuthentication();
            app.UseCors("MyPolicy");
            app.UseMvc();
#if DEBUG
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "MobileTest API V1"); });
#endif
        }
    }
}