namespace Sudokoko.PersonalSite;

public class Startup
{
    public void Configure(IApplicationBuilder application)
    {
        application.UseForwardedHeaders();
        application.UseHttpLogging();

        application.UseStaticFiles();

        application.UseExceptionHandler("/error/500");
        application.UseStatusCodePagesWithReExecute("/error/{0}");

        application.UseRouting();
        application.UseEndpoints(endpoints => endpoints.MapRazorPages());
    }

    public void ConfigureServices(IServiceCollection services) => services.AddRazorPages();
}