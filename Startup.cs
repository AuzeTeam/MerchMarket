using backend.Database;

namespace Backend;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        services.AddControllers();
        services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromDays(30); // Время жизни куки-файла
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}