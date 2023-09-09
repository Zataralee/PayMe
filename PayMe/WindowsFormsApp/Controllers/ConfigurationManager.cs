using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PayMe.WindowsFormsApp.Controllers
{
    internal class ConfigurationManager
    {

        Configuration config = new Configuration();

        private string defaultConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PayMe", "SaveData", "PayMe.cfg");


        public Configuration LoadConfiguration()
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
                            config.discordToken = line.Split('=')[1].Trim();
                            Console.WriteLine(config.discordToken);
                        }
                        else if (line.Contains("Discord Channel"))
                        {
                            config.channelDiscordID = line.Split('=')[1].Trim();
                        }
                        else if (line.Contains("Save Location"))
                        {
                            config.saveLocation = line.Split('=')[1].Trim();
                        }
                        else if (line.Contains("Bot Auto Connect"))
                        {
                            config.discordAutoConnect = bool.Parse(line.Split('=')[1].Trim());
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("The configuration file has an unexpected format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("The configuration file has an unexpected format.");
                }
            }
            else
            {
                config.saveLocation = GetDefaultSaveLocation();
                SaveConfiguration();
            }

            return config;
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
                       $"Bot Token          = {config.discordToken}\n" +
                       $"Discord Channel    = {config.channelDiscordID}\n" +
                       $"Save Location      = {config.saveLocation}\n" +
                       $"Bot Auto Connect   = {config.discordAutoConnect}";  // Save the state of the checkbox
                File.WriteAllText(defaultConfigPath, configData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the configuration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

public class Configuration
{
    public string discordToken { get; set; }
    public string channelDiscordID { get; set; }
    public string saveLocation { get; set; }
    public bool discordAutoConnect { get; set; }
}
