
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
            this.ProgressPercent = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.DevblogTitle = new System.Windows.Forms.Label();
            this.DevblogTitlePanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new Carbon.Launcher.GUI.CustomControls.CarbonProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            this.DevblogDescriptionPanel.SuspendLayout();
            this.ProgressBarPanel.SuspendLayout();
            this.DevblogTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Carbon Launcher";
            // 
            // Background
            // 
            this.Background.Image = global::Carbon.Launcher.Properties.Resources.rust_09_airdrop;
            this.Background.Location = new System.Drawing.Point(1, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(926, 530);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Background.TabIndex = 8;
            this.Background.TabStop = false;
            this.Background.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Background_MouseClick);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
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
            this.DevblogButton.Text = "DEVBLOG";
            this.DevblogButton.UseVisualStyleBackColor = false;
            this.DevblogButton.MouseEnter += new System.EventHandler(this.DevblogButton_MouseEnter);
            this.DevblogButton.MouseLeave += new System.EventHandler(this.DevblogButton_MouseLeave);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Image = global::Carbon.Launcher.Properties.Resources.gear_icon;
            this.SettingsButton.Location = new System.Drawing.Point(211, 454);
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
            this.DevblogDescription.Text = "This month we celebrate Rust\'s 10th birthday. Birthday event, throw back items to" +
    " Rust Legacy, new weapon, twitch drops, 20 QOL features, and much more!";
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
            this.ExitButton.Location = new System.Drawing.Point(867, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 40);
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
            this.DevblogTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevblogTitle.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevblogTitle.Location = new System.Drawing.Point(0, 0);
            this.DevblogTitle.Name = "DevblogTitle";
            this.DevblogTitle.Size = new System.Drawing.Size(257, 123);
            this.DevblogTitle.TabIndex = 0;
            this.DevblogTitle.Text = "OLD RECOIL DEEP SEA";
            this.DevblogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevblogTitlePanel
            // 
            this.DevblogTitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.DevblogTitlePanel.Controls.Add(this.DevblogTitle);
            this.DevblogTitlePanel.Location = new System.Drawing.Point(329, 69);
            this.DevblogTitlePanel.Name = "DevblogTitlePanel";
            this.DevblogTitlePanel.Size = new System.Drawing.Size(257, 123);
            this.DevblogTitlePanel.TabIndex = 20;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Black;
            this.ProgressBar.Location = new System.Drawing.Point(9, 27);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(501, 23);
            this.ProgressBar.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(926, 530);
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
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            this.DevblogDescriptionPanel.ResumeLayout(false);
            this.ProgressBarPanel.ResumeLayout(false);
            this.ProgressBarPanel.PerformLayout();
            this.DevblogTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

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
        private CustomControls.CarbonProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressPercent;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.Label DevblogTitle;
        private System.Windows.Forms.Panel DevblogTitlePanel;
    }
}