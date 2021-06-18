


 
using Microsoft.AspNetCore.Http; // Jetzt Müsste es gehen!
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
namespace questionexchange
{
    // Sieben Jahre kein SEO
    public class Startup
    {
    
        public void ConfigureServices(IServiceCollection saas)
        {
            // Add a sprinkling of MVC
            //For MVC to spring into life, you need to make some changes to startup.cs.
            saas.AddMvc();
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
               // app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    } // Klammer hat gefehlt

}