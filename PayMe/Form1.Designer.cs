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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.discordroleslist = new System.Windows.Forms.CheckedListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.configSaveLocation = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.droleupdate = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1775, 924);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.discordroleslist);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1767, 898);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rewards";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discord Roles";
            // 
            // discordroleslist
            // 
            this.discordroleslist.FormattingEnabled = true;
            this.discordroleslist.Location = new System.Drawing.Point(15, 33);
            this.discordroleslist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.discordroleslist.Name = "discordroleslist";
            this.discordroleslist.Size = new System.Drawing.Size(223, 409);
            this.discordroleslist.TabIndex = 3;
            this.discordroleslist.SelectedIndexChanged += new System.EventHandler(this.discordroleslist_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(15, 489);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1767, 908);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1767, 908);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ledger";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.saveLocation);
            this.tabPage4.Controls.Add(this.configSaveLocation);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1767, 908);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(16, 424);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 24);
            this.button5.TabIndex = 2;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(109, 18);
            this.saveLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(644, 20);
            this.saveLocation.TabIndex = 1;
            // 
            // configSaveLocation
            // 
            this.configSaveLocation.Location = new System.Drawing.Point(14, 13);
            this.configSaveLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1767, 908);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SQL";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(5, 293);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 24);
            this.button4.TabIndex = 2;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
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
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1767, 898);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Discord";
            // 
            // discordAutoConnect
            // 
            this.discordAutoConnect.AutoSize = true;
            this.discordAutoConnect.Location = new System.Drawing.Point(551, 28);
            this.discordAutoConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.discordMSGSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.discordBotConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.discordTestMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.discordTestMessage.Name = "discordTestMessage";
            this.discordTestMessage.Size = new System.Drawing.Size(295, 20);
            this.discordTestMessage.TabIndex = 2;
            this.discordTestMessage.TextChanged += new System.EventHandler(this.discordTestMessage_TextChanged);
            // 
            // channelDiscordID
            // 
            this.channelDiscordID.Location = new System.Drawing.Point(137, 55);
            this.channelDiscordID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.channelDiscordID.Name = "channelDiscordID";
            this.channelDiscordID.Size = new System.Drawing.Size(295, 20);
            this.channelDiscordID.TabIndex = 1;
            // 
            // discordToken
            // 
            this.discordToken.Location = new System.Drawing.Point(137, 27);
            this.discordToken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.discordToken.Name = "discordToken";
            this.discordToken.Size = new System.Drawing.Size(295, 20);
            this.discordToken.TabIndex = 0;
            this.discordToken.UseSystemPasswordChar = true;
            // 
            // droleupdate
            // 
            this.droleupdate.Interval = 120000;
            this.droleupdate.Tick += new System.EventHandler(this.droleupdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1775, 924);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox discordroleslist;
        private System.Windows.Forms.Timer droleupdate;
    }
}

