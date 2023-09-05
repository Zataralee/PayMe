using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayMe.Services
{
    public class DiscordService
    {
        private DiscordClient _client { get; set; }
        private CommandsNextExtension _commands { get; set; }


        private string token = ConfigurationManager.AppSettings["discordToken_Bot"];
        private string prefix = ConfigurationManager.AppSettings["discordPrefix_Bot"];

        //private string configFile = Application.StartupPath + @"/configs/discordConfig_Bot.json";

        //Path.GetFullPath()   "discordConfig_Bot.json";

        //public DiscordService(DiscordClient client, CommandsNextExtension commands, string filePath)
        //{
        //    client = _client;
        //    commands = _commands;
        //    //filePath = FilePath;
        //}

        public void GetDiscordBotConfig()
        {
            //var jsonreader = new JSONReader();
            //jsonreader.ReadJson(configFile);

            var discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            _client = new DiscordClient(discordConfig);

            _client.Ready += Client_Ready;

            _client.ConnectAsync();
            System.Threading.Thread.Sleep(-1);

        }

        private static Task Client_Ready(DiscordClient sender, ReadyEventArgs args)
        {
            return Task.CompletedTask;
        }



    }
}
