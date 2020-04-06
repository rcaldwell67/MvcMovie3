#define NotSQLite
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SportsData.Data;

namespace SportsData
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

#if NotSQLite
        #region snippet_ConfigureServices
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<SportsDataContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SportsDataContext")));

            services.AddDbContext<SportsStatsContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SportsStatsContext")));

            services.AddDbContext<TeamsContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("TeamsContext")));

            services.AddDbContext<Sports_HistoryContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Sports_HistoryContext")));
        }
        #endregion
#else
        #region snippet_UseSqlite
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            
            services.AddDbContext<SportsDataContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("SportsDataContext")));
        }
        #endregion
#endif

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthorization();

            #region snippet_1
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            #endregion
        }
    }
}
