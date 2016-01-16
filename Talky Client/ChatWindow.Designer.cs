namespace Talky_Client
{
    partial class ChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this._controlPanel = new System.Windows.Forms.Panel();
            this._iconImage = new System.Windows.Forms.PictureBox();
            this._channelsButton = new System.Windows.Forms.Button();
            this._disconnectButton = new System.Windows.Forms.Button();
            this._titleLabel = new System.Windows.Forms.Label();
            this._informationPanel = new System.Windows.Forms.Panel();
            this._accountRoleLabel = new System.Windows.Forms.Label();
            this._accountUsernameLabel = new System.Windows.Forms.Label();
            this._accountLabel = new System.Windows.Forms.Label();
            this._messageInput = new System.Windows.Forms.TextBox();
            this._sendButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._messageLog = new System.Windows.Forms.RichTextBox();
            this._clientListComboBox = new System.Windows.Forms.ComboBox();
            this._controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._iconImage)).BeginInit();
            this._informationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _controlPanel
            // 
            this._controlPanel.BackColor = System.Drawing.Color.White;
            this._controlPanel.Controls.Add(this._iconImage);
            this._controlPanel.Controls.Add(this._channelsButton);
            this._controlPanel.Controls.Add(this._disconnectButton);
            this._controlPanel.Controls.Add(this._titleLabel);
            this._controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._controlPanel.Location = new System.Drawing.Point(0, 0);
            this._controlPanel.Name = "_controlPanel";
            this._controlPanel.Size = new System.Drawing.Size(954, 44);
            this._controlPanel.TabIndex = 0;
            // 
            // _iconImage
            // 
            this._iconImage.Image = ((System.Drawing.Image)(resources.GetObject("_iconImage.Image")));
            this._iconImage.Location = new System.Drawing.Point(12, 6);
            this._iconImage.Name = "_iconImage";
            this._iconImage.Size = new System.Drawing.Size(32, 32);
            this._iconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._iconImage.TabIndex = 7;
            this._iconImage.TabStop = false;
            // 
            // _channelsButton
            // 
            this._channelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._channelsButton.Location = new System.Drawing.Point(749, 10);
            this._channelsButton.Name = "_channelsButton";
            this._channelsButton.Size = new System.Drawing.Size(92, 26);
            this._channelsButton.TabIndex = 6;
            this._channelsButton.Text = "Channels";
            this._channelsButton.UseVisualStyleBackColor = true;
            this._channelsButton.Click += new System.EventHandler(this._channelsButton_Click);
            // 
            // _disconnectButton
            // 
            this._disconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._disconnectButton.Location = new System.Drawing.Point(850, 10);
            this._disconnectButton.Name = "_disconnectButton";
            this._disconnectButton.Size = new System.Drawing.Size(92, 26);
            this._disconnectButton.TabIndex = 5;
            this._disconnectButton.Text = "Disconnect";
            this._disconnectButton.UseVisualStyleBackColor = true;
            this._disconnectButton.Click += new System.EventHandler(this._disconnectButton_Click);
            // 
            // _titleLabel
            // 
            this._titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.Location = new System.Drawing.Point(50, 9);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(135, 24);
            this._titleLabel.TabIndex = 0;
            this._titleLabel.Text = "Connecting...";
            this._titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _informationPanel
            // 
            this._informationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this._informationPanel.Controls.Add(this._clientListComboBox);
            this._informationPanel.Controls.Add(this._accountRoleLabel);
            this._informationPanel.Controls.Add(this._accountUsernameLabel);
            this._informationPanel.Controls.Add(this._accountLabel);
            this._informationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._informationPanel.Location = new System.Drawing.Point(749, 44);
            this._informationPanel.Name = "_informationPanel";
            this._informationPanel.Size = new System.Drawing.Size(205, 429);
            this._informationPanel.TabIndex = 1;
            // 
            // _accountRoleLabel
            // 
            this._accountRoleLabel.AutoSize = true;
            this._accountRoleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accountRoleLabel.Location = new System.Drawing.Point(9, 53);
            this._accountRoleLabel.Name = "_accountRoleLabel";
            this._accountRoleLabel.Size = new System.Drawing.Size(44, 18);
            this._accountRoleLabel.TabIndex = 19;
            this._accountRoleLabel.Text = "Role";
            this._accountRoleLabel.Visible = false;
            // 
            // _accountUsernameLabel
            // 
            this._accountUsernameLabel.AutoSize = true;
            this._accountUsernameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accountUsernameLabel.Location = new System.Drawing.Point(9, 35);
            this._accountUsernameLabel.Name = "_accountUsernameLabel";
            this._accountUsernameLabel.Size = new System.Drawing.Size(90, 18);
            this._accountUsernameLabel.TabIndex = 18;
            this._accountUsernameLabel.Text = "Username";
            this._accountUsernameLabel.Visible = false;
            // 
            // _accountLabel
            // 
            this._accountLabel.AutoSize = true;
            this._accountLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accountLabel.Location = new System.Drawing.Point(9, 15);
            this._accountLabel.Name = "_accountLabel";
            this._accountLabel.Size = new System.Drawing.Size(78, 18);
            this._accountLabel.TabIndex = 17;
            this._accountLabel.Text = "Account";
            this._accountLabel.Visible = false;
            // 
            // _messageInput
            // 
            this._messageInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._messageInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._messageInput.Location = new System.Drawing.Point(12, 435);
            this._messageInput.Name = "_messageInput";
            this._messageInput.Size = new System.Drawing.Size(605, 26);
            this._messageInput.TabIndex = 3;
            // 
            // _sendButton
            // 
            this._sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._sendButton.Location = new System.Drawing.Point(623, 435);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(120, 26);
            this._sendButton.TabIndex = 4;
            this._sendButton.Text = "Send Message";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this._sendButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._messageLog);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 364);
            this.panel1.TabIndex = 2;
            // 
            // _messageLog
            // 
            this._messageLog.BackColor = System.Drawing.Color.White;
            this._messageLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._messageLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._messageLog.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._messageLog.HideSelection = false;
            this._messageLog.Location = new System.Drawing.Point(0, 0);
            this._messageLog.Name = "_messageLog";
            this._messageLog.ReadOnly = true;
            this._messageLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this._messageLog.Size = new System.Drawing.Size(729, 362);
            this._messageLog.TabIndex = 6;
            this._messageLog.Text = "";
            // 
            // _clientListComboBox
            // 
            this._clientListComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._clientListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._clientListComboBox.Enabled = false;
            this._clientListComboBox.FormattingEnabled = true;
            this._clientListComboBox.Items.AddRange(new object[] {
            "Loading..."});
            this._clientListComboBox.Location = new System.Drawing.Point(12, 74);
            this._clientListComboBox.Name = "_clientListComboBox";
            this._clientListComboBox.Size = new System.Drawing.Size(181, 361);
            this._clientListComboBox.TabIndex = 20;
            // 
            // ChatWindow
            // 
            this.AcceptButton = this._sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 473);
            this.Controls.Add(this._sendButton);
            this.Controls.Add(this._messageInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._informationPanel);
            this.Controls.Add(this._controlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 512);
            this.Name = "ChatWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ChatWindow_Shown);
            this._controlPanel.ResumeLayout(false);
            this._controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._iconImage)).EndInit();
            this._informationPanel.ResumeLayout(false);
            this._informationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _controlPanel;
        private System.Windows.Forms.Panel _informationPanel;
        private System.Windows.Forms.TextBox _messageInput;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.Button _channelsButton;
        private System.Windows.Forms.Button _disconnectButton;
        private System.Windows.Forms.PictureBox _iconImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox _messageLog;
        private System.Windows.Forms.Label _accountRoleLabel;
        private System.Windows.Forms.Label _accountUsernameLabel;
        private System.Windows.Forms.Label _accountLabel;
        private System.Windows.Forms.ComboBox _clientListComboBox;
    }
}