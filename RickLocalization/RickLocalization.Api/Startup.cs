using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RickLocalization.Api.Filters;
using RickLocalization.Repository.EF;
using RickLocalization.Service.Interfaces;
using RickLocalization.Service.Queries.Dimensao;
using RickLocalization.Service.Queries.Rick;
using RickLocalization.Service.Queries.Viagem;
using RickLocalization.Service.RepositoryDapperService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RickLocalization.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string AllowOrigin = "_allowOrigin";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IRepositoryDapperService, RepositoryDapperService>();
            services.AddScoped<IRickService, RickService>();
            services.AddScoped<IViagemService, ViagemService>();

            services.AddControllers();

            

            services.AddDbContext<RickLocalizationContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("RickDbConnection"),
                    b => b.MigrationsAssembly(typeof(RickLocalizationContext).Assembly.FullName)));


            services.AddCors(options =>
            {
                options.AddPolicy(AllowOrigin,
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod()
                           .SetIsOriginAllowed((host) => true);

                });
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Rick_Localization", Version = "v1" });
            });

            var assembly = AppDomain.CurrentDomain.Load("RickLocalization.Service");
            services.AddMediatR(assembly);

            services.AddControllers(options =>
                options.Filters.Add<GenericResponseAsyncActionFilter>()
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RickLocalization v1"));
            }

           // app.UseSwagger();


            app.UseRouting();

            app.UseCors(AllowOrigin);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
