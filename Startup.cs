using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace Controllers1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder App)
        {
            App.UseStaticFiles(); // how we include images, javascript, or any other static files other than views.
            App.UseMvc();
        }
    }
}