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
using DSharpPlus.Entities;

namespace PayMe
{

    public partial class Form1 : Form
    {
        private string defaultConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PayMe", "SaveData", "PayMe.cfg");

        private DiscordSocketClient _client;

        private readonly PaymentDatabase _paymentDatabase;
        private DataTable _ledgerDataTable;
        private DataTable _playerDataTable;
        private DataTable _rewardsDataTable;

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
                        else if (line.Contains("Payment Database Host"))
                            paymentsDatabaseHost.Text = line.Split('=')[1].Trim();
                        else if (line.Contains($"Payment Database Port"))
                            paymentsDatabasePort.Text = line.Split('=')[1].Trim();
                        else if (line.Contains("Payment Database User"))
                            paymentsDatabaseUser.Text= line.Split('=')[1].Trim();
                        else if (line.Contains("Payment Database Password"))
                            paymentsDatabasePassword.Text= line.Split('=')[1].Trim();
                        else if (line.Contains("Payment Database Name"))
                            paymentsDatabaseDatabase.Text= line.Split('=')[1].Trim();
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

            // Handle the Tick event of the Timer
            droleupdate.Tick += Timer1_Tick;
            _client.Ready += ReadyAsync;

            // Initialize the payment Database with saved connection information
            _paymentDatabase = new PaymentDatabase(paymentsDatabaseHost.Text, uint.Parse(paymentsDatabasePort.Text), paymentsDatabaseUser.Text, paymentsDatabasePassword.Text, paymentsDatabaseDatabase.Text);
            try
            {
                _paymentDatabase.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Check SQL connection settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Initialize the Ledger DataTable
            _ledgerDataTable = new DataTable();
            _ledgerDataTable.Columns.Add("ID", typeof(Guid));
            _ledgerDataTable.Columns[0].ReadOnly = true;
            _ledgerDataTable.Columns.Add("Name", typeof(string));
            _ledgerDataTable.Columns.Add("Owner ID", typeof(UInt64));
            _ledgerDataTable.Columns.Add("Command", typeof(string));
            _ledgerDataTable.Columns.Add("Trigger Date", typeof(DateTime));
            _ledgerDataTable.Columns.Add("Expire Date", typeof(DateTime));
            _ledgerDataTable.Columns.Add("claimed", typeof(bool));
            _ledgerDataTable.Columns.Add("claimed Date", typeof(DateTime));


            // Initialize the Player DataTable
            _playerDataTable = new DataTable();
            _playerDataTable.Columns.Add("SteamID", typeof(UInt64));
            _playerDataTable.Columns[0].ReadOnly = true;
            _playerDataTable.Columns.Add("Steam Name", typeof(string));
            _playerDataTable.Columns.Add("DiscordID", typeof(string));
            _playerDataTable.Columns.Add("DiscordName", typeof(string));


            // Initialize the Rewards DataTable
            _rewardsDataTable = new DataTable();
            _rewardsDataTable.Columns.Add("ID", typeof(Guid));
            _rewardsDataTable.Columns[0].ReadOnly = true;
            _rewardsDataTable.Columns.Add("Name", typeof(string));
            _rewardsDataTable.Columns.Add("Discord Role", typeof(string));
            _rewardsDataTable.Columns.Add("Command", typeof(string));
            _rewardsDataTable.Columns.Add("Run On All Servers", typeof(bool));
            _rewardsDataTable.Columns.Add("Auto Claim", typeof(bool));
            _rewardsDataTable.Columns.Add("Transferable", typeof(bool));
            _rewardsDataTable.Columns.Add("Trigger Interval", typeof(TimeSpan));
            _rewardsDataTable.Columns.Add("Expire Interval", typeof(TimeSpan));


            // Set the DataGridViews' DataSource to the DataTables
            pendingLedgerGridView.DataSource = _ledgerDataTable;
            playerGridView.DataSource = _playerDataTable;
            rewardsGridView.DataSource = _rewardsDataTable;
        }


        private async void Timer1_Tick(object sender, EventArgs e)
        {
            // Update roles every 2 minutes
            await UpdateRolesAsync();
        }

        private Task UpdateRolesAsync()
        {
            if (_client?.LoginState == LoginState.LoggedIn)
            {
                var guild = _client.Guilds.FirstOrDefault();
                if (guild != null)
                {
                    discordroleslist.Invoke((MethodInvoker)delegate
                    {
                        discordroleslist.Items.Clear();
                        foreach (var role in guild.Roles)
                        {
                            discordroleslist.Items.Add(role.Name);
                        }
                    });
                }
            }

            return Task.CompletedTask;
        }

        //Verify connected to guild(server) and register commands

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

            // Start the Timer when the bot is ready
            droleupdate.Start();

            // Initial update of roles
            await UpdateRolesAsync();

        }

        //respond to payme command
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

                            // Create DM Channel
                            var dmChannel = await guildUser.CreateDMChannelAsync();

                            //Collect user data
                            string username = user.Username;
                            ulong userId = user.Id;

                            // Get users roles
                            var roles = guildUser.Roles.Select(role => role.Name);

                            //Format roles for output
                            //string rolesOutput = string.Join(", ", roles);

                            // Create an embed builder
                            var embedBuilder = new EmbedBuilder()
                                .WithTitle($"Information for {username}")
                                .AddField("Discord ID", userId.ToString())
                                .AddField("Roles", string.Join(", ", roles))
                                .WithColor(Discord.Color.Blue);

                            //Send message to user
                            //await dmChannel.SendMessageAsync($"Hello, {username}! Your Discord ID is {userId}. You have the following roles: {rolesOutput}.");
                            // Send embedded message to user
                            await dmChannel.SendMessageAsync(embed: embedBuilder.Build());
                        }
                        break;
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (discordAutoConnect.Checked && !string.IsNullOrWhiteSpace(discordToken.Text))
            {
                await ConnectToDiscordAsync();

            
            }
            LoadRewardsData();
            LoadLedgerData();
            LoadPlayerData();
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
                       $"Bot Auto Connect   = {discordAutoConnect.Checked}\n" + // Save the state of the checkbox
                       $"Payment Database Host   = {paymentsDatabaseHost.Text}\n" +
                       $"Payment Database Port   = {paymentsDatabasePort.Text}\n" +
                       $"Payment Database User   = {paymentsDatabaseUser.Text}\n" +
                       $"Payment Database Password   = {paymentsDatabasePassword.Text}\n" +
                       $"Payment Database Name   = {paymentsDatabaseDatabase.Text}\n";
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

        private void LoadLedgerData()
        {
            try
            {
                // Clear the existing data in the DataTable
                _ledgerDataTable.Clear();

                // Retrieve data from the database and populate the DataTable
                var data = _paymentDatabase.GetDataFromTable<PaymentData>();

                foreach (var row in data)
                {
                    _ledgerDataTable.Rows.Add(row.id, row.name, row.ownerId, row.triggerDate, row.expireDate, row.claimed, row.claimDate);
                }

                // Update the DataGridView
                pendingLedgerGridView.Refresh();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during data loading
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadPlayerData()
        {
            try
            {
                // Clear the existing data in the DataTable
                _playerDataTable.Clear();

                // Retrieve data from the database and populate the DataTable
                var data = _paymentDatabase.GetDataFromTable<PlayerData>();

                foreach (var row in data)
                {
                    _playerDataTable.Rows.Add(row.id, "Steam Name not found" ,row.discordID, "Discord Name not found");
                }

                // Update the DataGridView
                playerGridView.Refresh();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during data loading
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadRewardsData()
        {
            try
            {
                // Clear the existing data in the DataTable
                _rewardsDataTable.Clear();

                // Retrieve data from the database and populate the DataTable
                var data = _paymentDatabase.GetDataFromTable<RewardsData>();

                foreach (var row in data)
                {
                    _rewardsDataTable.Rows.Add(row.id, row.name, row.discordRole, row.command, row.runOnAll, row.autoClaim, row.triggerInterval, row.expireInterval);
                }

                // Update the DataGridView
                rewardsGridView.Refresh();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during data loading
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void SaveRewardsData()
        {
            try
            {
                // Clear the existing data in the DataTable
                //_rewardsDataTable.Clear();

                // Retrieve data from the database and populate the DataTable
                //var data = _paymentDatabase.GetDataFromTable<RewardsData>();

                foreach (DataRow row in _rewardsDataTable.Rows)
                {
                    if (!row["ID"].ToString().Equals(""))
                        _paymentDatabase.UpsertData(new RewardsData { id = new Guid(row["ID"].ToString()), name = row["Name"].ToString(), discordRole = row["Discord Role"].ToString(), command = row["Command"].ToString() });//, runOnAll = (bool)row["Run On All Servers"], autoClaim = (bool)row["Auto Claim"] });//, triggerInterval = new TimeSpan(row["Trigger Interval"].ToString()), expireInterval = TimeSpan(row["Expire Interval"].ToString()) });
                }

                // Update the DataGridView from the database
                LoadRewardsData();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during data loading
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveConfiguration();
            MessageBox.Show("Configuration saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void settingsTabPage_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void discordRolesLabel_Click(object sender, EventArgs e)
        {

        }

        private void paymentsDatabaseDatabaseLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void databasePortLabel_Click(object sender, EventArgs e)
        {

        }

        private void paymentsDatabasePort_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rewardsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine($"cell contents clicked: {e.ToString()} {sender.ToString()}");
            if (_rewardsDataTable.Rows.Count <= e.RowIndex)
                _rewardsDataTable.Rows.Add(Guid.NewGuid());
            else if ((e.ColumnIndex == 0) && (_rewardsDataTable.Rows[e.RowIndex][e.ColumnIndex].ToString().Equals("")))
            {
                //Console.WriteLine("cell is empty");
                _rewardsDataTable.Columns[0].ReadOnly = false;
                _rewardsDataTable.Rows[e.RowIndex]["ID"] = Guid.NewGuid();
                _rewardsDataTable.Columns[0].ReadOnly = true;

                //_rewardsDataTable.Rows[e.RowIndex][e.ColumnIndex] = Guid.NewGuid();
            }
            //Console.WriteLine(_rewardsDataTable.Rows[e.RowIndex][e.ColumnIndex].ToString());
        }

        private void sqlConfigSave_Click(object sender, EventArgs e)
        {
            _paymentDatabase.host = paymentsDatabaseHost.Text;
            _paymentDatabase.port = uint.Parse(paymentsDatabasePort.Text);
            _paymentDatabase.userName = paymentsDatabaseUser.Text;
            _paymentDatabase.password = paymentsDatabasePassword.Text;
            _paymentDatabase.database = paymentsDatabaseDatabase.Text;
            try
            {
                _paymentDatabase.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Check SQL connection settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SaveConfiguration();
        }

        private void rewardsRowAdded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.SetValues(Guid.NewGuid());
        }

        private void rewardsSaveButton_click(object sender, EventArgs e)
        {
            Console.WriteLine("saving rewards");
            SaveRewardsData();
        }

        private void rewardsRowRemoved(object sender, DataGridViewRowCancelEventArgs e)
        {
            Console.WriteLine($"removing id {_rewardsDataTable.Rows[e.Row.Index]["ID"]} from table");
            _paymentDatabase.RemoveData(new RewardsData { id = new Guid(_rewardsDataTable.Rows[e.Row.Index]["ID"].ToString()) });
            LoadRewardsData();
        }

        private void discordroleslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void droleupdate_Tick(object sender, EventArgs e)
        {

        }
    }
}
