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

namespace PayMe
{
    public partial class Form1 : Form
    {
        private string defaultConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PayMe", "PayMe.cfg");

        public Form1()
        {
            InitializeComponent();
            LoadDefaultSaveLocation();
        }

        private void LoadDefaultSaveLocation()
        {
            //MessageBox.Show("LoadDefaultSaveLocation method executed"); 

            string defaultLocation;

            if (File.Exists(defaultConfigPath))
            {
                defaultLocation = File.ReadAllText(defaultConfigPath).Trim();
                if (string.IsNullOrWhiteSpace(defaultLocation))
                {
                    defaultLocation = GetDefaultSaveLocation();
                    SaveDefaultLocation(defaultLocation);
                }
            }
            else
            {
                defaultLocation = GetDefaultSaveLocation();
                SaveDefaultLocation(defaultLocation);
            }

            textBox4.Text = defaultLocation;
        }

        private string GetDefaultSaveLocation()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PayMe", "SaveData");
        }

        private void SaveDefaultLocation(string location)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(defaultConfigPath));
                File.WriteAllText(defaultConfigPath, location);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the default location: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = textBox4.Text;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    textBox4.Text = selectedFolderPath;

                    SaveDefaultLocation(selectedFolderPath);
                }
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            // Your logic for this event goes here.
        }
    }

}
