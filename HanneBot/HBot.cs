using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Discord;

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
            Console.WriteLine($"Connecting with token: {token.Substring(0, 10)} . . .");
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();
            client.MessageReceived += MessageReceivedAsync;

            // Await forever.
            await Task.Delay(-1);
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {
            if (message.Content == "?")
            {
                await message.Channel.SendMessageAsync(":thinking:");
            }
        }
    }
}
