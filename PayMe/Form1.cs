using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Discord;
using Discord.WebSocket;
using Discord.Net;
using Discord.Interactions;
using Discord.Commands;
using Newtonsoft.Json;

namespace PayMe
{
    public partial class Form1 : Form
    {
        private string defaultConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PayMe", "SaveData", "PayMe.cfg");

        private DiscordSocketClient _client;

                        
        private void LoadConfiguration()
        {
            if (File.Exists(defaultConfigPath))
            {
                string[] configLines = File.ReadAllLines(defaultConfigPath);
                if (configLines.Length >= 6) // Ensure there are at least  lines, including the headers
                {
                    foreach (string line in configLines)
                    {
                        if (line.Contains("Bot Token"))
                        {
                            discordToken.Text = line.Split('=')[1].Trim();
                            Console.WriteLine(discordToken);
                        }
                        else if (line.Contains("Discord Channel"))
                        {
                            channelDiscordID.Text = line.Split('=')[1].Trim();
                        }
                        else if (line.Contains("Save Location"))
                        {
                            saveLocation.Text = line.Split('=')[1].Trim();
                        }
                        else if (line.Contains("Bot Auto Connect"))
                        {
                            discordAutoConnect.Checked = bool.Parse(line.Split('=')[1].Trim());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The configuration file has an unexpected format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                saveLocation.Text = GetDefaultSaveLocation();
                SaveConfiguration();
            }
        }

        public Form1()
        {
            InitializeComponent();
            LoadConfiguration();
            this.Load += Form1_Load;  // Register the Load event

            _client = new DiscordSocketClient();
            _client.Log += LogAsync;
            //_client.Ready += ReadyAsync;
            _client.Ready += Client_Ready; // Hook the Ready event
            _client.InteractionCreated += HandleCommandAsync;

        }

        //New Code

        public async Task Client_Ready()
        {
            // Check if the bot is connected to any guilds
            if (_client.Guilds.Count == 0)
            {
                Console.WriteLine("The bot is not connected to any guilds.");
                return;
            }

            // Get the first guild the bot is connected to
            var guild = _client.Guilds.FirstOrDefault();

            // Check if guild is null
            if (guild == null)
            {
                Console.WriteLine($"Error: Could not find a guild.");
                return;
            }

            Console.WriteLine($"Connected to guild: {guild.Name}, ID: {guild.Id}");

            var command = new SlashCommandBuilder()
                .WithName("payme")
                .WithDescription("Initiate a payment interaction");

            try
            {
                await guild.CreateApplicationCommandAsync(command.Build());
            }
            catch (HttpException httpException)
            {
                Console.WriteLine($"Error creating command: {httpException.Message}");
            }
        }

        private async Task HandleCommandAsync(SocketInteraction interaction)
        {
            if (interaction is SocketSlashCommand command)
            {
                switch (command.Data.Name)
                {
                    case "payme":
                        var user = command.User;
                        if (user is SocketGuildUser guildUser)
                        {
                            //Acknowledge bot interaction. Removes Discord error.
                            await interaction.RespondAsync("I sent you a DM. We'll chat there!", ephemeral:true);

                            var dmChannel = await guildUser.CreateDMChannelAsync();
                            await dmChannel.SendMessageAsync("Hello, how can I help you?");
                        }
                        break;
                }
            }
        }

        //End New Code

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (discordAutoConnect.Checked && !string.IsNullOrWhiteSpace(discordToken.Text))
            {
                await ConnectToDiscordAsync();

            
            }
        }


        private async Task ConnectToDiscordAsync()
        {
            if (_client.LoginState != LoginState.LoggedIn)
            {
                try
                {
                    await _client.LoginAsync(TokenType.Bot, discordToken.Text);
                    await _client.StartAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting: {ex.Message}");
                }
            }
        }

        private string GetDefaultSaveLocation()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PayMe", "SaveData");
        }

        private void SaveConfiguration()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(defaultConfigPath));
                string configData =
                       $"PayMe Config\n\n" +
                       $"Bot Token          = {discordToken.Text}\n" +
                       $"Discord Channel    = {channelDiscordID.Text}\n" +
                       $"Save Location      = {saveLocation.Text}\n" +
                       $"Bot Auto Connect   = {discordAutoConnect.Checked}";  // Save the state of the checkbox
                File.WriteAllText(defaultConfigPath, configData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the configuration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = saveLocation.Text;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    saveLocation.Text = selectedFolderPath;
                    SaveConfiguration();
                }
            }
        }

        private async void discordBotConnect_Click(object sender, EventArgs e)
        {
            await ConnectToDiscordAsync();
        }

        private async Task SendMessageAsync()
        {
            var channelID = ulong.Parse(channelDiscordID.Text);
            var message = discordTestMessage.Text;

            if (_client.LoginState != LoginState.LoggedIn)
            {
                MessageBox.Show("Please connect to Discord first.");
                return;
            }

            var channel = (IMessageChannel)_client.GetChannel(channelID);
            if (channel != null)
            {
                await channel.SendMessageAsync(message);
            }
            else
            {
                MessageBox.Show("Could not find the specified channel.");
            }
        }


        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }

        private Task ReadyAsync()
        {
            Console.WriteLine("Client is connected and ready.");
            return Task.CompletedTask;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveConfiguration();
            MessageBox.Show("Configuration saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            // Your logic for this event goes here.
        }

        private void discordAutoConnect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void discordMSGSend_Click(object sender, EventArgs e)
        {
            _ = SendMessageAsync();
            discordTestMessage.Clear();
            //Console.WriteLine(discordTestMessage.Text);
        }

        private void discordTestMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
