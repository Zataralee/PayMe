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
            _ledgerDataTable.Columns.Add("Name", typeof(string));
            _ledgerDataTable.Columns.Add("Owner ID", typeof(UInt64));
            _ledgerDataTable.Columns.Add("Trigger Date", typeof(DateTime));
            _ledgerDataTable.Columns.Add("Expire Date", typeof(DateTime));
            _ledgerDataTable.Columns.Add("claimed", typeof(bool));
            _ledgerDataTable.Columns.Add("claimed Date", typeof(DateTime));


            // Initialize the Player DataTable
            _playerDataTable = new DataTable();
            _playerDataTable.Columns.Add("SteamID", typeof(UInt64));
            _playerDataTable.Columns.Add("Steam Name", typeof(string));
            _playerDataTable.Columns.Add("DiscordID", typeof(string));
            _playerDataTable.Columns.Add("DiscordName", typeof(string));


            // Initialize the Rewards DataTable
            _rewardsDataTable = new DataTable();
            _rewardsDataTable.Columns.Add("ID", typeof(Guid));
            _rewardsDataTable.Columns.Add("Discord Level", typeof(string));
            _rewardsDataTable.Columns.Add("Command", typeof(string));
            _rewardsDataTable.Columns.Add("Trigger Date", typeof(DateTime));
            _rewardsDataTable.Columns.Add("Expire Date", typeof(DateTime));


            // Set the DataGridViews' DataSource to the DataTables
            ledgerGridView.DataSource = _ledgerDataTable;
            playerGridView.DataSource = _playerDataTable;
            rewardsGridView.DataSource = _rewardsDataTable;
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
                       $"Bot Auto Connect   = {discordAutoConnect.Checked}\n" + // Save the state of the checkbox
                       $"Payment Database Host   = {paymentsDatabaseHost.Text}\n" +
                       $"Payment Database Port   = {paymentsDatabasePort.Text}  \n" +
                       $"Payment Database User   = {paymentsDatabaseUser.Text} \n" +
                       $"Payment Database Password   = {paymentsDatabasePassword.Text} \n" +
                       $"Payment Database Name   = {paymentsDatabaseDatabase.Text} \n";
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
                ledgerGridView.Refresh();
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
                    _rewardsDataTable.Rows.Add(row.id, row.name, row.discordLevel, row.command, row.triggerDate, row.expireDate);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void paymentsDatabasePort_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
