using System;
using System.Threading.Tasks;
using BenLife.Core;
using BenLife.Core.Helpers;
using Serilog;

namespace BenLife.Service
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/benLife.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            
            var benFactory = new BenFactory();
            var ben = benFactory.GenerateBen();

            var places = CityHelper.GeneratePlaces();
            var city = new City(places);

            while (true)
            {
                var time = DateTime.Now.ToString("U");
                Log.Information("Ben started new life at {time}", time);
                
                await Live(ben, city);
                
                time = DateTime.Now.ToString("U");
                Log.Information("Ben died at {time}", time);

                ben = benFactory.GenerateBen();
            }

        }

        private static async Task Live(Person ben, City city)
        {
            while (ben.IsAlive)
            {
                var place = city.GetRandomPlace();
                Log.Information("Ben decided to go to {@place}", place);
                ben.Go(to: place);
                Log.Information("After that Ben's condition became {@ben}", ben);

                await Task.Delay(2000);
            }
        }
    }
}