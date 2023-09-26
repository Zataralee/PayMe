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
            this.ledgerTabPage = new System.Windows.Forms.TabPage();
            this.ledgerTabControl = new System.Windows.Forms.TabControl();
            this.pendingLedgerTabPage = new System.Windows.Forms.TabPage();
            this.pendingLedgerGridView = new System.Windows.Forms.DataGridView();
            this.paidLedgerTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.settingsSaveButton = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.configSaveLocation = new System.Windows.Forms.Button();
            this.sqlTabPage = new System.Windows.Forms.TabPage();
            this.nexusGroupBox = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.databasePortLabel = new System.Windows.Forms.Label();
            this.nexusDatabaseHost = new System.Windows.Forms.TextBox();
            this.databaseHostLabel = new System.Windows.Forms.Label();
            this.nexusDatabasePort = new System.Windows.Forms.MaskedTextBox();
            this.databaseDatabaseLabel = new System.Windows.Forms.Label();
            this.nexusDatabaseUser = new System.Windows.Forms.TextBox();
            this.databaseUsernameLabel = new System.Windows.Forms.Label();
            this.nexusDatabaseDatabase = new System.Windows.Forms.TextBox();
            this.databasePasswordLabel = new System.Windows.Forms.Label();
            this.paymentsGroupBox = new System.Windows.Forms.GroupBox();
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
            this.sqlConfigSaveButton = new System.Windows.Forms.Button();
            this.discordTabPage = new System.Windows.Forms.TabPage();
            this.discordAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.discordTestMessageLabel = new System.Windows.Forms.Label();
            this.discordChannelIDLabel = new System.Windows.Forms.Label();
            this.discordBotTokenLabel = new System.Windows.Forms.Label();
            this.discordMSGSend = new System.Windows.Forms.Button();
            this.discordBotConnect = new System.Windows.Forms.Button();
            this.discordTestMessage = new System.Windows.Forms.TextBox();
            this.channelDiscordID = new System.Windows.Forms.TextBox();
            this.discordToken = new System.Windows.Forms.TextBox();
            this.playerGridView = new System.Windows.Forms.DataGridView();
            this.droleupdate = new System.Windows.Forms.Timer(this.components);
            this.expiredLedgerTabPage = new System.Windows.Forms.TabPage();
            this.paidLedgerDataGridView = new System.Windows.Forms.DataGridView();
            this.expiredLedgerDataGridView = new System.Windows.Forms.DataGridView();
            this.mainTabControl.SuspendLayout();
            this.rewardsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsGridView)).BeginInit();
            this.ledgerTabPage.SuspendLayout();
            this.ledgerTabControl.SuspendLayout();
            this.pendingLedgerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendingLedgerGridView)).BeginInit();
            this.paidLedgerTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.sqlTabPage.SuspendLayout();
            this.nexusGroupBox.SuspendLayout();
            this.paymentsGroupBox.SuspendLayout();
            this.discordTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerGridView)).BeginInit();
            this.expiredLedgerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paidLedgerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredLedgerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.rewardsTabPage);
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.ledgerTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Controls.Add(this.sqlTabPage);
            this.mainTabControl.Controls.Add(this.discordTabPage);
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
            this.rewardsTabPage.Controls.Add(this.discordRolesLabel);
            this.rewardsTabPage.Controls.Add(this.discordroleslist);
            this.rewardsTabPage.Controls.Add(this.rewardsGridView);
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
            // discordRolesLabel
            // 
            this.discordRolesLabel.AutoSize = true;
            this.discordRolesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordRolesLabel.Location = new System.Drawing.Point(12, 551);
            this.discordRolesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordRolesLabel.Name = "discordRolesLabel";
            this.discordRolesLabel.Size = new System.Drawing.Size(109, 17);
            this.discordRolesLabel.TabIndex = 4;
            this.discordRolesLabel.Text = "Discord Roles";
            // 
            // discordroleslist
            // 
            this.discordroleslist.FormattingEnabled = true;
            this.discordroleslist.Location = new System.Drawing.Point(15, 570);
            this.discordroleslist.Margin = new System.Windows.Forms.Padding(2);
            this.discordroleslist.Name = "discordroleslist";
            this.discordroleslist.Size = new System.Drawing.Size(223, 409);
            this.discordroleslist.TabIndex = 3;
            this.discordroleslist.SelectedIndexChanged += new System.EventHandler(this.discordroleslist_SelectedIndexChanged);
            // 
            // rewardsGridView
            // 
            this.rewardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rewardsGridView.Location = new System.Drawing.Point(7, 21);
            this.rewardsGridView.Name = "rewardsGridView";
            this.rewardsGridView.Size = new System.Drawing.Size(1055, 453);
            this.rewardsGridView.TabIndex = 3;
            this.rewardsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rewardsGridView_CellContentClick);
            this.rewardsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rewardsGridView_CellContentClick);
            this.rewardsGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.rewardsRowAdded);
            this.rewardsGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.rewardsRowRemoved);
            // 
            // rewardsSaveButton
            // 
            this.rewardsSaveButton.AutoSize = true;
            this.rewardsSaveButton.Location = new System.Drawing.Point(5, 494);
            this.rewardsSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.rewardsSaveButton.Name = "rewardsSaveButton";
            this.rewardsSaveButton.Size = new System.Drawing.Size(89, 24);
            this.rewardsSaveButton.TabIndex = 2;
            this.rewardsSaveButton.Text = "Save";
            this.rewardsSaveButton.UseVisualStyleBackColor = true;
            this.rewardsSaveButton.Click += new System.EventHandler(this.rewardsSaveButton_click);
            // 
            // playersTabPage
            // 
            this.playersTabPage.BackColor = System.Drawing.Color.DimGray;
            this.playersTabPage.Location = new System.Drawing.Point(4, 22);
            this.playersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.playersTabPage.Size = new System.Drawing.Size(1767, 898);
            this.playersTabPage.TabIndex = 1;
            this.playersTabPage.Text = "Users";
            // 
            // ledgerTabPage
            // 
            this.ledgerTabPage.BackColor = System.Drawing.Color.DimGray;
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
            this.ledgerTabControl.Controls.Add(this.pendingLedgerTabPage);
            this.ledgerTabControl.Controls.Add(this.paidLedgerTabPage);
            this.ledgerTabControl.Controls.Add(this.expiredLedgerTabPage);
            this.ledgerTabControl.Location = new System.Drawing.Point(0, 0);
            this.ledgerTabControl.Name = "ledgerTabControl";
            this.ledgerTabControl.SelectedIndex = 0;
            this.ledgerTabControl.Size = new System.Drawing.Size(1183, 620);
            this.ledgerTabControl.TabIndex = 1;
            // 
            // pendingLedgerTabPage
            // 
            this.pendingLedgerTabPage.Controls.Add(this.pendingLedgerGridView);
            this.pendingLedgerTabPage.Location = new System.Drawing.Point(4, 22);
            this.pendingLedgerTabPage.Name = "pendingLedgerTabPage";
            this.pendingLedgerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pendingLedgerTabPage.Size = new System.Drawing.Size(1175, 594);
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
            this.pendingLedgerGridView.Name = "pendingLedgerGridView";
            this.pendingLedgerGridView.Size = new System.Drawing.Size(1175, 594);
            this.pendingLedgerGridView.TabIndex = 0;
            // 
            // paidLedgerTabPage
            // 
            this.paidLedgerTabPage.Controls.Add(this.paidLedgerDataGridView);
            this.paidLedgerTabPage.Location = new System.Drawing.Point(4, 22);
            this.paidLedgerTabPage.Name = "paidLedgerTabPage";
            this.paidLedgerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.paidLedgerTabPage.Size = new System.Drawing.Size(1175, 594);
            this.paidLedgerTabPage.TabIndex = 1;
            this.paidLedgerTabPage.Text = "Paid Payments";
            this.paidLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.Color.DimGray;
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
            // settingsSaveButton
            // 
            this.settingsSaveButton.AutoSize = true;
            this.settingsSaveButton.Location = new System.Drawing.Point(16, 424);
            this.settingsSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Size = new System.Drawing.Size(89, 24);
            this.settingsSaveButton.TabIndex = 2;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
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
            // sqlTabPage
            // 
            this.sqlTabPage.BackColor = System.Drawing.Color.DimGray;
            this.sqlTabPage.Controls.Add(this.nexusGroupBox);
            this.sqlTabPage.Controls.Add(this.paymentsGroupBox);
            this.sqlTabPage.Controls.Add(this.sqlConfigSaveButton);
            this.sqlTabPage.Location = new System.Drawing.Point(4, 22);
            this.sqlTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.sqlTabPage.Name = "sqlTabPage";
            this.sqlTabPage.Size = new System.Drawing.Size(1767, 898);
            this.sqlTabPage.TabIndex = 4;
            this.sqlTabPage.Text = "SQL";
            // 
            // nexusGroupBox
            // 
            this.nexusGroupBox.Controls.Add(this.Password);
            this.nexusGroupBox.Controls.Add(this.databasePortLabel);
            this.nexusGroupBox.Controls.Add(this.nexusDatabaseHost);
            this.nexusGroupBox.Controls.Add(this.databaseHostLabel);
            this.nexusGroupBox.Controls.Add(this.nexusDatabasePort);
            this.nexusGroupBox.Controls.Add(this.databaseDatabaseLabel);
            this.nexusGroupBox.Controls.Add(this.nexusDatabaseUser);
            this.nexusGroupBox.Controls.Add(this.databaseUsernameLabel);
            this.nexusGroupBox.Controls.Add(this.nexusDatabaseDatabase);
            this.nexusGroupBox.Controls.Add(this.databasePasswordLabel);
            this.nexusGroupBox.Location = new System.Drawing.Point(28, 168);
            this.nexusGroupBox.Name = "nexusGroupBox";
            this.nexusGroupBox.Size = new System.Drawing.Size(532, 137);
            this.nexusGroupBox.TabIndex = 14;
            this.nexusGroupBox.TabStop = false;
            this.nexusGroupBox.Text = "Nexus Database";
            this.nexusGroupBox.Visible = false;
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
            this.databasePortLabel.Click += new System.EventHandler(this.databasePortLabel_Click);
            // 
            // nexusDatabaseHost
            // 
            this.nexusDatabaseHost.Location = new System.Drawing.Point(102, 19);
            this.nexusDatabaseHost.Name = "nexusDatabaseHost";
            this.nexusDatabaseHost.Size = new System.Drawing.Size(203, 20);
            this.nexusDatabaseHost.TabIndex = 3;
            this.nexusDatabaseHost.Text = "localhost";
            this.nexusDatabaseHost.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // databaseHostLabel
            // 
            this.databaseHostLabel.AutoSize = true;
            this.databaseHostLabel.Location = new System.Drawing.Point(22, 23);
            this.databaseHostLabel.Name = "databaseHostLabel";
            this.databaseHostLabel.Size = new System.Drawing.Size(32, 13);
            this.databaseHostLabel.TabIndex = 4;
            this.databaseHostLabel.Text = "Host:";
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
            // databaseUsernameLabel
            // 
            this.databaseUsernameLabel.AutoSize = true;
            this.databaseUsernameLabel.Location = new System.Drawing.Point(22, 74);
            this.databaseUsernameLabel.Name = "databaseUsernameLabel";
            this.databaseUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.databaseUsernameLabel.TabIndex = 6;
            this.databaseUsernameLabel.Text = "Username:";
            // 
            // nexusDatabaseDatabase
            // 
            this.nexusDatabaseDatabase.Location = new System.Drawing.Point(102, 45);
            this.nexusDatabaseDatabase.Name = "nexusDatabaseDatabase";
            this.nexusDatabaseDatabase.Size = new System.Drawing.Size(203, 20);
            this.nexusDatabaseDatabase.TabIndex = 8;
            this.nexusDatabaseDatabase.Text = "NexusDatabase";
            // 
            // databasePasswordLabel
            // 
            this.databasePasswordLabel.AutoSize = true;
            this.databasePasswordLabel.Location = new System.Drawing.Point(22, 104);
            this.databasePasswordLabel.Name = "databasePasswordLabel";
            this.databasePasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.databasePasswordLabel.TabIndex = 7;
            this.databasePasswordLabel.Text = "Password:";
            // 
            // paymentsGroupBox
            // 
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabasePassword);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabasePortLabel);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseHost);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabasePort);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseHostLabel);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseDatabaseLabel);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseUser);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseUsernameLabel);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseDatabase);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabasePasswordLabel);
            this.paymentsGroupBox.Location = new System.Drawing.Point(28, 25);
            this.paymentsGroupBox.Name = "paymentsGroupBox";
            this.paymentsGroupBox.Size = new System.Drawing.Size(532, 137);
            this.paymentsGroupBox.TabIndex = 13;
            this.paymentsGroupBox.TabStop = false;
            this.paymentsGroupBox.Text = "Payments Database";
            this.paymentsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.paymentsDatabaseHost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.paymentsDatabasePort.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.paymentsDatabasePort_MaskInputRejected);
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
            this.paymentsDatabaseDatabaseLabel.Click += new System.EventHandler(this.paymentsDatabaseDatabaseLabel_Click);
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
            this.paymentsDatabaseDatabase.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // sqlConfigSaveButton
            // 
            this.sqlConfigSaveButton.AutoSize = true;
            this.sqlConfigSaveButton.Location = new System.Drawing.Point(7, 324);
            this.sqlConfigSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.sqlConfigSaveButton.Name = "sqlConfigSaveButton";
            this.sqlConfigSaveButton.Size = new System.Drawing.Size(89, 24);
            this.sqlConfigSaveButton.TabIndex = 2;
            this.sqlConfigSaveButton.Text = "Save";
            this.sqlConfigSaveButton.UseVisualStyleBackColor = true;
            this.sqlConfigSaveButton.Click += new System.EventHandler(this.sqlConfigSave_Click);
            // 
            // discordTabPage
            // 
            this.discordTabPage.BackColor = System.Drawing.Color.DimGray;
            this.discordTabPage.Controls.Add(this.discordAutoConnect);
            this.discordTabPage.Controls.Add(this.btnSave);
            this.discordTabPage.Controls.Add(this.discordTestMessageLabel);
            this.discordTabPage.Controls.Add(this.discordChannelIDLabel);
            this.discordTabPage.Controls.Add(this.discordBotTokenLabel);
            this.discordTabPage.Controls.Add(this.discordMSGSend);
            this.discordTabPage.Controls.Add(this.discordBotConnect);
            this.discordTabPage.Controls.Add(this.discordTestMessage);
            this.discordTabPage.Controls.Add(this.channelDiscordID);
            this.discordTabPage.Controls.Add(this.discordToken);
            this.discordTabPage.Location = new System.Drawing.Point(4, 22);
            this.discordTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.discordTabPage.Name = "discordTabPage";
            this.discordTabPage.Size = new System.Drawing.Size(1767, 898);
            this.discordTabPage.TabIndex = 5;
            this.discordTabPage.Text = "Discord";
            // 
            // discordAutoConnect
            // 
            this.discordAutoConnect.AutoSize = true;
            this.discordAutoConnect.Location = new System.Drawing.Point(551, 28);
            this.discordAutoConnect.Margin = new System.Windows.Forms.Padding(2);
            this.discordAutoConnect.Name = "discordAutoConnect";
            this.discordAutoConnect.Size = new System.Drawing.Size(108, 17);
            this.discordAutoConnect.TabIndex = 8;
            this.discordAutoConnect.Text = "Connect On Start";
            this.discordAutoConnect.UseVisualStyleBackColor = true;
            this.discordAutoConnect.CheckedChanged += new System.EventHandler(this.discordAutoConnect_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(137, 102);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // discordTestMessageLabel
            // 
            this.discordTestMessageLabel.AutoSize = true;
            this.discordTestMessageLabel.Location = new System.Drawing.Point(35, 83);
            this.discordTestMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordTestMessageLabel.Name = "discordTestMessageLabel";
            this.discordTestMessageLabel.Size = new System.Drawing.Size(74, 13);
            this.discordTestMessageLabel.TabIndex = 7;
            this.discordTestMessageLabel.Text = "Test Message";
            // 
            // discordChannelIDLabel
            // 
            this.discordChannelIDLabel.AutoSize = true;
            this.discordChannelIDLabel.Location = new System.Drawing.Point(35, 57);
            this.discordChannelIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordChannelIDLabel.Name = "discordChannelIDLabel";
            this.discordChannelIDLabel.Size = new System.Drawing.Size(99, 13);
            this.discordChannelIDLabel.TabIndex = 6;
            this.discordChannelIDLabel.Text = "Discord Channel ID";
            // 
            // discordBotTokenLabel
            // 
            this.discordBotTokenLabel.AutoSize = true;
            this.discordBotTokenLabel.Location = new System.Drawing.Point(35, 29);
            this.discordBotTokenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discordBotTokenLabel.Name = "discordBotTokenLabel";
            this.discordBotTokenLabel.Size = new System.Drawing.Size(96, 13);
            this.discordBotTokenLabel.TabIndex = 5;
            this.discordBotTokenLabel.Text = "Discord Bot Token";
            // 
            // discordMSGSend
            // 
            this.discordMSGSend.Location = new System.Drawing.Point(444, 79);
            this.discordMSGSend.Margin = new System.Windows.Forms.Padding(2);
            this.discordMSGSend.Name = "discordMSGSend";
            this.discordMSGSend.Size = new System.Drawing.Size(74, 22);
            this.discordMSGSend.TabIndex = 4;
            this.discordMSGSend.Text = "Send";
            this.discordMSGSend.UseVisualStyleBackColor = true;
            this.discordMSGSend.Click += new System.EventHandler(this.discordMSGSend_Click);
            // 
            // discordBotConnect
            // 
            this.discordBotConnect.Location = new System.Drawing.Point(444, 25);
            this.discordBotConnect.Margin = new System.Windows.Forms.Padding(2);
            this.discordBotConnect.Name = "discordBotConnect";
            this.discordBotConnect.Size = new System.Drawing.Size(74, 22);
            this.discordBotConnect.TabIndex = 3;
            this.discordBotConnect.Text = "Connect";
            this.discordBotConnect.UseVisualStyleBackColor = true;
            this.discordBotConnect.Click += new System.EventHandler(this.discordBotConnect_Click);
            // 
            // discordTestMessage
            // 
            this.discordTestMessage.Location = new System.Drawing.Point(137, 81);
            this.discordTestMessage.Margin = new System.Windows.Forms.Padding(2);
            this.discordTestMessage.Name = "discordTestMessage";
            this.discordTestMessage.Size = new System.Drawing.Size(295, 20);
            this.discordTestMessage.TabIndex = 2;
            this.discordTestMessage.TextChanged += new System.EventHandler(this.discordTestMessage_TextChanged);
            // 
            // channelDiscordID
            // 
            this.channelDiscordID.Location = new System.Drawing.Point(137, 55);
            this.channelDiscordID.Margin = new System.Windows.Forms.Padding(2);
            this.channelDiscordID.Name = "channelDiscordID";
            this.channelDiscordID.Size = new System.Drawing.Size(295, 20);
            this.channelDiscordID.TabIndex = 1;
            // 
            // discordToken
            // 
            this.discordToken.Location = new System.Drawing.Point(137, 27);
            this.discordToken.Margin = new System.Windows.Forms.Padding(2);
            this.discordToken.Name = "discordToken";
            this.discordToken.Size = new System.Drawing.Size(295, 20);
            this.discordToken.TabIndex = 0;
            this.discordToken.UseSystemPasswordChar = true;
            // 
            // playerGridView
            // 
            this.playerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGridView.Location = new System.Drawing.Point(32, 37);
            this.playerGridView.Name = "playerGridView";
            this.playerGridView.Size = new System.Drawing.Size(898, 561);
            this.playerGridView.TabIndex = 0;
            // 
            // droleupdate
            // 
            this.droleupdate.Interval = 120000;
            this.droleupdate.Tick += new System.EventHandler(this.droleupdate_Tick);
            // 
            // expiredLedgerTabPage
            // 
            this.expiredLedgerTabPage.Controls.Add(this.expiredLedgerDataGridView);
            this.expiredLedgerTabPage.Location = new System.Drawing.Point(4, 22);
            this.expiredLedgerTabPage.Name = "expiredLedgerTabPage";
            this.expiredLedgerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.expiredLedgerTabPage.Size = new System.Drawing.Size(1175, 594);
            this.expiredLedgerTabPage.TabIndex = 2;
            this.expiredLedgerTabPage.Text = "Expired Payments";
            this.expiredLedgerTabPage.UseVisualStyleBackColor = true;
            // 
            // paidLedgerDataGridView
            // 
            this.paidLedgerDataGridView.AllowUserToAddRows = false;
            this.paidLedgerDataGridView.AllowUserToOrderColumns = true;
            this.paidLedgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paidLedgerDataGridView.Location = new System.Drawing.Point(72, 76);
            this.paidLedgerDataGridView.Name = "paidLedgerDataGridView";
            this.paidLedgerDataGridView.Size = new System.Drawing.Size(1030, 442);
            this.paidLedgerDataGridView.TabIndex = 1;
            // 
            // expiredLedgerDataGridView
            // 
            this.expiredLedgerDataGridView.AllowUserToAddRows = false;
            this.expiredLedgerDataGridView.AllowUserToOrderColumns = true;
            this.expiredLedgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expiredLedgerDataGridView.Location = new System.Drawing.Point(72, 76);
            this.expiredLedgerDataGridView.Name = "expiredLedgerDataGridView";
            this.expiredLedgerDataGridView.Size = new System.Drawing.Size(1030, 442);
            this.expiredLedgerDataGridView.TabIndex = 1;
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
            this.ledgerTabPage.ResumeLayout(false);
            this.ledgerTabControl.ResumeLayout(false);
            this.pendingLedgerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pendingLedgerGridView)).EndInit();
            this.paidLedgerTabPage.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.sqlTabPage.ResumeLayout(false);
            this.sqlTabPage.PerformLayout();
            this.nexusGroupBox.ResumeLayout(false);
            this.nexusGroupBox.PerformLayout();
            this.paymentsGroupBox.ResumeLayout(false);
            this.paymentsGroupBox.PerformLayout();
            this.discordTabPage.ResumeLayout(false);
            this.discordTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerGridView)).EndInit();
            this.expiredLedgerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paidLedgerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredLedgerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage rewardsTabPage;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.TabPage ledgerTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TabPage sqlTabPage;
        private System.Windows.Forms.TabPage discordTabPage;
        private System.Windows.Forms.Label discordTestMessageLabel;
        private System.Windows.Forms.Label discordChannelIDLabel;
        private System.Windows.Forms.Label discordBotTokenLabel;
        private System.Windows.Forms.Button discordMSGSend;
        private System.Windows.Forms.Button discordBotConnect;
        private System.Windows.Forms.TextBox discordTestMessage;
        private System.Windows.Forms.TextBox channelDiscordID;
        private System.Windows.Forms.TextBox discordToken;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button configSaveLocation;
        private System.Windows.Forms.Button rewardsSaveButton;
        private System.Windows.Forms.Button settingsSaveButton;
        private System.Windows.Forms.Button sqlConfigSaveButton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox discordAutoConnect;
        private System.Windows.Forms.TextBox paymentsDatabaseHost;
        private System.Windows.Forms.Label discordRolesLabel;
        private System.Windows.Forms.Label paymentsDatabaseUsernameLabel;
        private System.Windows.Forms.Label paymentsDatabaseHostLabel;
        private System.Windows.Forms.Label paymentsDatabaseDatabaseLabel;
        private System.Windows.Forms.TextBox paymentsDatabaseUser;
        private System.Windows.Forms.TextBox paymentsDatabaseDatabase;
        private System.Windows.Forms.Label paymentsDatabasePasswordLabel;
        private System.Windows.Forms.GroupBox paymentsGroupBox;
        private System.Windows.Forms.GroupBox nexusGroupBox;
        private System.Windows.Forms.TextBox nexusDatabaseHost;
        private System.Windows.Forms.Label databaseHostLabel;
        private System.Windows.Forms.MaskedTextBox nexusDatabasePort;
        private System.Windows.Forms.Label databaseDatabaseLabel;
        private System.Windows.Forms.TextBox nexusDatabaseUser;
        private System.Windows.Forms.Label databaseUsernameLabel;
        private System.Windows.Forms.TextBox nexusDatabaseDatabase;
        private System.Windows.Forms.Label databasePasswordLabel;
        private System.Windows.Forms.Label databasePortLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox paymentsDatabasePassword;
        private System.Windows.Forms.Label paymentsDatabasePortLabel;
        private System.Windows.Forms.MaskedTextBox paymentsDatabasePort;
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
    }
}

