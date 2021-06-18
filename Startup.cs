

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http; // Jetzt Müsste es gehen!
using Microsoft.Extensions.DependencyInjection;

namespace questionexchange
{
    public class Startup
    {
    
        public void ConfigureServices(IServiceCollection saas)
        {
            // Add a sprinkling of MVC
            //For MVC to spring into life, you need to make some changes to startup.cs.
            saas.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment paas)
        {
            app.UseMvc();
            // Waiting for updates -...
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("THE CYCLE REPEATED.. ");
            });
        }
    } // Klammer hat gefehlt

}