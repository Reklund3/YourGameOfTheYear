using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;
using YourGameOfTheYear.Services;
using YourGameOfTheYear.ViewComponents;

namespace YourGameOfTheYear
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
            services.AddScoped<IRepository, Repository>();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<YourGameOfTheYearContext>(db => db.UseSqlServer(Configuration.GetConnectionString("GameCon")));
            services.AddAuthentication().AddCookie();
            services.AddIdentity<UserInfo, IdentityRole<int>>()
                .AddEntityFrameworkStores<YourGameOfTheYearContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddRoleManager<RoleManager<IdentityRole<int>>>();
            //services.AddDbContext<YourGameOfTheYearContext>(db => db.UseInMemoryDatabase("GameTemp"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
            EnsureDatabaseUpdated(app);
        }
        private void EnsureDatabaseUpdated(IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using (var serviceScope = scopeFactory.CreateScope())
            using (var context = serviceScope.ServiceProvider.GetService<YourGameOfTheYearContext>())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
