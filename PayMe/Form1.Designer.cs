namespace PayMe
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
            this.discordRolesLabel = new System.Windows.Forms.Label();
            this.discordroleslist = new System.Windows.Forms.CheckedListBox();
            this.rewardsGridView = new System.Windows.Forms.DataGridView();
            this.rewardsSaveButton = new System.Windows.Forms.Button();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.playerGridView = new System.Windows.Forms.DataGridView();
            this.ledgerTabPage = new System.Windows.Forms.TabPage();
            this.ledgerTabControl = new System.Windows.Forms.TabControl();
            this.pendingLedgerTabPage = new System.Windows.Forms.TabPage();
            this.pendingLedgerGridView = new System.Windows.Forms.DataGridView();
            this.paidLedgerTabPage = new System.Windows.Forms.TabPage();
            this.paidLedgerDataGridView = new System.Windows.Forms.DataGridView();
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
            this.mainTabControl.SuspendLayout();
            this.rewardsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsGridView)).BeginInit();
            this.playersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerGridView)).BeginInit();
            this.ledgerTabPage.SuspendLayout();
            this.ledgerTabControl.SuspendLayout();
            this.pendingLedgerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendingLedgerGridView)).BeginInit();
            this.paidLedgerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paidLedgerDataGridView)).BeginInit();
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
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(2662, 1422);
            this.mainTabControl.TabIndex = 0;
            // 
            // rewardsTabPage
            // 
            this.rewardsTabPage.BackColor = System.Drawing.Color.DimGray;
            this.rewardsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rewardsTabPage.Controls.Add(this.discordRolesLabel);
            this.rewardsTabPage.Controls.Add(this.discordroleslist);
            this.rewardsTabPage.Controls.Add(this.rewardsGridView);
            this.rewardsTabPage.Controls.Add(this.rewardsSaveButton);
            this.rewardsTabPage.Location = new System.Drawing.Point(4, 29);
            this.rewardsTabPage.Name = "rewardsTabPage";
            this.rewardsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.rewardsTabPage.Size = new System.Drawing.Size(2654, 1389);
            this.rewardsTabPage.TabIndex = 0;
            this.rewardsTabPage.Text = "Rewards";
            this.rewardsTabPage.Click += new System.EventHandler(this.rewardsSaveButton_click);
            // 
            // discordRolesLabel
            // 
            this.discordRolesLabel.AutoSize = true;
            this.discordRolesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordRolesLabel.Location = new System.Drawing.Point(1594, 76);
            this.discordRolesLabel.Name = "discordRolesLabel";
            this.discordRolesLabel.Size = new System.Drawing.Size(145, 25);
            this.discordRolesLabel.TabIndex = 4;
            this.discordRolesLabel.Text = "Discord Roles";
            // 
            // discordroleslist
            // 
            this.discordroleslist.FormattingEnabled = true;
            this.discordroleslist.Location = new System.Drawing.Point(1599, 104);
            this.discordroleslist.Name = "discordroleslist";
            this.discordroleslist.Size = new System.Drawing.Size(332, 625);
            this.discordroleslist.TabIndex = 3;
            this.discordroleslist.SelectedIndexChanged += new System.EventHandler(this.discordroleslist_SelectedIndexChanged);
            // 
            // rewardsGridView
            // 
            this.rewardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rewardsGridView.Location = new System.Drawing.Point(10, 32);
            this.rewardsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rewardsGridView.Name = "rewardsGridView";
            this.rewardsGridView.RowHeadersWidth = 62;
            this.rewardsGridView.Size = new System.Drawing.Size(1582, 697);
            this.rewardsGridView.TabIndex = 3;
            this.rewardsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rewardsGridView_CellContentClick);
            this.rewardsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rewardsGridView_CellContentClick);
            this.rewardsGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.rewardsRowAdded);
            this.rewardsGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.rewardsRowRemoved);
            // 
            // rewardsSaveButton
            // 
            this.rewardsSaveButton.AutoSize = true;
            this.rewardsSaveButton.Location = new System.Drawing.Point(8, 760);
            this.rewardsSaveButton.Name = "rewardsSaveButton";
            this.rewardsSaveButton.Size = new System.Drawing.Size(134, 46);
            this.rewardsSaveButton.TabIndex = 2;
            this.rewardsSaveButton.Text = "Save";
            this.rewardsSaveButton.UseVisualStyleBackColor = true;
            this.rewardsSaveButton.Click += new System.EventHandler(this.rewardsSaveButton_click);
            // 
            // playersTabPage
            // 
            this.playersTabPage.BackColor = System.Drawing.Color.DimGray;
            this.playersTabPage.Controls.Add(this.playerGridView);
            this.playersTabPage.Location = new System.Drawing.Point(4, 29);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.playersTabPage.Size = new System.Drawing.Size(2654, 1389);
            this.playersTabPage.TabIndex = 1;
            this.playersTabPage.Text = "Users";
            // 
            // playerGridView
            // 
            this.playerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGridView.Location = new System.Drawing.Point(48, 57);
            this.playerGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerGridView.Name = "playerGridView";
            this.playerGridView.RowHeadersWidth = 62;
            this.playerGridView.Size = new System.Drawing.Size(1347, 863);
            this.playerGridView.TabIndex = 0;
            // 
            // ledgerTabPage
            // 
            this.ledgerTabPage.BackColor = System.Drawing.Color.DimGray;
            this.ledgerTabPage.Controls.Add(this.ledgerTabControl);
            this.ledgerTabPage.Location = new System.Drawing.Point(4, 29);
            this.ledgerTabPage.Name = "ledgerTabPage";
            this.ledgerTabPage.Size = new System.Drawing.Size(2654, 1389);
            this.ledgerTabPage.TabIndex = 2;
            this.ledgerTabPage.Text = "Ledger";
            // 
            // ledgerTabControl
            // 
            this.ledgerTabControl.Controls.Add(this.pendingLedgerTabPage);
            this.ledgerTabControl.Controls.Add(this.paidLedgerTabPage);
            this.ledgerTabControl.Controls.Add(this.expiredLedgerTabPage);
            this.ledgerTabControl.Location = new System.Drawing.Point(0, 0);
            this.ledgerTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ledgerTabControl.Name = "ledgerTabControl";
            this.ledgerTabControl.SelectedIndex = 0;
            this.ledgerTabControl.Size = new System.Drawing.Size(1774, 954);
            this.ledgerTabControl.TabIndex = 1;
            // 
            // pendingLedgerTabPage
            // 
            this.pendingLedgerTabPage.Controls.Add(this.pendingLedgerGridView);
            this.pendingLedgerTabPage.Location = new System.Drawing.Point(4, 29);
            this.pendingLedgerTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pendingLedgerTabPage.Name = "pendingLedgerTabPage";
            this.pendingLedgerTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pendingLedgerTabPage.Size = new System.Drawing.Size(1766, 921);
            this.pendingLedgerTabPage.TabIndex = 0;
            this.pendingLedgerTabPage.Text = "Pending Payments";
            this.pendingLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // pendingLedgerGridView
            // 
            this.pendingLedgerGridView.AllowUserToAddRows = false;
            this.pendingLedgerGridView.AllowUserToOrderColumns = true;
            this.pendingLedgerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingLedgerGridView.Location = new System.Drawing.Point(0, 0);
            this.pendingLedgerGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pendingLedgerGridView.Name = "pendingLedgerGridView";
            this.pendingLedgerGridView.RowHeadersWidth = 62;
            this.pendingLedgerGridView.Size = new System.Drawing.Size(1762, 914);
            this.pendingLedgerGridView.TabIndex = 0;
            // 
            // paidLedgerTabPage
            // 
            this.paidLedgerTabPage.Controls.Add(this.paidLedgerDataGridView);
            this.paidLedgerTabPage.Location = new System.Drawing.Point(4, 29);
            this.paidLedgerTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paidLedgerTabPage.Name = "paidLedgerTabPage";
            this.paidLedgerTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paidLedgerTabPage.Size = new System.Drawing.Size(1766, 921);
            this.paidLedgerTabPage.TabIndex = 1;
            this.paidLedgerTabPage.Text = "Paid Payments";
            this.paidLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // paidLedgerDataGridView
            // 
            this.paidLedgerDataGridView.AllowUserToAddRows = false;
            this.paidLedgerDataGridView.AllowUserToOrderColumns = true;
            this.paidLedgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paidLedgerDataGridView.Location = new System.Drawing.Point(108, 117);
            this.paidLedgerDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paidLedgerDataGridView.Name = "paidLedgerDataGridView";
            this.paidLedgerDataGridView.RowHeadersWidth = 62;
            this.paidLedgerDataGridView.Size = new System.Drawing.Size(1545, 680);
            this.paidLedgerDataGridView.TabIndex = 1;
            // 
            // expiredLedgerTabPage
            // 
            this.expiredLedgerTabPage.Controls.Add(this.expiredLedgerDataGridView);
            this.expiredLedgerTabPage.Location = new System.Drawing.Point(4, 29);
            this.expiredLedgerTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expiredLedgerTabPage.Name = "expiredLedgerTabPage";
            this.expiredLedgerTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expiredLedgerTabPage.Size = new System.Drawing.Size(1766, 921);
            this.expiredLedgerTabPage.TabIndex = 2;
            this.expiredLedgerTabPage.Text = "Expired Payments";
            this.expiredLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // expiredLedgerDataGridView
            // 
            this.expiredLedgerDataGridView.AllowUserToAddRows = false;
            this.expiredLedgerDataGridView.AllowUserToOrderColumns = true;
            this.expiredLedgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expiredLedgerDataGridView.Location = new System.Drawing.Point(108, 117);
            this.expiredLedgerDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expiredLedgerDataGridView.Name = "expiredLedgerDataGridView";
            this.expiredLedgerDataGridView.RowHeadersWidth = 62;
            this.expiredLedgerDataGridView.Size = new System.Drawing.Size(1545, 680);
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
            this.settingsTabPage.Location = new System.Drawing.Point(4, 29);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(2654, 1389);
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
            this.discordSettingsGroupBox.Location = new System.Drawing.Point(21, 66);
            this.discordSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discordSettingsGroupBox.Name = "discordSettingsGroupBox";
            this.discordSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discordSettingsGroupBox.Size = new System.Drawing.Size(994, 160);
            this.discordSettingsGroupBox.TabIndex = 18;
            this.discordSettingsGroupBox.TabStop = false;
            this.discordSettingsGroupBox.Text = "Discord Bot";
            // 
            // discordAutoConnect
            // 
            this.discordAutoConnect.AutoSize = true;
            this.discordAutoConnect.Location = new System.Drawing.Point(782, 23);
            this.discordAutoConnect.Name = "discordAutoConnect";
            this.discordAutoConnect.Size = new System.Drawing.Size(159, 24);
            this.discordAutoConnect.TabIndex = 18;
            this.discordAutoConnect.Text = "Connect On Start";
            this.discordAutoConnect.UseVisualStyleBackColor = true;
            // 
            // discordTestMessageLabel
            // 
            this.discordTestMessageLabel.AutoSize = true;
            this.discordTestMessageLabel.Location = new System.Drawing.Point(8, 108);
            this.discordTestMessageLabel.Name = "discordTestMessageLabel";
            this.discordTestMessageLabel.Size = new System.Drawing.Size(109, 20);
            this.discordTestMessageLabel.TabIndex = 17;
            this.discordTestMessageLabel.Text = "Test Message";
            // 
            // discordChannelIDLabel
            // 
            this.discordChannelIDLabel.AutoSize = true;
            this.discordChannelIDLabel.Location = new System.Drawing.Point(8, 68);
            this.discordChannelIDLabel.Name = "discordChannelIDLabel";
            this.discordChannelIDLabel.Size = new System.Drawing.Size(147, 20);
            this.discordChannelIDLabel.TabIndex = 16;
            this.discordChannelIDLabel.Text = "Discord Channel ID";
            // 
            // discordBotTokenLabel
            // 
            this.discordBotTokenLabel.AutoSize = true;
            this.discordBotTokenLabel.Location = new System.Drawing.Point(8, 25);
            this.discordBotTokenLabel.Name = "discordBotTokenLabel";
            this.discordBotTokenLabel.Size = new System.Drawing.Size(140, 20);
            this.discordBotTokenLabel.TabIndex = 15;
            this.discordBotTokenLabel.Text = "Discord Bot Token";
            // 
            // discordMSGSend
            // 
            this.discordMSGSend.Location = new System.Drawing.Point(621, 102);
            this.discordMSGSend.Name = "discordMSGSend";
            this.discordMSGSend.Size = new System.Drawing.Size(111, 34);
            this.discordMSGSend.TabIndex = 14;
            this.discordMSGSend.Text = "Send";
            this.discordMSGSend.UseVisualStyleBackColor = true;
            this.discordMSGSend.Click += new System.EventHandler(this.discordMSGSend_Click);
            // 
            // discordBotConnect
            // 
            this.discordBotConnect.Location = new System.Drawing.Point(621, 18);
            this.discordBotConnect.Name = "discordBotConnect";
            this.discordBotConnect.Size = new System.Drawing.Size(111, 34);
            this.discordBotConnect.TabIndex = 13;
            this.discordBotConnect.Text = "Connect";
            this.discordBotConnect.UseVisualStyleBackColor = true;
            this.discordBotConnect.Click += new System.EventHandler(this.discordBotConnect_Click);
            // 
            // discordTestMessage
            // 
            this.discordTestMessage.Location = new System.Drawing.Point(160, 105);
            this.discordTestMessage.Name = "discordTestMessage";
            this.discordTestMessage.Size = new System.Drawing.Size(440, 26);
            this.discordTestMessage.TabIndex = 12;
            // 
            // channelDiscordID
            // 
            this.channelDiscordID.Location = new System.Drawing.Point(160, 65);
            this.channelDiscordID.Name = "channelDiscordID";
            this.channelDiscordID.Size = new System.Drawing.Size(440, 26);
            this.channelDiscordID.TabIndex = 11;
            // 
            // discordToken
            // 
            this.discordToken.Location = new System.Drawing.Point(160, 22);
            this.discordToken.Name = "discordToken";
            this.discordToken.Size = new System.Drawing.Size(440, 26);
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
            this.nexusDatabaseSettingsGroupBox.Location = new System.Drawing.Point(21, 455);
            this.nexusDatabaseSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nexusDatabaseSettingsGroupBox.Name = "nexusDatabaseSettingsGroupBox";
            this.nexusDatabaseSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nexusDatabaseSettingsGroupBox.Size = new System.Drawing.Size(994, 211);
            this.nexusDatabaseSettingsGroupBox.TabIndex = 17;
            this.nexusDatabaseSettingsGroupBox.TabStop = false;
            this.nexusDatabaseSettingsGroupBox.Text = "Nexus Database";
            this.nexusDatabaseSettingsGroupBox.Visible = false;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(153, 149);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(302, 26);
            this.Password.TabIndex = 13;
            this.Password.Text = "ClusterPassword";
            this.Password.UseSystemPasswordChar = true;
            // 
            // databasePortLabel
            // 
            this.databasePortLabel.AutoSize = true;
            this.databasePortLabel.Location = new System.Drawing.Point(495, 40);
            this.databasePortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databasePortLabel.Name = "databasePortLabel";
            this.databasePortLabel.Size = new System.Drawing.Size(42, 20);
            this.databasePortLabel.TabIndex = 12;
            this.databasePortLabel.Text = "Port:";
            // 
            // nexusDatabaseHost
            // 
            this.nexusDatabaseHost.Location = new System.Drawing.Point(153, 29);
            this.nexusDatabaseHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nexusDatabaseHost.Name = "nexusDatabaseHost";
            this.nexusDatabaseHost.Size = new System.Drawing.Size(302, 26);
            this.nexusDatabaseHost.TabIndex = 3;
            this.nexusDatabaseHost.Text = "localhost";
            // 
            // nexusDatabaseHostLabel
            // 
            this.nexusDatabaseHostLabel.AutoSize = true;
            this.nexusDatabaseHostLabel.Location = new System.Drawing.Point(33, 35);
            this.nexusDatabaseHostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nexusDatabaseHostLabel.Name = "nexusDatabaseHostLabel";
            this.nexusDatabaseHostLabel.Size = new System.Drawing.Size(47, 20);
            this.nexusDatabaseHostLabel.TabIndex = 4;
            this.nexusDatabaseHostLabel.Text = "Host:";
            // 
            // nexusDatabasePort
            // 
            this.nexusDatabasePort.Location = new System.Drawing.Point(552, 31);
            this.nexusDatabasePort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nexusDatabasePort.Mask = "0000";
            this.nexusDatabasePort.Name = "nexusDatabasePort";
            this.nexusDatabasePort.Size = new System.Drawing.Size(130, 26);
            this.nexusDatabasePort.TabIndex = 11;
            this.nexusDatabasePort.Text = "5433";
            this.nexusDatabasePort.ValidatingType = typeof(int);
            // 
            // databaseDatabaseLabel
            // 
            this.databaseDatabaseLabel.AutoSize = true;
            this.databaseDatabaseLabel.Location = new System.Drawing.Point(33, 74);
            this.databaseDatabaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databaseDatabaseLabel.Name = "databaseDatabaseLabel";
            this.databaseDatabaseLabel.Size = new System.Drawing.Size(83, 20);
            this.databaseDatabaseLabel.TabIndex = 5;
            this.databaseDatabaseLabel.Text = "Database:";
            // 
            // nexusDatabaseUser
            // 
            this.nexusDatabaseUser.Location = new System.Drawing.Point(153, 109);
            this.nexusDatabaseUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nexusDatabaseUser.Name = "nexusDatabaseUser";
            this.nexusDatabaseUser.Size = new System.Drawing.Size(302, 26);
            this.nexusDatabaseUser.TabIndex = 9;
            this.nexusDatabaseUser.Text = "NexusUser";
            // 
            // nexusDatabaseUsernameLabel
            // 
            this.nexusDatabaseUsernameLabel.AutoSize = true;
            this.nexusDatabaseUsernameLabel.Location = new System.Drawing.Point(33, 114);
            this.nexusDatabaseUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nexusDatabaseUsernameLabel.Name = "nexusDatabaseUsernameLabel";
            this.nexusDatabaseUsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.nexusDatabaseUsernameLabel.TabIndex = 6;
            this.nexusDatabaseUsernameLabel.Text = "Username:";
            // 
            // nexusDatabaseDatabase
            // 
            this.nexusDatabaseDatabase.Location = new System.Drawing.Point(153, 69);
            this.nexusDatabaseDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nexusDatabaseDatabase.Name = "nexusDatabaseDatabase";
            this.nexusDatabaseDatabase.Size = new System.Drawing.Size(302, 26);
            this.nexusDatabaseDatabase.TabIndex = 8;
            this.nexusDatabaseDatabase.Text = "NexusDatabase";
            // 
            // nexusDatabasePasswordLabel
            // 
            this.nexusDatabasePasswordLabel.AutoSize = true;
            this.nexusDatabasePasswordLabel.Location = new System.Drawing.Point(33, 160);
            this.nexusDatabasePasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nexusDatabasePasswordLabel.Name = "nexusDatabasePasswordLabel";
            this.nexusDatabasePasswordLabel.Size = new System.Drawing.Size(82, 20);
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
            this.paymentsDatabaseSettingsGroupBox.Location = new System.Drawing.Point(21, 235);
            this.paymentsDatabaseSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsDatabaseSettingsGroupBox.Name = "paymentsDatabaseSettingsGroupBox";
            this.paymentsDatabaseSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsDatabaseSettingsGroupBox.Size = new System.Drawing.Size(994, 211);
            this.paymentsDatabaseSettingsGroupBox.TabIndex = 16;
            this.paymentsDatabaseSettingsGroupBox.TabStop = false;
            this.paymentsDatabaseSettingsGroupBox.Text = "Payments Database";
            // 
            // paymentsDatabasePassword
            // 
            this.paymentsDatabasePassword.Location = new System.Drawing.Point(153, 149);
            this.paymentsDatabasePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsDatabasePassword.Name = "paymentsDatabasePassword";
            this.paymentsDatabasePassword.Size = new System.Drawing.Size(302, 26);
            this.paymentsDatabasePassword.TabIndex = 15;
            this.paymentsDatabasePassword.Text = "paymentsPassword";
            this.paymentsDatabasePassword.UseSystemPasswordChar = true;
            // 
            // paymentsDatabasePortLabel
            // 
            this.paymentsDatabasePortLabel.AutoSize = true;
            this.paymentsDatabasePortLabel.Location = new System.Drawing.Point(495, 40);
            this.paymentsDatabasePortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsDatabasePortLabel.Name = "paymentsDatabasePortLabel";
            this.paymentsDatabasePortLabel.Size = new System.Drawing.Size(42, 20);
            this.paymentsDatabasePortLabel.TabIndex = 14;
            this.paymentsDatabasePortLabel.Text = "Port:";
            // 
            // paymentsDatabaseHost
            // 
            this.paymentsDatabaseHost.Location = new System.Drawing.Point(153, 29);
            this.paymentsDatabaseHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsDatabaseHost.Name = "paymentsDatabaseHost";
            this.paymentsDatabaseHost.Size = new System.Drawing.Size(302, 26);
            this.paymentsDatabaseHost.TabIndex = 3;
            this.paymentsDatabaseHost.Text = "localhost";
            // 
            // paymentsDatabasePort
            // 
            this.paymentsDatabasePort.Location = new System.Drawing.Point(552, 31);
            this.paymentsDatabasePort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsDatabasePort.Mask = "0000";
            this.paymentsDatabasePort.Name = "paymentsDatabasePort";
            this.paymentsDatabasePort.Size = new System.Drawing.Size(130, 26);
            this.paymentsDatabasePort.TabIndex = 13;
            this.paymentsDatabasePort.Text = "5433";
            this.paymentsDatabasePort.ValidatingType = typeof(int);
            // 
            // paymentsDatabaseHostLabel
            // 
            this.paymentsDatabaseHostLabel.AutoSize = true;
            this.paymentsDatabaseHostLabel.Location = new System.Drawing.Point(33, 35);
            this.paymentsDatabaseHostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsDatabaseHostLabel.Name = "paymentsDatabaseHostLabel";
            this.paymentsDatabaseHostLabel.Size = new System.Drawing.Size(47, 20);
            this.paymentsDatabaseHostLabel.TabIndex = 4;
            this.paymentsDatabaseHostLabel.Text = "Host:";
            // 
            // paymentsDatabaseDatabaseLabel
            // 
            this.paymentsDatabaseDatabaseLabel.AutoSize = true;
            this.paymentsDatabaseDatabaseLabel.Location = new System.Drawing.Point(33, 74);
            this.paymentsDatabaseDatabaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsDatabaseDatabaseLabel.Name = "paymentsDatabaseDatabaseLabel";
            this.paymentsDatabaseDatabaseLabel.Size = new System.Drawing.Size(83, 20);
            this.paymentsDatabaseDatabaseLabel.TabIndex = 5;
            this.paymentsDatabaseDatabaseLabel.Text = "Database:";
            // 
            // paymentsDatabaseUser
            // 
            this.paymentsDatabaseUser.Location = new System.Drawing.Point(153, 109);
            this.paymentsDatabaseUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsDatabaseUser.Name = "paymentsDatabaseUser";
            this.paymentsDatabaseUser.Size = new System.Drawing.Size(302, 26);
            this.paymentsDatabaseUser.TabIndex = 9;
            this.paymentsDatabaseUser.Text = "paymentsUser";
            // 
            // paymentsDatabaseUsernameLabel
            // 
            this.paymentsDatabaseUsernameLabel.AutoSize = true;
            this.paymentsDatabaseUsernameLabel.Location = new System.Drawing.Point(33, 114);
            this.paymentsDatabaseUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsDatabaseUsernameLabel.Name = "paymentsDatabaseUsernameLabel";
            this.paymentsDatabaseUsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.paymentsDatabaseUsernameLabel.TabIndex = 6;
            this.paymentsDatabaseUsernameLabel.Text = "Username:";
            // 
            // paymentsDatabaseDatabase
            // 
            this.paymentsDatabaseDatabase.Location = new System.Drawing.Point(153, 69);
            this.paymentsDatabaseDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsDatabaseDatabase.Name = "paymentsDatabaseDatabase";
            this.paymentsDatabaseDatabase.Size = new System.Drawing.Size(302, 26);
            this.paymentsDatabaseDatabase.TabIndex = 8;
            this.paymentsDatabaseDatabase.Text = "PaymentsDatabase";
            // 
            // paymentsDatabasePasswordLabel
            // 
            this.paymentsDatabasePasswordLabel.AutoSize = true;
            this.paymentsDatabasePasswordLabel.Location = new System.Drawing.Point(33, 160);
            this.paymentsDatabasePasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsDatabasePasswordLabel.Name = "paymentsDatabasePasswordLabel";
            this.paymentsDatabasePasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.paymentsDatabasePasswordLabel.TabIndex = 7;
            this.paymentsDatabasePasswordLabel.Text = "Password:";
            // 
            // settingsSaveButton
            // 
            this.settingsSaveButton.AutoSize = true;
            this.settingsSaveButton.Location = new System.Drawing.Point(882, 674);
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Size = new System.Drawing.Size(134, 46);
            this.settingsSaveButton.TabIndex = 2;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
            this.settingsSaveButton.Click += new System.EventHandler(this.configSaveButton_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(164, 28);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(964, 26);
            this.saveLocation.TabIndex = 1;
            // 
            // configSaveLocation
            // 
            this.configSaveLocation.Location = new System.Drawing.Point(21, 20);
            this.configSaveLocation.Name = "configSaveLocation";
            this.configSaveLocation.Size = new System.Drawing.Size(136, 40);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2662, 1422);
            this.Controls.Add(this.mainTabControl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.pendingLedgerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pendingLedgerGridView)).EndInit();
            this.paidLedgerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paidLedgerDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView pendingLedgerGridView;
        private System.Windows.Forms.DataGridView playerGridView;
        private System.Windows.Forms.DataGridView rewardsGridView;
        private System.Windows.Forms.CheckedListBox discordroleslist;
        private System.Windows.Forms.Timer droleupdate;
        private System.Windows.Forms.TabControl ledgerTabControl;
        private System.Windows.Forms.TabPage pendingLedgerTabPage;
        private System.Windows.Forms.TabPage paidLedgerTabPage;
        private System.Windows.Forms.DataGridView paidLedgerDataGridView;
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
    }
}

