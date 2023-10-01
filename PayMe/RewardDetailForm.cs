using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayMe
{
    public partial class RewardDetailForm : Form
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string discordRole { get; set; }
        public string command { get; set; }
        public bool runOnAll { get; set; }
        public bool autoClaim { get; set; }
        public TimeSpan triggerInterval { get; set; }
        public TimeSpan expireInterval { get; set; }
        public bool transferable { get; set; }

        public RewardDetailForm()
        {
            InitializeComponent();

            // Subscribe to the Load event to ensure controls are initialized
            Load += RewardDetailForm_Load;
        }

        private void RewardDetailForm_Load(object sender, EventArgs e)
        {
            guidTextBox.Text = id.ToString();
            discordRoleComboBox.Text = discordRole;
            nameTextBox.Text = name;
            commandTextBox.Text = command;
            runOnAllCheckBox.Checked = runOnAll;
            transferableCheckBox.Checked = transferable;
            autoClaimCheckBox.Checked = autoClaim;
        }

        private void saveRewardButton_Click(object sender, EventArgs e)
        {
            id = new Guid(guidTextBox.Text);
            name = nameTextBox.Text;
            discordRole = discordRoleComboBox.Text;
            command = commandTextBox.Text;
            autoClaim = autoClaimCheckBox.Checked;
            runOnAll = runOnAllCheckBox.Checked;
            transferable = transferableCheckBox.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
