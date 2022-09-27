using BotunsEngineeringServices.Contexts;
using BotunsEngineeringServices.Implementations.Repositories;
using BotunsEngineeringServices.Implementations.Services;
using BotunsEngineeringServices.Interfaces.Repositories;
using BotunsEngineeringServices.Interfaces.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotunsEngineeringServices
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
            services.AddControllersWithViews();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientServices, ClientService>();
            services.AddScoped<IContractServices , ContractServices>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<AddressRepository>();
            services.AddScoped<IWorkerRepository , WorkerRepository>();
            services.AddScoped<IAdminRepository , AdminRepository>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(config =>
            {
                config.LoginPath = "/Client/Login";
                config.LogoutPath = "/Client/Index/Logout";
                config.Cookie.Name = "OlajAuth4.0";
                
            });


            services.AddDbContext<ApplicationContext>(options => options.UseMySQL("server=localhost;user=root;database=BotunsEngineeringApp;port=3306;password=OLADOL123"));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
