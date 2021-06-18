


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Jetzt Müsste es gehen!
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
namespace questionexchange
{
    // Sieben Jahre kein SEO, dafür 3.0 Migration
    public class Startup
    {
    
        public void ConfigureServices(IServiceCollection saas)
        {
            // Add a sprinkling of MVC
            //For MVC to spring into life, you need to make some changes to startup.cs.
            //Old Way
            saas.AddMvc();
            // New Ways
            //services.AddRazorPages();
        }

        public void Configure( IApplicationBuilder app, IHostingEnvironment paas)
        {
            if (paas.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Game}/{action=Index}");
            });
        }
    } // Klammer hat gefehlt

}