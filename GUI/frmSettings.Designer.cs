
namespace Carbon.Launcher.GUI
{
    partial class frmSettings
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
            this.SettingsText = new System.Windows.Forms.Label();
            this.RustDirectoryText = new System.Windows.Forms.Label();
            this.RustDirectory = new System.Windows.Forms.Label();
            this.FindDirectory = new System.Windows.Forms.Button();
            this.RustFindIcon = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RustDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SilentCrashText = new System.Windows.Forms.Label();
            this.SilentCrashes = new System.Windows.Forms.Button();
            this.SilentCrashPanel = new System.Windows.Forms.Panel();
            this.PrewarmPanel = new System.Windows.Forms.Panel();
            this.PrewarmText = new System.Windows.Forms.Label();
            this.Prewarm = new System.Windows.Forms.Button();
            this.Underline = new System.Windows.Forms.Panel();
            this.LogFilePanel = new System.Windows.Forms.Panel();
            this.LogFileText = new System.Windows.Forms.Label();
            this.LogFile = new System.Windows.Forms.Button();
            this.DisableGibsPanel = new System.Windows.Forms.Panel();
            this.DisableGibsText = new System.Windows.Forms.Label();
            this.DisableGibs = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelText = new System.Windows.Forms.Label();
            this.ConnectPanel = new System.Windows.Forms.Panel();
            this.ConnectText = new System.Windows.Forms.Label();
            this.ConnectIP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RustFindIcon)).BeginInit();
            this.SilentCrashPanel.SuspendLayout();
            this.PrewarmPanel.SuspendLayout();
            this.LogFilePanel.SuspendLayout();
            this.DisableGibsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.ConnectPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsText
            // 
            this.SettingsText.AutoSize = true;
            this.SettingsText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsText.ForeColor = System.Drawing.Color.White;
            this.SettingsText.Location = new System.Drawing.Point(34, 49);
            this.SettingsText.Name = "SettingsText";
            this.SettingsText.Size = new System.Drawing.Size(126, 32);
            this.SettingsText.TabIndex = 0;
            this.SettingsText.Text = "SETTINGS";
            // 
            // RustDirectoryText
            // 
            this.RustDirectoryText.AutoSize = true;
            this.RustDirectoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RustDirectoryText.ForeColor = System.Drawing.Color.White;
            this.RustDirectoryText.Location = new System.Drawing.Point(37, 97);
            this.RustDirectoryText.Name = "RustDirectoryText";
            this.RustDirectoryText.Size = new System.Drawing.Size(124, 20);
            this.RustDirectoryText.TabIndex = 1;
            this.RustDirectoryText.Text = "Rust Directory";
            // 
            // RustDirectory
            // 
            this.RustDirectory.AutoEllipsis = true;
            this.RustDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RustDirectory.ForeColor = System.Drawing.Color.DimGray;
            this.RustDirectory.Location = new System.Drawing.Point(37, 126);
            this.RustDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.RustDirectory.Name = "RustDirectory";
            this.RustDirectory.Size = new System.Drawing.Size(321, 21);
            this.RustDirectory.TabIndex = 2;
            this.RustDirectory.Text = "B:\\SteamLibrary\\steamapps\\common\\Rust";
            // 
            // FindDirectory
            // 
            this.FindDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.FindDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindDirectory.FlatAppearance.BorderSize = 0;
            this.FindDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(154)))), ((int)(((byte)(212)))));
            this.FindDirectory.Location = new System.Drawing.Point(167, 98);
            this.FindDirectory.Name = "FindDirectory";
            this.FindDirectory.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.FindDirectory.Size = new System.Drawing.Size(75, 23);
            this.FindDirectory.TabIndex = 3;
            this.FindDirectory.Text = "FIND";
            this.FindDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FindDirectory.UseVisualStyleBackColor = false;
            this.FindDirectory.Click += new System.EventHandler(this.FindDirectory_Click);
            this.FindDirectory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FindDirectory_MouseDown);
            this.FindDirectory.MouseEnter += new System.EventHandler(this.FindDirectory_MouseEnter);
            this.FindDirectory.MouseLeave += new System.EventHandler(this.FindDirectory_MouseLeave_1);
            this.FindDirectory.MouseHover += new System.EventHandler(this.FindDirectory_MouseHover);
            // 
            // RustFindIcon
            // 
            this.RustFindIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.RustFindIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RustFindIcon.Enabled = false;
            this.RustFindIcon.Image = global::Carbon.Launcher.Properties.Resources.search_icon;
            this.RustFindIcon.Location = new System.Drawing.Point(171, 99);
            this.RustFindIcon.Name = "RustFindIcon";
            this.RustFindIcon.Size = new System.Drawing.Size(21, 21);
            this.RustFindIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RustFindIcon.TabIndex = 4;
            this.RustFindIcon.TabStop = false;
            this.RustFindIcon.MouseEnter += new System.EventHandler(this.RustFindIcon_MouseEnter);
            this.RustFindIcon.MouseLeave += new System.EventHandler(this.RustFindIcon_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(47)))), ((int)(((byte)(32)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ExitButton.Location = new System.Drawing.Point(899, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 30);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SilentCrashText
            // 
            this.SilentCrashText.Dock = System.Windows.Forms.DockStyle.Left;
            this.SilentCrashText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilentCrashText.ForeColor = System.Drawing.Color.White;
            this.SilentCrashText.Location = new System.Drawing.Point(0, 0);
            this.SilentCrashText.Name = "SilentCrashText";
            this.SilentCrashText.Size = new System.Drawing.Size(134, 33);
            this.SilentCrashText.TabIndex = 15;
            this.SilentCrashText.Text = "Silent Crashes";
            this.SilentCrashText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SilentCrashes
            // 
            this.SilentCrashes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(39)))));
            this.SilentCrashes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilentCrashes.Dock = System.Windows.Forms.DockStyle.Right;
            this.SilentCrashes.FlatAppearance.BorderSize = 0;
            this.SilentCrashes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilentCrashes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilentCrashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(205)))), ((int)(((byte)(99)))));
            this.SilentCrashes.Location = new System.Drawing.Point(181, 0);
            this.SilentCrashes.Name = "SilentCrashes";
            this.SilentCrashes.Size = new System.Drawing.Size(114, 33);
            this.SilentCrashes.TabIndex = 16;
            this.SilentCrashes.Text = "ON";
            this.SilentCrashes.UseVisualStyleBackColor = false;
            this.SilentCrashes.Click += new System.EventHandler(this.SilentCrashes_Click);
            // 
            // SilentCrashPanel
            // 
            this.SilentCrashPanel.Controls.Add(this.SilentCrashText);
            this.SilentCrashPanel.Controls.Add(this.SilentCrashes);
            this.SilentCrashPanel.Location = new System.Drawing.Point(40, 175);
            this.SilentCrashPanel.Name = "SilentCrashPanel";
            this.SilentCrashPanel.Size = new System.Drawing.Size(295, 33);
            this.SilentCrashPanel.TabIndex = 17;
            // 
            // PrewarmPanel
            // 
            this.PrewarmPanel.Controls.Add(this.PrewarmText);
            this.PrewarmPanel.Controls.Add(this.Prewarm);
            this.PrewarmPanel.Location = new System.Drawing.Point(40, 214);
            this.PrewarmPanel.Name = "PrewarmPanel";
            this.PrewarmPanel.Size = new System.Drawing.Size(295, 33);
            this.PrewarmPanel.TabIndex = 18;
            // 
            // PrewarmText
            // 
            this.PrewarmText.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrewarmText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrewarmText.ForeColor = System.Drawing.Color.White;
            this.PrewarmText.Location = new System.Drawing.Point(0, 0);
            this.PrewarmText.Name = "PrewarmText";
            this.PrewarmText.Size = new System.Drawing.Size(153, 33);
            this.PrewarmText.TabIndex = 15;
            this.PrewarmText.Text = "Skip Warmup";
            this.PrewarmText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Prewarm
            // 
            this.Prewarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(39)))));
            this.Prewarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prewarm.Dock = System.Windows.Forms.DockStyle.Right;
            this.Prewarm.FlatAppearance.BorderSize = 0;
            this.Prewarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prewarm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prewarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(205)))), ((int)(((byte)(99)))));
            this.Prewarm.Location = new System.Drawing.Point(181, 0);
            this.Prewarm.Name = "Prewarm";
            this.Prewarm.Size = new System.Drawing.Size(114, 33);
            this.Prewarm.TabIndex = 16;
            this.Prewarm.Text = "ON";
            this.Prewarm.UseVisualStyleBackColor = false;
            this.Prewarm.Click += new System.EventHandler(this.Prewarm_Click);
            // 
            // Underline
            // 
            this.Underline.BackColor = System.Drawing.Color.White;
            this.Underline.Location = new System.Drawing.Point(40, 84);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(171, 2);
            this.Underline.TabIndex = 19;
            // 
            // LogFilePanel
            // 
            this.LogFilePanel.Controls.Add(this.LogFileText);
            this.LogFilePanel.Controls.Add(this.LogFile);
            this.LogFilePanel.Location = new System.Drawing.Point(41, 253);
            this.LogFilePanel.Name = "LogFilePanel";
            this.LogFilePanel.Size = new System.Drawing.Size(295, 33);
            this.LogFilePanel.TabIndex = 19;
            // 
            // LogFileText
            // 
            this.LogFileText.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogFileText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogFileText.ForeColor = System.Drawing.Color.White;
            this.LogFileText.Location = new System.Drawing.Point(0, 0);
            this.LogFileText.Name = "LogFileText";
            this.LogFileText.Size = new System.Drawing.Size(153, 33);
            this.LogFileText.TabIndex = 15;
            this.LogFileText.Text = "Log File";
            this.LogFileText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogFile
            // 
            this.LogFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(39)))));
            this.LogFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogFile.FlatAppearance.BorderSize = 0;
            this.LogFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(205)))), ((int)(((byte)(99)))));
            this.LogFile.Location = new System.Drawing.Point(181, 0);
            this.LogFile.Name = "LogFile";
            this.LogFile.Size = new System.Drawing.Size(114, 33);
            this.LogFile.TabIndex = 16;
            this.LogFile.Text = "ON";
            this.LogFile.UseVisualStyleBackColor = false;
            this.LogFile.Click += new System.EventHandler(this.LogFile_Click);
            // 
            // DisableGibsPanel
            // 
            this.DisableGibsPanel.Controls.Add(this.DisableGibsText);
            this.DisableGibsPanel.Controls.Add(this.DisableGibs);
            this.DisableGibsPanel.Location = new System.Drawing.Point(41, 292);
            this.DisableGibsPanel.Name = "DisableGibsPanel";
            this.DisableGibsPanel.Size = new System.Drawing.Size(295, 33);
            this.DisableGibsPanel.TabIndex = 19;
            // 
            // DisableGibsText
            // 
            this.DisableGibsText.Dock = System.Windows.Forms.DockStyle.Left;
            this.DisableGibsText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableGibsText.ForeColor = System.Drawing.Color.White;
            this.DisableGibsText.Location = new System.Drawing.Point(0, 0);
            this.DisableGibsText.Name = "DisableGibsText";
            this.DisableGibsText.Size = new System.Drawing.Size(153, 33);
            this.DisableGibsText.TabIndex = 15;
            this.DisableGibsText.Text = "Disable Gibs";
            this.DisableGibsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisableGibs
            // 
            this.DisableGibs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(39)))));
            this.DisableGibs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisableGibs.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisableGibs.FlatAppearance.BorderSize = 0;
            this.DisableGibs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableGibs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableGibs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(205)))), ((int)(((byte)(99)))));
            this.DisableGibs.Location = new System.Drawing.Point(181, 0);
            this.DisableGibs.Name = "DisableGibs";
            this.DisableGibs.Size = new System.Drawing.Size(114, 33);
            this.DisableGibs.TabIndex = 16;
            this.DisableGibs.Text = "ON";
            this.DisableGibs.UseVisualStyleBackColor = false;
            this.DisableGibs.Click += new System.EventHandler(this.DisableGibs_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TopPanelText);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(899, 30);
            this.TopPanel.TabIndex = 20;
            // 
            // TopPanelText
            // 
            this.TopPanelText.AutoSize = true;
            this.TopPanelText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TopPanelText.ForeColor = System.Drawing.Color.White;
            this.TopPanelText.Location = new System.Drawing.Point(11, 8);
            this.TopPanelText.Name = "TopPanelText";
            this.TopPanelText.Size = new System.Drawing.Size(152, 17);
            this.TopPanelText.TabIndex = 0;
            this.TopPanelText.Text = "Carbon Client Launcher";
            // 
            // ConnectPanel
            // 
            this.ConnectPanel.Controls.Add(this.ConnectText);
            this.ConnectPanel.Controls.Add(this.panel1);
            this.ConnectPanel.Location = new System.Drawing.Point(41, 355);
            this.ConnectPanel.Name = "ConnectPanel";
            this.ConnectPanel.Size = new System.Drawing.Size(295, 58);
            this.ConnectPanel.TabIndex = 20;
            // 
            // ConnectText
            // 
            this.ConnectText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectText.ForeColor = System.Drawing.Color.White;
            this.ConnectText.Location = new System.Drawing.Point(0, 0);
            this.ConnectText.Name = "ConnectText";
            this.ConnectText.Size = new System.Drawing.Size(295, 33);
            this.ConnectText.TabIndex = 15;
            this.ConnectText.Text = "Auto Connect";
            this.ConnectText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConnectIP
            // 
            this.ConnectIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ConnectIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectIP.ForeColor = System.Drawing.Color.White;
            this.ConnectIP.Location = new System.Drawing.Point(3, 0);
            this.ConnectIP.Name = "ConnectIP";
            this.ConnectIP.Size = new System.Drawing.Size(278, 22);
            this.ConnectIP.TabIndex = 16;
            this.ConnectIP.Text = " 127.0.0.1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.ConnectIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 22);
            this.panel1.TabIndex = 17;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(926, 530);
            this.Controls.Add(this.ConnectPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.DisableGibsPanel);
            this.Controls.Add(this.LogFilePanel);
            this.Controls.Add(this.SilentCrashPanel);
            this.Controls.Add(this.PrewarmPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RustFindIcon);
            this.Controls.Add(this.FindDirectory);
            this.Controls.Add(this.RustDirectory);
            this.Controls.Add(this.RustDirectoryText);
            this.Controls.Add(this.SettingsText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.RustFindIcon)).EndInit();
            this.SilentCrashPanel.ResumeLayout(false);
            this.PrewarmPanel.ResumeLayout(false);
            this.LogFilePanel.ResumeLayout(false);
            this.DisableGibsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ConnectPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel Underline;

        #endregion

        private System.Windows.Forms.Label SettingsText;
        private System.Windows.Forms.Label RustDirectoryText;
        private System.Windows.Forms.Label RustDirectory;
        private System.Windows.Forms.Button FindDirectory;
        private System.Windows.Forms.PictureBox RustFindIcon;
        internal System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FolderBrowserDialog RustDirectoryDialog;
        private System.Windows.Forms.Label SilentCrashText;
        private System.Windows.Forms.Button SilentCrashes;
        private System.Windows.Forms.Panel SilentCrashPanel;
        private System.Windows.Forms.Panel PrewarmPanel;
        private System.Windows.Forms.Label PrewarmText;
        private System.Windows.Forms.Button Prewarm;
        private System.Windows.Forms.Panel LogFilePanel;
        private System.Windows.Forms.Label LogFileText;
        private System.Windows.Forms.Button LogFile;
        private System.Windows.Forms.Panel DisableGibsPanel;
        private System.Windows.Forms.Label DisableGibsText;
        private System.Windows.Forms.Button DisableGibs;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TopPanelText;
        private System.Windows.Forms.Panel ConnectPanel;
        private System.Windows.Forms.TextBox ConnectIP;
        private System.Windows.Forms.Label ConnectText;
        private System.Windows.Forms.Panel panel1;
    }
}
