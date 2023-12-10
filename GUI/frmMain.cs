using AForge.Imaging.Filters;
using Carbon.Launcher.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;

namespace Carbon.Launcher.GUI
{
    public partial class frmMain : Form
    {
        public bool updateAvailable = true;
        public string rustDirectory = string.Empty;
        public int devblogIndex;
        public Item devblog => devblogs.ElementAt(devblogIndex);
        public IEnumerable<Item> devblogs;
        public Dictionary<string, Image> cachedImages = new();

        public enum PlayState
        {
            NotSetup,
            WrongDir,
            UpdateGame,
            PlayGame
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMain()
        {
            InitializeComponent();
            GetNews();
            CenterToScreen();

            Background.Controls.Add(DevblogTitlePanel);
            Background.Controls.Add(DevblogDescriptionPanel);
            Background.Controls.Add(ProgressBarPanel);
            Background.Controls.Add(VersionNumber);
            Background.Controls.Add(CopyrightPanel);

            Text = "Carbon Launcher";
            Icon = Resources.icon;
            VersionNumber.Text = (string)Settings.Default["CurrentVersion"];

            rustDirectory = Settings.Default["RustDirectory"].ToString();
            if (string.IsNullOrEmpty(rustDirectory))
                UpdatePlayButton(PlayState.NotSetup);
            else
            {
                if (IsRustDir(rustDirectory))
                {
                    if (updateAvailable)
                        UpdatePlayButton(PlayState.UpdateGame);
                    else
                        UpdatePlayButton(PlayState.PlayGame);
                }
                else
                    UpdatePlayButton(PlayState.WrongDir);
            }
        }

        public bool IsRustDir(string dir)
        {
            if (File.Exists(dir + "/Rust.exe"))
                return true;
            else
                return false;
        }

        public void UpdatePlayButton(PlayState state)
        {
            switch (state)
            {
                case PlayState.NotSetup:
                    PlayButton.ForeColor = Color.FromArgb(199, 152, 151);
                    PlayButton.BackColor = Color.FromArgb(150, 47, 32);
                    PlayButton.Text = "DIRECTORY NOT SETUP";
                    PlayButton.Enabled = false;
                    break;

                case PlayState.WrongDir:
                    PlayButton.ForeColor = Color.FromArgb(199, 152, 151);
                    PlayButton.BackColor = Color.FromArgb(150, 47, 32);
                    PlayButton.Text = "WRONG DIRECTORY";
                    PlayButton.Enabled = false;
                    break;

                case PlayState.UpdateGame:
                    PlayButton.ForeColor = Color.FromArgb(72, 154, 212);
                    PlayButton.BackColor = Color.FromArgb(29, 66, 95);
                    PlayButton.Text = "UPDATE";
                    PlayButton.Click += UpdateGame;
                    PlayButton.Enabled = true;
                    break;

                case PlayState.PlayGame:
                    PlayButton.ForeColor = Color.FromArgb(177, 244, 59);
                    PlayButton.BackColor = Color.FromArgb(115, 141, 69);
                    PlayButton.Text = "PLAY";
                    PlayButton.Enabled = true;
                    PlayButton.Click += PlayGame;
                    break;
            }
        }

        private string GetStartupParamaters()
        {
            string startupParams = "";
            if ((bool)Settings.Default["SilentCrashes"])
                startupParams += "-silent-crashes ";

            if ((bool)Settings.Default["SkipWarmup"])
                startupParams += "+prewarm \"false\" +global.skipassetwarmup_crashes \"1\" ";

            if ((bool)Settings.Default["LogFile"])
                startupParams += "-logfile output_log.txt ";

            if ((bool)Settings.Default["DisableGibs"])
                startupParams += "-effects.maxgibs \"-1\" ";

            return startupParams;
        }

        private void PlayGame(object sender, EventArgs e)
        {
            if (File.Exists($"{rustDirectory}/temp/winhttp.dll"))
                File.Move($"{rustDirectory}/temp/winhttp.dll", $"{rustDirectory}/winhttp.dll");

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            notifyIcon.Visible = true;

            using (Process proc = Process.Start($"{rustDirectory}/RustClient.exe", GetStartupParamaters()))
            {
                proc.WaitForExit();
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                notifyIcon.Visible = false;
                File.Move($"{rustDirectory}/winhttp.dll", $"{rustDirectory}/temp/winhttp.dll");
            }
        }
        private void UpdateGame(object sender, EventArgs e)
        {
            ProgressBarPanel.Visible = true;
            PlayButton.Enabled = false;
            using (WebClient client = new WebClient())
            {
                Uri uri = new Uri("https://cdn.discordapp.com/attachments/1153935427464601610/1182104524920459485/Carbon.Client.zip?ex=65837ba1&is=657106a1&hm=e5b3b63fbe1fa4ac86179417247fa3c93a67fbfbf67a9a03b2bf9976b7276ec1&");
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted);
                client.DownloadFileAsync(uri, $"{rustDirectory}/Carbon.Client.zip");
            }
        }

        void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            int percentage = Convert.ToInt32(bytesIn / totalBytes * 100);
            ProgressText.Text = "Downloading Carbon.Client.zip";
            ProgressPercent.Text = $"{percentage}%";
            ProgressBar.Value = percentage;
        }
        void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) => Unzip();

        private async void Unzip()
        {
            var filesExtracted = 0;
            string zipLocation = $@"{rustDirectory}\Carbon.Client.zip";
            using (ZipArchive archive = await Task.Run(() => ZipFile.OpenRead(zipLocation)))
            {
                int progress = 0;
                foreach (ZipArchiveEntry file in archive.Entries)
                {
                    if (string.IsNullOrEmpty(file.Name) || string.IsNullOrEmpty(file.FullName)) continue;

                    if (file.Name != file.FullName)
                    {
                        string directory = file.FullName.Replace(file.Name, "");
                        if (!Directory.Exists($@"{rustDirectory}\{directory}"))
                            Directory.CreateDirectory($@"{rustDirectory}\{directory}");
                    }


                    await Task.Run(() =>
                    {
                        file.ExtractToFile($@"{rustDirectory}\{file.FullName}", true);
                        filesExtracted++;
                        progress = Convert.ToInt32(100 * filesExtracted / archive.Entries.Count);
                    });

                    ProgressText.Text = $"Extracting {file.FullName}";
                    ProgressPercent.Text = $"{progress}%";
                    ProgressBar.Value = progress;
                }
            }

            // Delete the old DLL we moved on exit
            if (File.Exists($"{rustDirectory}/temp/winhttp.dll"))
                File.Delete($"{rustDirectory}/temp/winhttp.dll");

            // Delete the zip file we downloaded
            if (File.Exists(zipLocation))
                File.Delete(zipLocation);

            // Hide Progress Bar Panel
            ProgressBarPanel.Visible = false;

            // Make play button have the 'Play' Option
            UpdatePlayButton(PlayState.PlayGame);
        }

        private void GetNews()
        {
            WebClient wp = new WebClient();
            string url = "https://rust.facepunch.com/rss/news";
            string xmlResponse = wp.DownloadString(url);

            var xmlDoc = XDocument.Parse(xmlResponse);
            string jsonString = JsonConvert.SerializeXNode(xmlDoc);
            Root news = JsonConvert.DeserializeObject<Root>(jsonString);

            devblogs = news.rss.channel.item;
            DevblogButton.Click += DevblogButton_Click;

            ApplyDevblog(0);
        }

        public void ApplyDevblog(int index)
        {
            devblogIndex = index;

            if (devblogIndex > devblogs.Count() - 1)
            {
                devblogIndex = 0;
            }
            else if (devblogIndex < 0)
            {
                devblogIndex = devblogs.Count() - 1;
            }

            newsPagination.Text = $"{devblogIndex + 1:n0} / {devblogs.Count():n0}";

            var description = devblog.description.Split(new[] { "<br/>" }, StringSplitOptions.None);

            DevblogTitle.Text = devblog.title.ToUpper();
            DevblogDate.Text = devblog.pubDate.ToUpper();
            DevblogDescription.Text = description[1];

            var url = GetImageInHTMLString(description[0]);
            var identifier = Path.GetFileNameWithoutExtension(url);

            string GetTempFolder()
            {
                var temp = "temp";

                if (!Directory.Exists(temp))
                {
                    Directory.CreateDirectory(temp);
                }

                return temp;
            }

            if (cachedImages.TryGetValue(identifier, out var image))
            {
                Background.Image = image;
            }
            else
            {
                var cacheFile = Path.Combine(GetTempFolder(), $"{identifier}.dat");

                if (File.Exists(cacheFile))
                {
                    using var stream = new MemoryStream(File.ReadAllBytes(cacheFile));
                    Background.Image = cachedImages[identifier] = Bitmap.FromStream(stream);
                }
                else
                {
                    var client = new WebClient();
                    client.DownloadDataCompleted += (sender, args) =>
                    {
                        Task.Run(() =>
                        {
                            using var stream = new MemoryStream(args.Result);
                            using var originalImage = new Bitmap(stream);
                            var filter = new GaussianBlur
                            {
                                Size = 15
                            };

                            var finalImage = filter.Apply(originalImage);
                            finalImage.Save(cacheFile);

                            Background.Image = cachedImages[identifier] = finalImage;
                        });
                    };

                    client.DownloadDataAsync(new Uri(url));
                }
            }
        }

        private string GetImageInHTMLString(string htmlString)
        {
            string[] image = htmlString.Split('"');
            return image[1];
        }

        private void DevblogButton_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo(devblog.link));
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{rustDirectory}/winhttp.dll"))
                File.Move($"{rustDirectory}/winhttp.dll", $"{rustDirectory}/temp/winhttp.dll");

            Application.Exit();
        }

        private void SettingsButton_MouseEnter(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(40, 87, 123);
        }
        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(29, 66, 95);
        }
        private void DevblogButton_MouseEnter(object sender, EventArgs e)
        {
            DevblogButton.BackColor = Color.FromArgb(186, 61, 43);
        }
        private void DevblogButton_MouseLeave(object sender, EventArgs e)
        {
            DevblogButton.BackColor = Color.FromArgb(150, 47, 32);
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(186, 61, 43);
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(150, 47, 32);
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings(this);
            settings.ShowDialog();
        }

        private void NextNewsClick(object sender, EventArgs e)
        {
            ApplyDevblog(devblogIndex + 1);
        }
        private void PrevNewsClick(object sender, EventArgs e)
        {
            ApplyDevblog(devblogIndex - 1);
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}