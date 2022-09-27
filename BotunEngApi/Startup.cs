using BotunEngApi.Implementations.Repositories;
using BotunsEngApi.Contexts;
using BotunsEngApi.Implementations.Repositories;
using BotunsEngApi.Implementations.Services;
using BotunsEngApi.Interfaces.Repositories;
using BotunsEngApi.Interfaces.Services;
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
using MySql.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotunEngApi
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
            services.AddCors(c => c
                .AddPolicy("Botuns", builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()));
            services.AddControllers();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientServices, ClientService>();
            services.AddScoped<IContractServices, ContractServices>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<AddressRepository>();
            services.AddScoped<IWorkerRepository, WorkerRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<ClientContractRepository>();


            services.AddDbContext<ApplicationContext>(options => options.UseMySQL("server=localhost;user=root;database=BotunsEngineeringApplication;port=3306;password=OLADOL123"));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BotunEngApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BotunEngApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("Botuns");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
