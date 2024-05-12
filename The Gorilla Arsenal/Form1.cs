using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Gorilla_Arsenal.betterFolderDialog;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using System.IO.Compression;
using System.Net;

namespace The_Gorilla_Arsenal
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            fileLocation.Text = Properties.Settings.Default.Gorilla_Path;
            refreshPlugins();
        }

        private void browseFiles_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                InitialDirectory = fileLocation.Text,
                Title = "Select the Gorilla Tag Folder"
            };
            if (dialog.Show(Handle))
            {
                fileLocation.Text = dialog.FileName;
                Console.WriteLine(dialog.FileName);
            }

            // check if everything is there.
            if (Directory.Exists(dialog.FileName + "\\Gorilla Tag_Data") && Directory.Exists(dialog.FileName + "\\MonoBleedingEdge") && File.Exists(dialog.FileName + "\\Gorilla Tag.exe") && !Directory.Exists(dialog.FileName + "\\BepInEx"))
            {
                string message = "Install BepInEx?";
                string caption = "The Gorilla Arsenal";

                //do we want to install bepinex?
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //get versions
                    WebClient webClient = new WebClient();
                    webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/124.0");
                    string response = webClient.DownloadString("https://api.github.com/repos/BepInEx/BepInEx/releases/latest");
                    GithubPackage json = JsonSerializer.Deserialize<GithubPackage>(response);
                    Console.WriteLine("Package Name: " + json.name);

                    string download_url = "";

                    //select appropiate version
                    for (int i = 0; i < json.assets.Length; i++)
                    {
                        string url = json.assets[i].browser_download_url;

                        if (url.ToLower().Contains("win"))
                        { 
                            if (url.Contains("x64") && Environment.Is64BitOperatingSystem)
                            {
                                download_url = url;
                            }
                            else if (url.Contains("x86") && !Environment.Is64BitOperatingSystem)
                            {
                                download_url = url;
                            }
                        }
                    }
                    Console.WriteLine("Package Selected Download Url: " + download_url);
                    string temp_file = dialog.FileName + "BepInEx" + ".zip";
                    webClient.DownloadFile(new Uri(download_url), temp_file);
                    ZipFile.ExtractToDirectory(temp_file, dialog.FileName);

                    //Install message
                    message = "BepInEx Installed. Please start Gorilla Tag then close it to add plugins.";
                    caption = "The Gorilla Arsenal";

                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(dialog.FileName != "" && !Directory.Exists(dialog.FileName + "\\BepInEx"))
            {
                fileLocation.Text = "";

                string message = "Your Gorilla Tag folder is missing major components!";
                string caption = "The Gorilla Arsenal";

                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Properties.Settings.Default.Gorilla_Path = fileLocation.Text;
            Properties.Settings.Default.Save();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshPlugins();
        }

        private void refreshPlugins()
        {
            checkedListBox1.Visible = Directory.Exists(fileLocation.Text + "\\BepInEx") && Directory.Exists(fileLocation.Text + "\\BepInEx\\Plugins");
            installwarning.Visible = Directory.Exists(fileLocation.Text + "\\BepInEx") && !Directory.Exists(fileLocation.Text + "\\BepInEx\\Plugins");
            pluginwarning.Visible = !Directory.Exists(fileLocation.Text + "\\BepInEx");

            if (Directory.Exists(fileLocation.Text + "\\BepInEx\\Plugins"))
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.Items.RemoveAt(0);
                }

                foreach (string file in Directory.GetFiles(fileLocation.Text + "\\BepInEx\\Plugins"))
                {
                    if (file.Contains(".dll"))
                    {
                        checkedListBox1.Items.Add(file.Split('\\')[file.Split('\\').Length - 1].Replace(".dll", ""));
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class GitHubAsset
    {
        public string url { get; set; }
        public string browser_download_url { get; set; }
    }

    public class GithubPackage
    {
        public string name { get; set; }
        public GitHubAsset[] assets { get; set; }
        public string Url { get; set; }
    }
}
