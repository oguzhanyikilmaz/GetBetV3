using GetBet.Business.PlayModelBusiness;
using GetBet.Core.Repository.Abstract;
using GetBet.Core.Repository.Concrete;
using GetBet.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var host = CreateHostBuilder(args).Build();

Application app = host.Services.GetRequiredService<Application>();

static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
  .ConfigureServices(
      (_, services) => services
      .AddSingleton<IUnitOfWork, UnitOfWork>()
      .AddSingleton(x => new Application(args)));
}

class Application
{
    IConfiguration configuration;

    public Application(string[] args)
    {
        //MongoSettings mongoSettings = new MongoSettings();

        //mongoSettings.ConnectionString = "mongodb+srv://oguzzyklmzz:Bayer19770.@carparkcluster.cg0as.mongodb.net/";
        //mongoSettings.Database = "CarParkDB";

        PlayModelBusiness playModelBusiness = new PlayModelBusiness();

        foreach (string arg in args)
        {
            switch (arg)
            {
                case "-Start":
                    Console.WriteLine($"Uygulama başladı.");
                    playModelBusiness.OneAndHalfOverMatches();
                    //playModelBusiness.GetMatchResultsAndSaveDB();
                    //playModelBusiness.GetAndAddPlayStats();
                    //playModelBusiness.AddDBAndSendMailPlayModel();
                    Console.WriteLine($"Uygulama bitti.");
                    break;

                default:
                    Console.WriteLine("Geçersiz parametre girildi.");
                    break;
            }
        }

    }
}