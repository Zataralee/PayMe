namespace PayMe
{
    partial class RewardDetailForm
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
            this.runOnAllCheckBox = new System.Windows.Forms.CheckBox();
            this.transferableCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClaimCheckBox = new System.Windows.Forms.CheckBox();
            this.discordRoleComboBox = new System.Windows.Forms.ComboBox();
            this.saveRewardButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.guidLabel = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.discordRoleLabel = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // runOnAllCheckBox
            // 
            this.runOnAllCheckBox.AutoSize = true;
            this.runOnAllCheckBox.Location = new System.Drawing.Point(556, 76);
            this.runOnAllCheckBox.Name = "runOnAllCheckBox";
            this.runOnAllCheckBox.Size = new System.Drawing.Size(77, 17);
            this.runOnAllCheckBox.TabIndex = 0;
            this.runOnAllCheckBox.Text = "Run On All";
            this.runOnAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // transferableCheckBox
            // 
            this.transferableCheckBox.AutoSize = true;
            this.transferableCheckBox.Location = new System.Drawing.Point(556, 99);
            this.transferableCheckBox.Name = "transferableCheckBox";
            this.transferableCheckBox.Size = new System.Drawing.Size(136, 17);
            this.transferableCheckBox.TabIndex = 1;
            this.transferableCheckBox.Text = "Reward Is Transferable";
            this.transferableCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClaimCheckBox
            // 
            this.autoClaimCheckBox.AutoSize = true;
            this.autoClaimCheckBox.Location = new System.Drawing.Point(556, 122);
            this.autoClaimCheckBox.Name = "autoClaimCheckBox";
            this.autoClaimCheckBox.Size = new System.Drawing.Size(149, 17);
            this.autoClaimCheckBox.TabIndex = 2;
            this.autoClaimCheckBox.Text = "Autoclaim When Awarded";
            this.autoClaimCheckBox.UseVisualStyleBackColor = true;
            // 
            // discordRoleComboBox
            // 
            this.discordRoleComboBox.FormattingEnabled = true;
            this.discordRoleComboBox.Location = new System.Drawing.Point(95, 125);
            this.discordRoleComboBox.Name = "discordRoleComboBox";
            this.discordRoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.discordRoleComboBox.TabIndex = 3;
            // 
            // saveRewardButton
            // 
            this.saveRewardButton.Location = new System.Drawing.Point(593, 367);
            this.saveRewardButton.Name = "saveRewardButton";
            this.saveRewardButton.Size = new System.Drawing.Size(109, 35);
            this.saveRewardButton.TabIndex = 4;
            this.saveRewardButton.Text = "Save Reward";
            this.saveRewardButton.UseVisualStyleBackColor = true;
            this.saveRewardButton.Click += new System.EventHandler(this.saveRewardButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(95, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // guidTextBox
            // 
            this.guidTextBox.Location = new System.Drawing.Point(95, 73);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.Size = new System.Drawing.Size(121, 20);
            this.guidTextBox.TabIndex = 6;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(35, 102);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 7;
            this.namelabel.Text = "Name";
            // 
            // guidLabel
            // 
            this.guidLabel.AutoSize = true;
            this.guidLabel.Location = new System.Drawing.Point(35, 76);
            this.guidLabel.Name = "guidLabel";
            this.guidLabel.Size = new System.Drawing.Size(34, 13);
            this.guidLabel.TabIndex = 8;
            this.guidLabel.Text = "GUID";
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(16, 157);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(54, 13);
            this.commandLabel.TabIndex = 9;
            this.commandLabel.Text = "Command";
            // 
            // discordRoleLabel
            // 
            this.discordRoleLabel.AutoSize = true;
            this.discordRoleLabel.Location = new System.Drawing.Point(12, 128);
            this.discordRoleLabel.Name = "discordRoleLabel";
            this.discordRoleLabel.Size = new System.Drawing.Size(68, 13);
            this.discordRoleLabel.TabIndex = 10;
            this.discordRoleLabel.Text = "Discord Role";
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(95, 154);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(121, 20);
            this.commandTextBox.TabIndex = 11;
            // 
            // RewardDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.discordRoleLabel);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.guidLabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.guidTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveRewardButton);
            this.Controls.Add(this.discordRoleComboBox);
            this.Controls.Add(this.autoClaimCheckBox);
            this.Controls.Add(this.transferableCheckBox);
            this.Controls.Add(this.runOnAllCheckBox);
            this.Name = "RewardDetailForm";
            this.Text = "Reward Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox runOnAllCheckBox;
        private System.Windows.Forms.CheckBox transferableCheckBox;
        private System.Windows.Forms.CheckBox autoClaimCheckBox;
        private System.Windows.Forms.ComboBox discordRoleComboBox;
        private System.Windows.Forms.Button saveRewardButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label guidLabel;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Label discordRoleLabel;
        private System.Windows.Forms.TextBox commandTextBox;
    }
}