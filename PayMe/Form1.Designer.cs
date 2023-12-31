﻿namespace PayMe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.rewardsTabPage = new System.Windows.Forms.TabPage();
            this.generateCurrentLedgerButton = new System.Windows.Forms.Button();
            this.rewardsGridView = new System.Windows.Forms.DataGridView();
            this.discordRolesLabel = new System.Windows.Forms.Label();
            this.discordroleslist = new System.Windows.Forms.CheckedListBox();
            this.rewardsSaveButton = new System.Windows.Forms.Button();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.playerGridView = new System.Windows.Forms.DataGridView();
            this.ledgerTabPage = new System.Windows.Forms.TabPage();
            this.ledgerTabControl = new System.Windows.Forms.TabControl();
            this.unclaimedLedgerTabPage = new System.Windows.Forms.TabPage();
            this.unclaimedLedgerGridView = new System.Windows.Forms.DataGridView();
            this.claimedLedgerTabPage = new System.Windows.Forms.TabPage();
            this.claimedLedgerDataGridView = new System.Windows.Forms.DataGridView();
            this.expiredLedgerTabPage = new System.Windows.Forms.TabPage();
            this.expiredLedgerDataGridView = new System.Windows.Forms.DataGridView();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.discordSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.discordAutoConnect = new System.Windows.Forms.CheckBox();
            this.discordTestMessageLabel = new System.Windows.Forms.Label();
            this.discordChannelIDLabel = new System.Windows.Forms.Label();
            this.discordBotTokenLabel = new System.Windows.Forms.Label();
            this.discordMSGSend = new System.Windows.Forms.Button();
            this.discordBotConnect = new System.Windows.Forms.Button();
            this.discordTestMessage = new System.Windows.Forms.TextBox();
            this.channelDiscordID = new System.Windows.Forms.TextBox();
            this.discordToken = new System.Windows.Forms.TextBox();
            this.nexusDatabaseSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.databasePortLabel = new System.Windows.Forms.Label();
            this.nexusDatabaseHost = new System.Windows.Forms.TextBox();
            this.nexusDatabaseHostLabel = new System.Windows.Forms.Label();
            this.nexusDatabasePort = new System.Windows.Forms.MaskedTextBox();
            this.databaseDatabaseLabel = new System.Windows.Forms.Label();
            this.nexusDatabaseUser = new System.Windows.Forms.TextBox();
            this.nexusDatabaseUsernameLabel = new System.Windows.Forms.Label();
            this.nexusDatabaseDatabase = new System.Windows.Forms.TextBox();
            this.nexusDatabasePasswordLabel = new System.Windows.Forms.Label();
            this.paymentsDatabaseSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.paymentsDatabasePassword = new System.Windows.Forms.TextBox();
            this.paymentsDatabasePortLabel = new System.Windows.Forms.Label();
            this.paymentsDatabaseHost = new System.Windows.Forms.TextBox();
            this.paymentsDatabasePort = new System.Windows.Forms.MaskedTextBox();
            this.paymentsDatabaseHostLabel = new System.Windows.Forms.Label();
            this.paymentsDatabaseDatabaseLabel = new System.Windows.Forms.Label();
            this.paymentsDatabaseUser = new System.Windows.Forms.TextBox();
            this.paymentsDatabaseUsernameLabel = new System.Windows.Forms.Label();
            this.paymentsDatabaseDatabase = new System.Windows.Forms.TextBox();
            this.paymentsDatabasePasswordLabel = new System.Windows.Forms.Label();
            this.settingsSaveButton = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.configSaveLocation = new System.Windows.Forms.Button();
            this.droleupdate = new System.Windows.Forms.Timer(this.components);
            this.clearRewardLedgerButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.rewardsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsGridView)).BeginInit();
            this.playersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerGridView)).BeginInit();
            this.ledgerTabPage.SuspendLayout();
            this.ledgerTabControl.SuspendLayout();
            this.unclaimedLedgerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unclaimedLedgerGridView)).BeginInit();
            this.claimedLedgerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimedLedgerDataGridView)).BeginInit();
            this.expiredLedgerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expiredLedgerDataGridView)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            this.discordSettingsGroupBox.SuspendLayout();
            this.nexusDatabaseSettingsGroupBox.SuspendLayout();
            this.paymentsDatabaseSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.rewardsTabPage);
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.ledgerTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1775, 924);
            this.mainTabControl.TabIndex = 0;
            // 
            // rewardsTabPage
            // 
            this.rewardsTabPage.BackColor = System.Drawing.Color.DimGray;
            this.rewardsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rewardsTabPage.Controls.Add(this.generateCurrentLedgerButton);
            this.rewardsTabPage.Controls.Add(this.rewardsGridView);
            this.rewardsTabPage.Controls.Add(this.discordRolesLabel);
            this.rewardsTabPage.Controls.Add(this.discordroleslist);
            this.rewardsTabPage.Controls.Add(this.rewardsSaveButton);
            this.rewardsTabPage.Location = new System.Drawing.Point(4, 22);
            this.rewardsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.rewardsTabPage.Name = "rewardsTabPage";
            this.rewardsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.rewardsTabPage.Size = new System.Drawing.Size(1767, 898);
            this.rewardsTabPage.TabIndex = 0;
            this.rewardsTabPage.Text = "Rewards";
            this.rewardsTabPage.Click += new System.EventHandler(this.rewardsSaveButton_click);
            // 
            // generateCurrentLedgerButton
            // 
            this.generateCurrentLedgerButton.AutoSize = true;
            this.generateCurrentLedgerButton.Location = new System.Drawing.Point(928, 494);
            this.generateCurrentLedgerButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateCurrentLedgerButton.Name = "generateCurrentLedgerButton";
            this.generateCurrentLedgerButton.Size = new System.Drawing.Size(134, 30);
            this.generateCurrentLedgerButton.TabIndex = 5;
            this.generateCurrentLedgerButton.Text = "Generate Current Ledger";
            this.generateCurrentLedgerButton.UseVisualStyleBackColor = true;
            this.generateCurrentLedgerButton.Click += new System.EventHandler(this.generateCurrentLedgerButton_Click);
            // 
            // rewardsGridView
            // 
            this.rewardsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rewardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rewardsGridView.Location = new System.Drawing.Point(7, 21);
            this.rewardsGridView.Name = "rewardsGridView";
            this.rewardsGridView.RowHeadersWidth = 62;
            this.rewardsGridView.Size = new System.Drawing.Size(1055, 453);
            this.rewardsGridView.TabIndex = 3;
            this.rewardsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rewardsGridView_CellContentClick);
            this.rewardsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rewardsGridView_CellContentClick);
            this.rewardsGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.rewardsRowAdded);
            this.rewardsGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.rewardsRowRemoved);
            // 
            // discordRolesLabel
            // 
            this.discordRolesLabel.AutoSize = true;
            this.discordRolesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordRolesLabel.Location = new System.Drawing.Point(1063, 49);
            this.discordRolesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordRolesLabel.Name = "discordRolesLabel";
            this.discordRolesLabel.Size = new System.Drawing.Size(109, 17);
            this.discordRolesLabel.TabIndex = 4;
            this.discordRolesLabel.Text = "Discord Roles";
            // 
            // discordroleslist
            // 
            this.discordroleslist.FormattingEnabled = true;
            this.discordroleslist.Location = new System.Drawing.Point(1066, 68);
            this.discordroleslist.Margin = new System.Windows.Forms.Padding(2);
            this.discordroleslist.Name = "discordroleslist";
            this.discordroleslist.Size = new System.Drawing.Size(223, 394);
            this.discordroleslist.TabIndex = 3;
            this.discordroleslist.SelectedIndexChanged += new System.EventHandler(this.discordroleslist_SelectedIndexChanged);
            // 
            // rewardsSaveButton
            // 
            this.rewardsSaveButton.AutoSize = true;
            this.rewardsSaveButton.Location = new System.Drawing.Point(5, 494);
            this.rewardsSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.rewardsSaveButton.Name = "rewardsSaveButton";
            this.rewardsSaveButton.Size = new System.Drawing.Size(89, 30);
            this.rewardsSaveButton.TabIndex = 2;
            this.rewardsSaveButton.Text = "Save";
            this.rewardsSaveButton.UseVisualStyleBackColor = true;
            this.rewardsSaveButton.Click += new System.EventHandler(this.rewardsSaveButton_click);
            // 
            // playersTabPage
            // 
            this.playersTabPage.BackColor = System.Drawing.Color.DimGray;
            this.playersTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playersTabPage.Controls.Add(this.playerGridView);
            this.playersTabPage.Location = new System.Drawing.Point(4, 22);
            this.playersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.playersTabPage.Size = new System.Drawing.Size(1767, 898);
            this.playersTabPage.TabIndex = 1;
            this.playersTabPage.Text = "Users";
            // 
            // playerGridView
            // 
            this.playerGridView.AllowUserToDeleteRows = false;
            this.playerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playerGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGridView.Location = new System.Drawing.Point(32, 37);
            this.playerGridView.Name = "playerGridView";
            this.playerGridView.RowHeadersWidth = 62;
            this.playerGridView.Size = new System.Drawing.Size(898, 561);
            this.playerGridView.TabIndex = 0;
            // 
            // ledgerTabPage
            // 
            this.ledgerTabPage.BackColor = System.Drawing.Color.DimGray;
            this.ledgerTabPage.Controls.Add(this.clearRewardLedgerButton);
            this.ledgerTabPage.Controls.Add(this.ledgerTabControl);
            this.ledgerTabPage.Location = new System.Drawing.Point(4, 22);
            this.ledgerTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ledgerTabPage.Name = "ledgerTabPage";
            this.ledgerTabPage.Size = new System.Drawing.Size(1767, 898);
            this.ledgerTabPage.TabIndex = 2;
            this.ledgerTabPage.Text = "Ledger";
            // 
            // ledgerTabControl
            // 
            this.ledgerTabControl.Controls.Add(this.unclaimedLedgerTabPage);
            this.ledgerTabControl.Controls.Add(this.claimedLedgerTabPage);
            this.ledgerTabControl.Controls.Add(this.expiredLedgerTabPage);
            this.ledgerTabControl.Location = new System.Drawing.Point(0, 0);
            this.ledgerTabControl.Name = "ledgerTabControl";
            this.ledgerTabControl.SelectedIndex = 0;
            this.ledgerTabControl.Size = new System.Drawing.Size(1183, 620);
            this.ledgerTabControl.TabIndex = 1;
            // 
            // unclaimedLedgerTabPage
            // 
            this.unclaimedLedgerTabPage.Controls.Add(this.unclaimedLedgerGridView);
            this.unclaimedLedgerTabPage.Location = new System.Drawing.Point(4, 22);
            this.unclaimedLedgerTabPage.Name = "unclaimedLedgerTabPage";
            this.unclaimedLedgerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.unclaimedLedgerTabPage.Size = new System.Drawing.Size(1175, 594);
            this.unclaimedLedgerTabPage.TabIndex = 0;
            this.unclaimedLedgerTabPage.Text = "Unclaimed Rewards";
            this.unclaimedLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // unclaimedLedgerGridView
            // 
            this.unclaimedLedgerGridView.AllowUserToAddRows = false;
            this.unclaimedLedgerGridView.AllowUserToOrderColumns = true;
            this.unclaimedLedgerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unclaimedLedgerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unclaimedLedgerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unclaimedLedgerGridView.Location = new System.Drawing.Point(3, 3);
            this.unclaimedLedgerGridView.Name = "unclaimedLedgerGridView";
            this.unclaimedLedgerGridView.RowHeadersWidth = 62;
            this.unclaimedLedgerGridView.Size = new System.Drawing.Size(1169, 588);
            this.unclaimedLedgerGridView.TabIndex = 0;
            // 
            // claimedLedgerTabPage
            // 
            this.claimedLedgerTabPage.Controls.Add(this.claimedLedgerDataGridView);
            this.claimedLedgerTabPage.Location = new System.Drawing.Point(4, 22);
            this.claimedLedgerTabPage.Name = "claimedLedgerTabPage";
            this.claimedLedgerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.claimedLedgerTabPage.Size = new System.Drawing.Size(1175, 594);
            this.claimedLedgerTabPage.TabIndex = 1;
            this.claimedLedgerTabPage.Text = "Claimed Rewards";
            this.claimedLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // claimedLedgerDataGridView
            // 
            this.claimedLedgerDataGridView.AllowUserToAddRows = false;
            this.claimedLedgerDataGridView.AllowUserToOrderColumns = true;
            this.claimedLedgerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.claimedLedgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.claimedLedgerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimedLedgerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.claimedLedgerDataGridView.Name = "claimedLedgerDataGridView";
            this.claimedLedgerDataGridView.RowHeadersWidth = 62;
            this.claimedLedgerDataGridView.Size = new System.Drawing.Size(1169, 588);
            this.claimedLedgerDataGridView.TabIndex = 1;
            // 
            // expiredLedgerTabPage
            // 
            this.expiredLedgerTabPage.Controls.Add(this.expiredLedgerDataGridView);
            this.expiredLedgerTabPage.Location = new System.Drawing.Point(4, 22);
            this.expiredLedgerTabPage.Name = "expiredLedgerTabPage";
            this.expiredLedgerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.expiredLedgerTabPage.Size = new System.Drawing.Size(1175, 594);
            this.expiredLedgerTabPage.TabIndex = 2;
            this.expiredLedgerTabPage.Text = "Expired Rewards";
            this.expiredLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // expiredLedgerDataGridView
            // 
            this.expiredLedgerDataGridView.AllowUserToAddRows = false;
            this.expiredLedgerDataGridView.AllowUserToOrderColumns = true;
            this.expiredLedgerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expiredLedgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expiredLedgerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expiredLedgerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.expiredLedgerDataGridView.Name = "expiredLedgerDataGridView";
            this.expiredLedgerDataGridView.RowHeadersWidth = 62;
            this.expiredLedgerDataGridView.Size = new System.Drawing.Size(1169, 588);
            this.expiredLedgerDataGridView.TabIndex = 1;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.Color.DimGray;
            this.settingsTabPage.Controls.Add(this.discordSettingsGroupBox);
            this.settingsTabPage.Controls.Add(this.nexusDatabaseSettingsGroupBox);
            this.settingsTabPage.Controls.Add(this.paymentsDatabaseSettingsGroupBox);
            this.settingsTabPage.Controls.Add(this.settingsSaveButton);
            this.settingsTabPage.Controls.Add(this.saveLocation);
            this.settingsTabPage.Controls.Add(this.configSaveLocation);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(1767, 898);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.Click += new System.EventHandler(this.settingsTabPage_Click);
            // 
            // discordSettingsGroupBox
            // 
            this.discordSettingsGroupBox.Controls.Add(this.discordAutoConnect);
            this.discordSettingsGroupBox.Controls.Add(this.discordTestMessageLabel);
            this.discordSettingsGroupBox.Controls.Add(this.discordChannelIDLabel);
            this.discordSettingsGroupBox.Controls.Add(this.discordBotTokenLabel);
            this.discordSettingsGroupBox.Controls.Add(this.discordMSGSend);
            this.discordSettingsGroupBox.Controls.Add(this.discordBotConnect);
            this.discordSettingsGroupBox.Controls.Add(this.discordTestMessage);
            this.discordSettingsGroupBox.Controls.Add(this.channelDiscordID);
            this.discordSettingsGroupBox.Controls.Add(this.discordToken);
            this.discordSettingsGroupBox.Location = new System.Drawing.Point(14, 43);
            this.discordSettingsGroupBox.Name = "discordSettingsGroupBox";
            this.discordSettingsGroupBox.Size = new System.Drawing.Size(663, 104);
            this.discordSettingsGroupBox.TabIndex = 18;
            this.discordSettingsGroupBox.TabStop = false;
            this.discordSettingsGroupBox.Text = "Discord Bot";
            // 
            // discordAutoConnect
            // 
            this.discordAutoConnect.AutoSize = true;
            this.discordAutoConnect.Location = new System.Drawing.Point(521, 15);
            this.discordAutoConnect.Margin = new System.Windows.Forms.Padding(2);
            this.discordAutoConnect.Name = "discordAutoConnect";
            this.discordAutoConnect.Size = new System.Drawing.Size(108, 17);
            this.discordAutoConnect.TabIndex = 18;
            this.discordAutoConnect.Text = "Connect On Start";
            this.discordAutoConnect.UseVisualStyleBackColor = true;
            // 
            // discordTestMessageLabel
            // 
            this.discordTestMessageLabel.AutoSize = true;
            this.discordTestMessageLabel.Location = new System.Drawing.Point(5, 70);
            this.discordTestMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordTestMessageLabel.Name = "discordTestMessageLabel";
            this.discordTestMessageLabel.Size = new System.Drawing.Size(74, 13);
            this.discordTestMessageLabel.TabIndex = 17;
            this.discordTestMessageLabel.Text = "Test Message";
            // 
            // discordChannelIDLabel
            // 
            this.discordChannelIDLabel.AutoSize = true;
            this.discordChannelIDLabel.Location = new System.Drawing.Point(5, 44);
            this.discordChannelIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordChannelIDLabel.Name = "discordChannelIDLabel";
            this.discordChannelIDLabel.Size = new System.Drawing.Size(99, 13);
            this.discordChannelIDLabel.TabIndex = 16;
            this.discordChannelIDLabel.Text = "Discord Channel ID";
            // 
            // discordBotTokenLabel
            // 
            this.discordBotTokenLabel.AutoSize = true;
            this.discordBotTokenLabel.Location = new System.Drawing.Point(5, 16);
            this.discordBotTokenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordBotTokenLabel.Name = "discordBotTokenLabel";
            this.discordBotTokenLabel.Size = new System.Drawing.Size(96, 13);
            this.discordBotTokenLabel.TabIndex = 15;
            this.discordBotTokenLabel.Text = "Discord Bot Token";
            // 
            // discordMSGSend
            // 
            this.discordMSGSend.Location = new System.Drawing.Point(414, 66);
            this.discordMSGSend.Margin = new System.Windows.Forms.Padding(2);
            this.discordMSGSend.Name = "discordMSGSend";
            this.discordMSGSend.Size = new System.Drawing.Size(74, 22);
            this.discordMSGSend.TabIndex = 14;
            this.discordMSGSend.Text = "Send";
            this.discordMSGSend.UseVisualStyleBackColor = true;
            this.discordMSGSend.Click += new System.EventHandler(this.discordMSGSend_Click);
            // 
            // discordBotConnect
            // 
            this.discordBotConnect.Location = new System.Drawing.Point(414, 12);
            this.discordBotConnect.Margin = new System.Windows.Forms.Padding(2);
            this.discordBotConnect.Name = "discordBotConnect";
            this.discordBotConnect.Size = new System.Drawing.Size(74, 22);
            this.discordBotConnect.TabIndex = 13;
            this.discordBotConnect.Text = "Connect";
            this.discordBotConnect.UseVisualStyleBackColor = true;
            this.discordBotConnect.Click += new System.EventHandler(this.discordBotConnect_Click);
            // 
            // discordTestMessage
            // 
            this.discordTestMessage.Location = new System.Drawing.Point(107, 68);
            this.discordTestMessage.Margin = new System.Windows.Forms.Padding(2);
            this.discordTestMessage.Name = "discordTestMessage";
            this.discordTestMessage.Size = new System.Drawing.Size(295, 20);
            this.discordTestMessage.TabIndex = 12;
            // 
            // channelDiscordID
            // 
            this.channelDiscordID.Location = new System.Drawing.Point(107, 42);
            this.channelDiscordID.Margin = new System.Windows.Forms.Padding(2);
            this.channelDiscordID.Name = "channelDiscordID";
            this.channelDiscordID.Size = new System.Drawing.Size(295, 20);
            this.channelDiscordID.TabIndex = 11;
            // 
            // discordToken
            // 
            this.discordToken.Location = new System.Drawing.Point(107, 14);
            this.discordToken.Margin = new System.Windows.Forms.Padding(2);
            this.discordToken.Name = "discordToken";
            this.discordToken.Size = new System.Drawing.Size(295, 20);
            this.discordToken.TabIndex = 9;
            this.discordToken.UseSystemPasswordChar = true;
            // 
            // nexusDatabaseSettingsGroupBox
            // 
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.Password);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.databasePortLabel);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.nexusDatabaseHost);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.nexusDatabaseHostLabel);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.nexusDatabasePort);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.databaseDatabaseLabel);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.nexusDatabaseUser);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.nexusDatabaseUsernameLabel);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.nexusDatabaseDatabase);
            this.nexusDatabaseSettingsGroupBox.Controls.Add(this.nexusDatabasePasswordLabel);
            this.nexusDatabaseSettingsGroupBox.Location = new System.Drawing.Point(14, 296);
            this.nexusDatabaseSettingsGroupBox.Name = "nexusDatabaseSettingsGroupBox";
            this.nexusDatabaseSettingsGroupBox.Size = new System.Drawing.Size(663, 137);
            this.nexusDatabaseSettingsGroupBox.TabIndex = 17;
            this.nexusDatabaseSettingsGroupBox.TabStop = false;
            this.nexusDatabaseSettingsGroupBox.Text = "Nexus Database";
            this.nexusDatabaseSettingsGroupBox.Visible = false;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(102, 97);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(203, 20);
            this.Password.TabIndex = 13;
            this.Password.Text = "ClusterPassword";
            this.Password.UseSystemPasswordChar = true;
            // 
            // databasePortLabel
            // 
            this.databasePortLabel.AutoSize = true;
            this.databasePortLabel.Location = new System.Drawing.Point(330, 26);
            this.databasePortLabel.Name = "databasePortLabel";
            this.databasePortLabel.Size = new System.Drawing.Size(29, 13);
            this.databasePortLabel.TabIndex = 12;
            this.databasePortLabel.Text = "Port:";
            // 
            // nexusDatabaseHost
            // 
            this.nexusDatabaseHost.Location = new System.Drawing.Point(102, 19);
            this.nexusDatabaseHost.Name = "nexusDatabaseHost";
            this.nexusDatabaseHost.Size = new System.Drawing.Size(203, 20);
            this.nexusDatabaseHost.TabIndex = 3;
            this.nexusDatabaseHost.Text = "localhost";
            // 
            // nexusDatabaseHostLabel
            // 
            this.nexusDatabaseHostLabel.AutoSize = true;
            this.nexusDatabaseHostLabel.Location = new System.Drawing.Point(22, 23);
            this.nexusDatabaseHostLabel.Name = "nexusDatabaseHostLabel";
            this.nexusDatabaseHostLabel.Size = new System.Drawing.Size(32, 13);
            this.nexusDatabaseHostLabel.TabIndex = 4;
            this.nexusDatabaseHostLabel.Text = "Host:";
            // 
            // nexusDatabasePort
            // 
            this.nexusDatabasePort.Location = new System.Drawing.Point(368, 20);
            this.nexusDatabasePort.Mask = "0000";
            this.nexusDatabasePort.Name = "nexusDatabasePort";
            this.nexusDatabasePort.Size = new System.Drawing.Size(88, 20);
            this.nexusDatabasePort.TabIndex = 11;
            this.nexusDatabasePort.Text = "5433";
            this.nexusDatabasePort.ValidatingType = typeof(int);
            // 
            // databaseDatabaseLabel
            // 
            this.databaseDatabaseLabel.AutoSize = true;
            this.databaseDatabaseLabel.Location = new System.Drawing.Point(22, 48);
            this.databaseDatabaseLabel.Name = "databaseDatabaseLabel";
            this.databaseDatabaseLabel.Size = new System.Drawing.Size(56, 13);
            this.databaseDatabaseLabel.TabIndex = 5;
            this.databaseDatabaseLabel.Text = "Database:";
            // 
            // nexusDatabaseUser
            // 
            this.nexusDatabaseUser.Location = new System.Drawing.Point(102, 71);
            this.nexusDatabaseUser.Name = "nexusDatabaseUser";
            this.nexusDatabaseUser.Size = new System.Drawing.Size(203, 20);
            this.nexusDatabaseUser.TabIndex = 9;
            this.nexusDatabaseUser.Text = "NexusUser";
            // 
            // nexusDatabaseUsernameLabel
            // 
            this.nexusDatabaseUsernameLabel.AutoSize = true;
            this.nexusDatabaseUsernameLabel.Location = new System.Drawing.Point(22, 74);
            this.nexusDatabaseUsernameLabel.Name = "nexusDatabaseUsernameLabel";
            this.nexusDatabaseUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.nexusDatabaseUsernameLabel.TabIndex = 6;
            this.nexusDatabaseUsernameLabel.Text = "Username:";
            // 
            // nexusDatabaseDatabase
            // 
            this.nexusDatabaseDatabase.Location = new System.Drawing.Point(102, 45);
            this.nexusDatabaseDatabase.Name = "nexusDatabaseDatabase";
            this.nexusDatabaseDatabase.Size = new System.Drawing.Size(203, 20);
            this.nexusDatabaseDatabase.TabIndex = 8;
            this.nexusDatabaseDatabase.Text = "NexusDatabase";
            // 
            // nexusDatabasePasswordLabel
            // 
            this.nexusDatabasePasswordLabel.AutoSize = true;
            this.nexusDatabasePasswordLabel.Location = new System.Drawing.Point(22, 104);
            this.nexusDatabasePasswordLabel.Name = "nexusDatabasePasswordLabel";
            this.nexusDatabasePasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.nexusDatabasePasswordLabel.TabIndex = 7;
            this.nexusDatabasePasswordLabel.Text = "Password:";
            // 
            // paymentsDatabaseSettingsGroupBox
            // 
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabasePassword);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabasePortLabel);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabaseHost);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabasePort);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabaseHostLabel);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabaseDatabaseLabel);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabaseUser);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabaseUsernameLabel);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabaseDatabase);
            this.paymentsDatabaseSettingsGroupBox.Controls.Add(this.paymentsDatabasePasswordLabel);
            this.paymentsDatabaseSettingsGroupBox.Location = new System.Drawing.Point(14, 153);
            this.paymentsDatabaseSettingsGroupBox.Name = "paymentsDatabaseSettingsGroupBox";
            this.paymentsDatabaseSettingsGroupBox.Size = new System.Drawing.Size(663, 137);
            this.paymentsDatabaseSettingsGroupBox.TabIndex = 16;
            this.paymentsDatabaseSettingsGroupBox.TabStop = false;
            this.paymentsDatabaseSettingsGroupBox.Text = "Payments Database";
            // 
            // paymentsDatabasePassword
            // 
            this.paymentsDatabasePassword.Location = new System.Drawing.Point(102, 97);
            this.paymentsDatabasePassword.Name = "paymentsDatabasePassword";
            this.paymentsDatabasePassword.Size = new System.Drawing.Size(203, 20);
            this.paymentsDatabasePassword.TabIndex = 15;
            this.paymentsDatabasePassword.Text = "paymentsPassword";
            this.paymentsDatabasePassword.UseSystemPasswordChar = true;
            // 
            // paymentsDatabasePortLabel
            // 
            this.paymentsDatabasePortLabel.AutoSize = true;
            this.paymentsDatabasePortLabel.Location = new System.Drawing.Point(330, 26);
            this.paymentsDatabasePortLabel.Name = "paymentsDatabasePortLabel";
            this.paymentsDatabasePortLabel.Size = new System.Drawing.Size(29, 13);
            this.paymentsDatabasePortLabel.TabIndex = 14;
            this.paymentsDatabasePortLabel.Text = "Port:";
            // 
            // paymentsDatabaseHost
            // 
            this.paymentsDatabaseHost.Location = new System.Drawing.Point(102, 19);
            this.paymentsDatabaseHost.Name = "paymentsDatabaseHost";
            this.paymentsDatabaseHost.Size = new System.Drawing.Size(203, 20);
            this.paymentsDatabaseHost.TabIndex = 3;
            this.paymentsDatabaseHost.Text = "localhost";
            // 
            // paymentsDatabasePort
            // 
            this.paymentsDatabasePort.Location = new System.Drawing.Point(368, 20);
            this.paymentsDatabasePort.Mask = "0000";
            this.paymentsDatabasePort.Name = "paymentsDatabasePort";
            this.paymentsDatabasePort.Size = new System.Drawing.Size(88, 20);
            this.paymentsDatabasePort.TabIndex = 13;
            this.paymentsDatabasePort.Text = "5433";
            this.paymentsDatabasePort.ValidatingType = typeof(int);
            // 
            // paymentsDatabaseHostLabel
            // 
            this.paymentsDatabaseHostLabel.AutoSize = true;
            this.paymentsDatabaseHostLabel.Location = new System.Drawing.Point(22, 23);
            this.paymentsDatabaseHostLabel.Name = "paymentsDatabaseHostLabel";
            this.paymentsDatabaseHostLabel.Size = new System.Drawing.Size(32, 13);
            this.paymentsDatabaseHostLabel.TabIndex = 4;
            this.paymentsDatabaseHostLabel.Text = "Host:";
            // 
            // paymentsDatabaseDatabaseLabel
            // 
            this.paymentsDatabaseDatabaseLabel.AutoSize = true;
            this.paymentsDatabaseDatabaseLabel.Location = new System.Drawing.Point(22, 48);
            this.paymentsDatabaseDatabaseLabel.Name = "paymentsDatabaseDatabaseLabel";
            this.paymentsDatabaseDatabaseLabel.Size = new System.Drawing.Size(56, 13);
            this.paymentsDatabaseDatabaseLabel.TabIndex = 5;
            this.paymentsDatabaseDatabaseLabel.Text = "Database:";
            // 
            // paymentsDatabaseUser
            // 
            this.paymentsDatabaseUser.Location = new System.Drawing.Point(102, 71);
            this.paymentsDatabaseUser.Name = "paymentsDatabaseUser";
            this.paymentsDatabaseUser.Size = new System.Drawing.Size(203, 20);
            this.paymentsDatabaseUser.TabIndex = 9;
            this.paymentsDatabaseUser.Text = "paymentsUser";
            // 
            // paymentsDatabaseUsernameLabel
            // 
            this.paymentsDatabaseUsernameLabel.AutoSize = true;
            this.paymentsDatabaseUsernameLabel.Location = new System.Drawing.Point(22, 74);
            this.paymentsDatabaseUsernameLabel.Name = "paymentsDatabaseUsernameLabel";
            this.paymentsDatabaseUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.paymentsDatabaseUsernameLabel.TabIndex = 6;
            this.paymentsDatabaseUsernameLabel.Text = "Username:";
            // 
            // paymentsDatabaseDatabase
            // 
            this.paymentsDatabaseDatabase.Location = new System.Drawing.Point(102, 45);
            this.paymentsDatabaseDatabase.Name = "paymentsDatabaseDatabase";
            this.paymentsDatabaseDatabase.Size = new System.Drawing.Size(203, 20);
            this.paymentsDatabaseDatabase.TabIndex = 8;
            this.paymentsDatabaseDatabase.Text = "PaymentsDatabase";
            // 
            // paymentsDatabasePasswordLabel
            // 
            this.paymentsDatabasePasswordLabel.AutoSize = true;
            this.paymentsDatabasePasswordLabel.Location = new System.Drawing.Point(22, 104);
            this.paymentsDatabasePasswordLabel.Name = "paymentsDatabasePasswordLabel";
            this.paymentsDatabasePasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.paymentsDatabasePasswordLabel.TabIndex = 7;
            this.paymentsDatabasePasswordLabel.Text = "Password:";
            // 
            // settingsSaveButton
            // 
            this.settingsSaveButton.AutoSize = true;
            this.settingsSaveButton.Location = new System.Drawing.Point(588, 438);
            this.settingsSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Size = new System.Drawing.Size(89, 30);
            this.settingsSaveButton.TabIndex = 2;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
            this.settingsSaveButton.Click += new System.EventHandler(this.configSaveButton_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(109, 18);
            this.saveLocation.Margin = new System.Windows.Forms.Padding(2);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(644, 20);
            this.saveLocation.TabIndex = 1;
            // 
            // configSaveLocation
            // 
            this.configSaveLocation.Location = new System.Drawing.Point(14, 13);
            this.configSaveLocation.Margin = new System.Windows.Forms.Padding(2);
            this.configSaveLocation.Name = "configSaveLocation";
            this.configSaveLocation.Size = new System.Drawing.Size(91, 26);
            this.configSaveLocation.TabIndex = 0;
            this.configSaveLocation.Text = "Save Location";
            this.configSaveLocation.UseVisualStyleBackColor = true;
            this.configSaveLocation.Click += new System.EventHandler(this.button3_Click);
            // 
            // droleupdate
            // 
            this.droleupdate.Interval = 120000;
            this.droleupdate.Tick += new System.EventHandler(this.droleupdate_Tick);
            // 
            // clearRewardLedgerButton
            // 
            this.clearRewardLedgerButton.Location = new System.Drawing.Point(1005, 733);
            this.clearRewardLedgerButton.Name = "clearRewardLedgerButton";
            this.clearRewardLedgerButton.Size = new System.Drawing.Size(186, 41);
            this.clearRewardLedgerButton.TabIndex = 2;
            this.clearRewardLedgerButton.Text = "Clear All Rewards";
            this.clearRewardLedgerButton.UseVisualStyleBackColor = true;
            this.clearRewardLedgerButton.Click += new System.EventHandler(this.clearRewardLedgerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1775, 924);
            this.Controls.Add(this.mainTabControl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.rewardsTabPage.ResumeLayout(false);
            this.rewardsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsGridView)).EndInit();
            this.playersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerGridView)).EndInit();
            this.ledgerTabPage.ResumeLayout(false);
            this.ledgerTabControl.ResumeLayout(false);
            this.unclaimedLedgerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unclaimedLedgerGridView)).EndInit();
            this.claimedLedgerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimedLedgerDataGridView)).EndInit();
            this.expiredLedgerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expiredLedgerDataGridView)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.discordSettingsGroupBox.ResumeLayout(false);
            this.discordSettingsGroupBox.PerformLayout();
            this.nexusDatabaseSettingsGroupBox.ResumeLayout(false);
            this.nexusDatabaseSettingsGroupBox.PerformLayout();
            this.paymentsDatabaseSettingsGroupBox.ResumeLayout(false);
            this.paymentsDatabaseSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage rewardsTabPage;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.TabPage ledgerTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button configSaveLocation;
        private System.Windows.Forms.Button rewardsSaveButton;
        private System.Windows.Forms.Button settingsSaveButton;
        private System.Windows.Forms.Label discordRolesLabel;
        private System.Windows.Forms.DataGridView unclaimedLedgerGridView;
        private System.Windows.Forms.DataGridView playerGridView;
        private System.Windows.Forms.DataGridView rewardsGridView;
        private System.Windows.Forms.CheckedListBox discordroleslist;
        private System.Windows.Forms.Timer droleupdate;
        private System.Windows.Forms.TabControl ledgerTabControl;
        private System.Windows.Forms.TabPage unclaimedLedgerTabPage;
        private System.Windows.Forms.TabPage claimedLedgerTabPage;
        private System.Windows.Forms.DataGridView claimedLedgerDataGridView;
        private System.Windows.Forms.TabPage expiredLedgerTabPage;
        private System.Windows.Forms.DataGridView expiredLedgerDataGridView;
        private System.Windows.Forms.GroupBox nexusDatabaseSettingsGroupBox;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label databasePortLabel;
        private System.Windows.Forms.TextBox nexusDatabaseHost;
        private System.Windows.Forms.Label nexusDatabaseHostLabel;
        private System.Windows.Forms.MaskedTextBox nexusDatabasePort;
        private System.Windows.Forms.Label databaseDatabaseLabel;
        private System.Windows.Forms.TextBox nexusDatabaseUser;
        private System.Windows.Forms.Label nexusDatabaseUsernameLabel;
        private System.Windows.Forms.TextBox nexusDatabaseDatabase;
        private System.Windows.Forms.Label nexusDatabasePasswordLabel;
        private System.Windows.Forms.GroupBox paymentsDatabaseSettingsGroupBox;
        private System.Windows.Forms.TextBox paymentsDatabasePassword;
        private System.Windows.Forms.Label paymentsDatabasePortLabel;
        private System.Windows.Forms.TextBox paymentsDatabaseHost;
        private System.Windows.Forms.MaskedTextBox paymentsDatabasePort;
        private System.Windows.Forms.Label paymentsDatabaseHostLabel;
        private System.Windows.Forms.Label paymentsDatabaseDatabaseLabel;
        private System.Windows.Forms.TextBox paymentsDatabaseUser;
        private System.Windows.Forms.Label paymentsDatabaseUsernameLabel;
        private System.Windows.Forms.TextBox paymentsDatabaseDatabase;
        private System.Windows.Forms.Label paymentsDatabasePasswordLabel;
        private System.Windows.Forms.GroupBox discordSettingsGroupBox;
        private System.Windows.Forms.CheckBox discordAutoConnect;
        private System.Windows.Forms.Label discordTestMessageLabel;
        private System.Windows.Forms.Label discordChannelIDLabel;
        private System.Windows.Forms.Label discordBotTokenLabel;
        private System.Windows.Forms.Button discordMSGSend;
        private System.Windows.Forms.Button discordBotConnect;
        private System.Windows.Forms.TextBox discordTestMessage;
        private System.Windows.Forms.TextBox channelDiscordID;
        private System.Windows.Forms.TextBox discordToken;
        private System.Windows.Forms.Button generateCurrentLedgerButton;
        private System.Windows.Forms.Button clearRewardLedgerButton;
    }
}

