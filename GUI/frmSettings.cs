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

        private void FindDirectory_MouseLeave(object sender, EventArgs e)
        {
            FindDirectory.BackColor = Color.FromArgb(29, 66, 95);
            RustFindIcon.BackColor = Color.FromArgb(29, 66, 95);
        }
    }
}
