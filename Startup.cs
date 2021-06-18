

using Microsoft.AspNetCore.Hosting;

namespace questionexchange
{
    public class Startup
    {
    
        public void ConfigureServices(IServiceCollection saas)
        {
                // The cycle repeated ...

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment  paas)
        {
            if (paas.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Waiting for updates -...
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("THE CYCLE REPEATED.. ");
            });
    
}

}