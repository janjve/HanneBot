using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HanneBot
{
    public class HBot
    {
        public HBot()
        {

        }

        public async Task Run()
        {
            var client = new DiscordSocketClient();
            string token = ConfigurationManager.AppSettings["bot_token"];
            Console.WriteLine(token);
            // await client.LoginAsync(TokenType.Bot, token);
            // await client.StartAsync();
        }
    }
}
