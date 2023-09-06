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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ledgerGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.configSaveLocation = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.nexusGroupBox = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nexusDatabaseHost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nexusDatabasePort = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nexusDatabaseUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nexusDatabaseDatabase = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.paymentsGroupBox = new System.Windows.Forms.GroupBox();
            this.paymentsDatabasePassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.paymentsDatabaseHost = new System.Windows.Forms.TextBox();
            this.paymentsDatabasePort = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentsDatabaseUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paymentsDatabaseDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.discordAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.discordMSGSend = new System.Windows.Forms.Button();
            this.discordBotConnect = new System.Windows.Forms.Button();
            this.discordTestMessage = new System.Windows.Forms.TextBox();
            this.channelDiscordID = new System.Windows.Forms.TextBox();
            this.discordToken = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.nexusGroupBox.SuspendLayout();
            this.paymentsGroupBox.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1775, 924);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1767, 898);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rewards";
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(5, 494);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 24);
            this.button6.TabIndex = 2;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1767, 898);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.ledgerGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1767, 898);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ledger";
            // 
            // ledgerGridView
            // 
            this.ledgerGridView.AllowUserToOrderColumns = true;
            this.ledgerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ledgerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledgerGridView.Location = new System.Drawing.Point(0, 0);
            this.ledgerGridView.Name = "ledgerGridView";
            this.ledgerGridView.Size = new System.Drawing.Size(1767, 898);
            this.ledgerGridView.TabIndex = 0;
            this.ledgerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.saveLocation);
            this.tabPage4.Controls.Add(this.configSaveLocation);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1767, 898);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(16, 424);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 24);
            this.button5.TabIndex = 2;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
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
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DimGray;
            this.tabPage5.Controls.Add(this.nexusGroupBox);
            this.tabPage5.Controls.Add(this.paymentsGroupBox);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1767, 898);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SQL";
            // 
            // nexusGroupBox
            // 
            this.nexusGroupBox.Controls.Add(this.Password);
            this.nexusGroupBox.Controls.Add(this.label12);
            this.nexusGroupBox.Controls.Add(this.nexusDatabaseHost);
            this.nexusGroupBox.Controls.Add(this.label8);
            this.nexusGroupBox.Controls.Add(this.nexusDatabasePort);
            this.nexusGroupBox.Controls.Add(this.label9);
            this.nexusGroupBox.Controls.Add(this.nexusDatabaseUser);
            this.nexusGroupBox.Controls.Add(this.label10);
            this.nexusGroupBox.Controls.Add(this.nexusDatabaseDatabase);
            this.nexusGroupBox.Controls.Add(this.label11);
            this.nexusGroupBox.Enabled = false;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Port:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Host:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Database:";
            // 
            // nexusDatabaseUser
            // 
            this.nexusDatabaseUser.Location = new System.Drawing.Point(102, 71);
            this.nexusDatabaseUser.Name = "nexusDatabaseUser";
            this.nexusDatabaseUser.Size = new System.Drawing.Size(203, 20);
            this.nexusDatabaseUser.TabIndex = 9;
            this.nexusDatabaseUser.Text = "NexusUser";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Username:";
            // 
            // nexusDatabaseDatabase
            // 
            this.nexusDatabaseDatabase.Location = new System.Drawing.Point(102, 45);
            this.nexusDatabaseDatabase.Name = "nexusDatabaseDatabase";
            this.nexusDatabaseDatabase.Size = new System.Drawing.Size(203, 20);
            this.nexusDatabaseDatabase.TabIndex = 8;
            this.nexusDatabaseDatabase.Text = "NexusDatabase";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Password:";
            // 
            // paymentsGroupBox
            // 
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabasePassword);
            this.paymentsGroupBox.Controls.Add(this.label13);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseHost);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabasePort);
            this.paymentsGroupBox.Controls.Add(this.label4);
            this.paymentsGroupBox.Controls.Add(this.label5);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseUser);
            this.paymentsGroupBox.Controls.Add(this.label6);
            this.paymentsGroupBox.Controls.Add(this.paymentsDatabaseDatabase);
            this.paymentsGroupBox.Controls.Add(this.label7);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Port:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Host:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Database:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // paymentsDatabaseUser
            // 
            this.paymentsDatabaseUser.Location = new System.Drawing.Point(102, 71);
            this.paymentsDatabaseUser.Name = "paymentsDatabaseUser";
            this.paymentsDatabaseUser.Size = new System.Drawing.Size(203, 20);
            this.paymentsDatabaseUser.TabIndex = 9;
            this.paymentsDatabaseUser.Text = "paymentsUser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password:";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(7, 324);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 24);
            this.button4.TabIndex = 2;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.sqlConfigSave_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.DimGray;
            this.tabPage6.Controls.Add(this.discordAutoConnect);
            this.tabPage6.Controls.Add(this.btnSave);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.discordMSGSend);
            this.tabPage6.Controls.Add(this.discordBotConnect);
            this.tabPage6.Controls.Add(this.discordTestMessage);
            this.tabPage6.Controls.Add(this.channelDiscordID);
            this.tabPage6.Controls.Add(this.discordToken);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1767, 898);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Discord";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discord Channel ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discord Bot Token";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1775, 924);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledgerGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.nexusGroupBox.ResumeLayout(false);
            this.nexusGroupBox.PerformLayout();
            this.paymentsGroupBox.ResumeLayout(false);
            this.paymentsGroupBox.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button discordMSGSend;
        private System.Windows.Forms.Button discordBotConnect;
        private System.Windows.Forms.TextBox discordTestMessage;
        private System.Windows.Forms.TextBox channelDiscordID;
        private System.Windows.Forms.TextBox discordToken;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button configSaveLocation;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox discordAutoConnect;
        private System.Windows.Forms.TextBox paymentsDatabaseHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paymentsDatabaseUser;
        private System.Windows.Forms.TextBox paymentsDatabaseDatabase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox paymentsGroupBox;
        private System.Windows.Forms.GroupBox nexusGroupBox;
        private System.Windows.Forms.TextBox nexusDatabaseHost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox nexusDatabasePort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nexusDatabaseUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nexusDatabaseDatabase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox paymentsDatabasePassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox paymentsDatabasePort;
        private System.Windows.Forms.DataGridView ledgerGridView;
    }
}

