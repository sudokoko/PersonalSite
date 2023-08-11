namespace Sudokoko.PersonalSite;

public static class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseWebRoot("StaticFiles");
            webBuilder.Configure(application =>
            {
                application.UseRouting();
                application.UseHttpLogging();
                application.UseStaticFiles();
                application.UseForwardedHeaders();
                application.UseStatusCodePagesWithRedirects("/error/{0}");
                application.UseEndpoints(endpoints => endpoints.MapRazorPages());
            });
            webBuilder.ConfigureServices(services =>
            {
                services.AddRazorPages();
            });
        });
}