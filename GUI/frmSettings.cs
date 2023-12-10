using Carbon.Launcher.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Carbon.Launcher.GUI
{
    public partial class frmSettings : Form
    {
        string rustDirectory = string.Empty;
        private frmMain _parent;

        public frmSettings(frmMain parent)
        {
            InitializeComponent();
            CenterToParent();
            _parent = parent;

            rustDirectory = Settings.Default["RustDirectory"].ToString();
            Console.WriteLine(rustDirectory);

            if (string.IsNullOrEmpty(rustDirectory))
                RustDirectory.Text = "Not Setup";
            else
                RustDirectory.Text = rustDirectory;

            UpdateToggle(SilentCrashes, (bool)Settings.Default["SilentCrashes"]);
            UpdateToggle(Prewarm, (bool)Settings.Default["SkipWarmup"]);
            UpdateToggle(LogFile, (bool)Settings.Default["LogFile"]);
            UpdateToggle(DisableGibs, (bool)Settings.Default["DisableGibs"]);
        }

        private void FindDirectory_Click(object sender, EventArgs e)
        {
            if (RustDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                if (_parent.IsRustDir(RustDirectoryDialog.SelectedPath))
                {
                    Settings.Default["RustDirectory"] = RustDirectoryDialog.SelectedPath;
                    Settings.Default.Save();

                    RustDirectory.Text = RustDirectoryDialog.SelectedPath;
                    rustDirectory = RustDirectoryDialog.SelectedPath;

                    if (_parent.updateAvailable)
                        _parent.UpdatePlayButton(frmMain.PlayState.UpdateGame);
                    else
                        _parent.UpdatePlayButton(frmMain.PlayState.PlayGame);
                }
                else
                {
                    MessageBox.Show("The directory selected is not a valid rust directory.");
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RustFindIcon_MouseEnter(object sender, EventArgs e)
        {
            FindDirectory.BackColor = Color.FromArgb(34, 79, 114);
            RustFindIcon.BackColor = Color.FromArgb(34, 79, 114);
        }

        private void RustFindIcon_MouseLeave(object sender, EventArgs e)
        {
            FindDirectory.BackColor = Color.FromArgb(29, 66, 95);
            RustFindIcon.BackColor = Color.FromArgb(29, 66, 95);
        }

        private void FindDirectory_MouseEnter(object sender, EventArgs e)
        {
            RustFindIcon.BackColor = Color.FromArgb(34, 79, 114);
        }

        private void FindDirectory_MouseHover(object sender, EventArgs e)
        {
            RustFindIcon.BackColor = Color.FromArgb(34, 79, 114);
        }
        private void FindDirectory_MouseLeave_1(object sender, EventArgs e)
        {
            RustFindIcon.Enabled = true;

            FindDirectory.BackColor = Color.FromArgb(29, 66, 95);
            RustFindIcon.BackColor = Color.FromArgb(29, 66, 95);
        }
        private void FindDirectory_MouseDown(object sender, MouseEventArgs e)
        {
            RustFindIcon.Enabled = false;
        }

        private void UpdateToggle(Button button, bool state)
        {
            if (state)
            {
                button.ForeColor = Color.FromArgb(166, 205, 99);
                button.BackColor = Color.FromArgb(61, 75, 39);
                button.Text = "ON";
            }
            else
            {
                button.ForeColor = Color.FromArgb(199, 152, 151);
                button.BackColor = Color.FromArgb(150, 47, 32);
                button.Text = "OFF";
            }
        }

        private void SilentCrashes_Click(object sender, EventArgs e)
        {
            Settings.Default["SilentCrashes"] = !(bool)Settings.Default["SilentCrashes"];
            Settings.Default.Save();
            UpdateToggle((Button)sender, (bool)Settings.Default["SilentCrashes"]);
        }

        private void Prewarm_Click(object sender, EventArgs e)
        {
            Settings.Default["SkipWarmup"] = !(bool)Settings.Default["SkipWarmup"];
            Settings.Default.Save();
            UpdateToggle((Button)sender, (bool)Settings.Default["SkipWarmup"]);
        }

        private void LogFile_Click(object sender, EventArgs e)
        {
            Settings.Default["LogFile"] = !(bool)Settings.Default["LogFile"];
            Settings.Default.Save();
            UpdateToggle((Button)sender, (bool)Settings.Default["LogFile"]);
        }

        private void DisableGibs_Click(object sender, EventArgs e)
        {
            Settings.Default["DisableGibs"] = !(bool)Settings.Default["DisableGibs"];
            Settings.Default.Save();
            UpdateToggle((Button)sender, (bool)Settings.Default["DisableGibs"]);
        }
    }
}
