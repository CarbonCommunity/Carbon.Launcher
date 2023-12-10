
namespace Carbon.Launcher.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Background = new System.Windows.Forms.PictureBox();
            this.DevblogDate = new System.Windows.Forms.Label();
            this.DevblogButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.DevblogDescriptionPanel = new System.Windows.Forms.Panel();
            this.DevblogDescription = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ProgressBarPanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressPercent = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.DevblogTitle = new System.Windows.Forms.Label();
            this.DevblogTitlePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newsPagination = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.CopyrightPanel = new System.Windows.Forms.Panel();
            this.VersionNumber = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            this.DevblogDescriptionPanel.SuspendLayout();
            this.ProgressBarPanel.SuspendLayout();
            this.DevblogTitlePanel.SuspendLayout();
            this.CopyrightPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            // 
            // Background
            // 
            this.Background.Image = global::Carbon.Launcher.Properties.Resources.rust_09_airdrop;
            this.Background.Location = new System.Drawing.Point(1, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(926, 530);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Background.TabIndex = 8;
            this.Background.TabStop = false;
            // 
            // DevblogDate
            // 
            this.DevblogDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.DevblogDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevblogDate.Location = new System.Drawing.Point(308, 203);
            this.DevblogDate.Name = "DevblogDate";
            this.DevblogDate.Padding = new System.Windows.Forms.Padding(10);
            this.DevblogDate.Size = new System.Drawing.Size(154, 33);
            this.DevblogDate.TabIndex = 16;
            this.DevblogDate.Text = "THURSDAY, JULY 6, 2023";
            this.DevblogDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevblogButton
            // 
            this.DevblogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(47)))), ((int)(((byte)(32)))));
            this.DevblogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevblogButton.FlatAppearance.BorderSize = 0;
            this.DevblogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevblogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevblogButton.ForeColor = System.Drawing.Color.White;
            this.DevblogButton.Location = new System.Drawing.Point(471, 203);
            this.DevblogButton.Name = "DevblogButton";
            this.DevblogButton.Size = new System.Drawing.Size(131, 33);
            this.DevblogButton.TabIndex = 17;
            this.DevblogButton.Text = "READ MORE";
            this.DevblogButton.UseVisualStyleBackColor = false;
            this.DevblogButton.MouseEnter += new System.EventHandler(this.DevblogButton_MouseEnter);
            this.DevblogButton.MouseLeave += new System.EventHandler(this.DevblogButton_MouseLeave);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Image = global::Carbon.Launcher.Properties.Resources.gear_icon;
            this.SettingsButton.Location = new System.Drawing.Point(202, 454);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(45, 57);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsButton.TabIndex = 13;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.MouseEnter += new System.EventHandler(this.SettingsButton_MouseEnter);
            this.SettingsButton.MouseLeave += new System.EventHandler(this.SettingsButton_MouseLeave);
            // 
            // DevblogDescriptionPanel
            // 
            this.DevblogDescriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.DevblogDescriptionPanel.Controls.Add(this.DevblogDescription);
            this.DevblogDescriptionPanel.Location = new System.Drawing.Point(277, 242);
            this.DevblogDescriptionPanel.Name = "DevblogDescriptionPanel";
            this.DevblogDescriptionPanel.Size = new System.Drawing.Size(370, 114);
            this.DevblogDescriptionPanel.TabIndex = 19;
            // 
            // DevblogDescription
            // 
            this.DevblogDescription.BackColor = System.Drawing.Color.Transparent;
            this.DevblogDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevblogDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevblogDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevblogDescription.Location = new System.Drawing.Point(0, 0);
            this.DevblogDescription.Name = "DevblogDescription";
            this.DevblogDescription.Padding = new System.Windows.Forms.Padding(3);
            this.DevblogDescription.Size = new System.Drawing.Size(370, 114);
            this.DevblogDescription.TabIndex = 0;
            this.DevblogDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(244)))), ((int)(((byte)(59)))));
            this.PlayButton.Location = new System.Drawing.Point(33, 454);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(172, 57);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseMnemonic = false;
            this.PlayButton.UseVisualStyleBackColor = false;
            // 
            // ProgressBarPanel
            // 
            this.ProgressBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarPanel.Controls.Add(this.ProgressBar);
            this.ProgressBarPanel.Controls.Add(this.ProgressPercent);
            this.ProgressBarPanel.Controls.Add(this.ProgressText);
            this.ProgressBarPanel.Location = new System.Drawing.Point(281, 454);
            this.ProgressBarPanel.Name = "ProgressBarPanel";
            this.ProgressBarPanel.Size = new System.Drawing.Size(523, 57);
            this.ProgressBarPanel.TabIndex = 22;
            this.ProgressBarPanel.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Black;
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(11, 25);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(499, 25);
            this.ProgressBar.TabIndex = 3;
            // 
            // ProgressPercent
            // 
            this.ProgressPercent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressPercent.ForeColor = System.Drawing.Color.Silver;
            this.ProgressPercent.Location = new System.Drawing.Point(468, 7);
            this.ProgressPercent.Name = "ProgressPercent";
            this.ProgressPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressPercent.Size = new System.Drawing.Size(42, 17);
            this.ProgressPercent.TabIndex = 2;
            this.ProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.ForeColor = System.Drawing.Color.Silver;
            this.ProgressText.Location = new System.Drawing.Point(8, 7);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(0, 17);
            this.ProgressText.TabIndex = 1;
            // 
            // DevblogTitle
            // 
            this.DevblogTitle.BackColor = System.Drawing.Color.Transparent;
            this.DevblogTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevblogTitle.Location = new System.Drawing.Point(0, 53);
            this.DevblogTitle.Name = "DevblogTitle";
            this.DevblogTitle.Size = new System.Drawing.Size(926, 70);
            this.DevblogTitle.TabIndex = 0;
            this.DevblogTitle.Text = "OLD RECOIL DEEP SEA";
            this.DevblogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevblogTitlePanel
            // 
            this.DevblogTitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.DevblogTitlePanel.Controls.Add(this.DevblogTitle);
            this.DevblogTitlePanel.Location = new System.Drawing.Point(1, 69);
            this.DevblogTitlePanel.Name = "DevblogTitlePanel";
            this.DevblogTitlePanel.Size = new System.Drawing.Size(926, 123);
            this.DevblogTitlePanel.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(494, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = ">";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NextNewsClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(397, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 33);
            this.button2.TabIndex = 24;
            this.button2.Text = "<";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.PrevNewsClick);
            // 
            // newsPagination
            // 
            this.newsPagination.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.newsPagination.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsPagination.Location = new System.Drawing.Point(426, 398);
            this.newsPagination.Name = "newsPagination";
            this.newsPagination.Padding = new System.Windows.Forms.Padding(10);
            this.newsPagination.Size = new System.Drawing.Size(68, 33);
            this.newsPagination.TabIndex = 25;
            this.newsPagination.Text = "1 / 20";
            this.newsPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Copyright
            // 
            this.Copyright.Location = new System.Drawing.Point(3, 2);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(157, 16);
            this.Copyright.TabIndex = 26;
            this.Copyright.Text = "(c) Carbon Community 2023";
            // 
            // CopyrightPanel
            // 
            this.CopyrightPanel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightPanel.Controls.Add(this.Copyright);
            this.CopyrightPanel.Location = new System.Drawing.Point(786, 512);
            this.CopyrightPanel.Name = "CopyrightPanel";
            this.CopyrightPanel.Size = new System.Drawing.Size(141, 18);
            this.CopyrightPanel.TabIndex = 27;
            // 
            // VersionNumber
            // 
            this.VersionNumber.BackColor = System.Drawing.Color.Transparent;
            this.VersionNumber.Location = new System.Drawing.Point(854, 497);
            this.VersionNumber.Name = "VersionNumber";
            this.VersionNumber.Size = new System.Drawing.Size(70, 14);
            this.VersionNumber.TabIndex = 28;
            this.VersionNumber.Text = "v2023.01.01";
            this.VersionNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Location = new System.Drawing.Point(1, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(899, 30);
            this.TopPanel.TabIndex = 29;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Carbon Client Launcher";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(926, 530);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.VersionNumber);
            this.Controls.Add(this.CopyrightPanel);
            this.Controls.Add(this.newsPagination);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProgressBarPanel);
            this.Controls.Add(this.DevblogTitlePanel);
            this.Controls.Add(this.DevblogDescriptionPanel);
            this.Controls.Add(this.DevblogButton);
            this.Controls.Add(this.DevblogDate);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Background);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            this.DevblogDescriptionPanel.ResumeLayout(false);
            this.ProgressBarPanel.ResumeLayout(false);
            this.ProgressBarPanel.PerformLayout();
            this.DevblogTitlePanel.ResumeLayout(false);
            this.CopyrightPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label VersionNumber;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Panel CopyrightPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label newsPagination;

        #endregion
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label DevblogDate;
        private System.Windows.Forms.Button DevblogButton;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.Panel DevblogDescriptionPanel;
        private System.Windows.Forms.Label DevblogDescription;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Panel ProgressBarPanel;
        private System.Windows.Forms.Label ProgressPercent;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.Label DevblogTitle;
        private System.Windows.Forms.Panel DevblogTitlePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}
