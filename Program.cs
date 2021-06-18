using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace questionexchange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        //  internally creates "Kestrel"
        public static Microsoft.AspNetCore.Hosting.IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().UseContentRoot(Directory.GetCurrentDirectory())
            .Build();
        }

}