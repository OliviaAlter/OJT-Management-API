using API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ojt_management_api;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder
                =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
    
    //TODO: Admin CRUD : Major, company & generate reports (for quarterly reports)
    //TODO: Student : Apply for a company, CRUD Information (Self), Search for companies, Get a list of potential compnaies
    //TODO: Company : Receive applications, Action for each application, CRUD Info and OJT posts

}