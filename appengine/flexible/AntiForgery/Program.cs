using System.Net;

namespace AntiForgery;

public class Program
{
    private WebApplication App {get; set;}

    private Program(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc();
        App = builder.Build();
        App.UseStaticFiles();
        App.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    }

    public static void Main(string[] args)
    {
        new Program(args).App.Run();
    }
}

