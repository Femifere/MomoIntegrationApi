using Microsoft.Extensions.Configuration;

namespace MomoIntegrationApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpClient(); // To interact with MOMO API
            services.AddAuthentication(); // Add OAuth2 authentication
            services.Configure<Settings>(Configuration.GetSection("Settings")); // API key and environment variable setup
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
