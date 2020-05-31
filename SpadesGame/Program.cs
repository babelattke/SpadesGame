using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SpadesGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class Settings
    {
        public static int bot1Score = 0, bot2Score = 0, bot3Score = 0, hPlayerScore = 0;
        public static string bot1Name = "Bot 1", bot2Name = "Bot 2", bot3Name = "Bot 3", hPlayerName = "Me...";
        public static int bot1Bid = 0, bot2Bid = 0, bot3Bid = 0, hPlayerBid = 0;
        public static int bot1CBid = 0, bot2CBid = 0, bot3CBid = 0, hPlayerCBid = 0;
        public static int teamAbid = 0, teamBbid = 0;
        public static string bot1Status = "Waiting...", bot2Status = "Waiting...", bot3Status = "Waiting...", hPlayerStatus = "Your turn...";
    }
        
}
