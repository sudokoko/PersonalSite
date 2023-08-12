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
                application.UseForwardedHeaders();
                application.UseHttpLogging();
                
                application.UseStaticFiles();

                application.UseExceptionHandler("/error/500");
                application.UseStatusCodePagesWithReExecute("/error/{0}");

                application.UseRouting();
                application.UseEndpoints(endpoints => endpoints.MapRazorPages());
            });
            webBuilder.ConfigureServices(services =>
            {
                services.AddRazorPages();
            });
        });
}