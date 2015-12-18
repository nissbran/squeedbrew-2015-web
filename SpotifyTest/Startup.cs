using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace SpotifyTest
{
    public class Startup
    { 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();
        }
    
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            //app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World 3!");
            });
        }

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
