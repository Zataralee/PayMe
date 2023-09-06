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
            _client.Ready += ReadyAsync;
        }

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
