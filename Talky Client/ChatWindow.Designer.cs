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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._statusToolStripTagLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._messageInput = new System.Windows.Forms.TextBox();
            this._output = new System.Windows.Forms.TextBox();
            this._usernameTagLabel = new System.Windows.Forms.Label();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._channelLabel = new System.Windows.Forms.Label();
            this._channelTagLabel = new System.Windows.Forms.Label();
            this._sendButton = new System.Windows.Forms.Button();
            this._channelListButton = new System.Windows.Forms.Button();
            this._disconnectButton = new System.Windows.Forms.Button();
            this._accountUsernameLabel = new System.Windows.Forms.Label();
            this._accountLabel = new System.Windows.Forms.Label();
            this._accountRoleLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusToolStripTagLabel,
            this._statusToolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _statusToolStripTagLabel
            // 
            this._statusToolStripTagLabel.Name = "_statusToolStripTagLabel";
            this._statusToolStripTagLabel.Size = new System.Drawing.Size(42, 17);
            this._statusToolStripTagLabel.Text = "Status:";
            // 
            // _statusToolStripLabel
            // 
            this._statusToolStripLabel.Name = "_statusToolStripLabel";
            this._statusToolStripLabel.Size = new System.Drawing.Size(50, 17);
            this._statusToolStripLabel.Text = "Loading";
            // 
            // _messageInput
            // 
            this._messageInput.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._messageInput.Location = new System.Drawing.Point(12, 411);
            this._messageInput.Name = "_messageInput";
            this._messageInput.Size = new System.Drawing.Size(588, 21);
            this._messageInput.TabIndex = 2;
            // 
            // _output
            // 
            this._output.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._output.Location = new System.Drawing.Point(12, 12);
            this._output.Multiline = true;
            this._output.Name = "_output";
            this._output.ReadOnly = true;
            this._output.Size = new System.Drawing.Size(588, 393);
            this._output.TabIndex = 3;
            // 
            // _usernameTagLabel
            // 
            this._usernameTagLabel.AutoSize = true;
            this._usernameTagLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._usernameTagLabel.Location = new System.Drawing.Point(610, 27);
            this._usernameTagLabel.Name = "_usernameTagLabel";
            this._usernameTagLabel.Size = new System.Drawing.Size(98, 18);
            this._usernameTagLabel.TabIndex = 4;
            this._usernameTagLabel.Text = "Username";
            // 
            // _usernameLabel
            // 
            this._usernameLabel.AutoSize = true;
            this._usernameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._usernameLabel.Location = new System.Drawing.Point(610, 47);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(90, 18);
            this._usernameLabel.TabIndex = 5;
            this._usernameLabel.Text = "Loading...";
            // 
            // _channelLabel
            // 
            this._channelLabel.AutoSize = true;
            this._channelLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._channelLabel.Location = new System.Drawing.Point(610, 100);
            this._channelLabel.Name = "_channelLabel";
            this._channelLabel.Size = new System.Drawing.Size(90, 18);
            this._channelLabel.TabIndex = 7;
            this._channelLabel.Text = "Loading...";
            // 
            // _channelTagLabel
            // 
            this._channelTagLabel.AutoSize = true;
            this._channelTagLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._channelTagLabel.Location = new System.Drawing.Point(610, 80);
            this._channelTagLabel.Name = "_channelTagLabel";
            this._channelTagLabel.Size = new System.Drawing.Size(79, 18);
            this._channelTagLabel.TabIndex = 6;
            this._channelTagLabel.Text = "Channel";
            // 
            // _sendButton
            // 
            this._sendButton.Location = new System.Drawing.Point(606, 410);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(179, 23);
            this._sendButton.TabIndex = 0;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this._sendButton_Click);
            // 
            // _channelListButton
            // 
            this._channelListButton.Location = new System.Drawing.Point(606, 381);
            this._channelListButton.Name = "_channelListButton";
            this._channelListButton.Size = new System.Drawing.Size(179, 23);
            this._channelListButton.TabIndex = 8;
            this._channelListButton.Text = "Channel List";
            this._channelListButton.UseVisualStyleBackColor = true;
            this._channelListButton.Click += new System.EventHandler(this._channelListButton_Click);
            // 
            // _disconnectButton
            // 
            this._disconnectButton.Location = new System.Drawing.Point(606, 352);
            this._disconnectButton.Name = "_disconnectButton";
            this._disconnectButton.Size = new System.Drawing.Size(179, 23);
            this._disconnectButton.TabIndex = 9;
            this._disconnectButton.Text = "Disconnect";
            this._disconnectButton.UseVisualStyleBackColor = true;
            this._disconnectButton.Click += new System.EventHandler(this._disconnectButton_Click);
            // 
            // _accountUsernameLabel
            // 
            this._accountUsernameLabel.AutoSize = true;
            this._accountUsernameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accountUsernameLabel.Location = new System.Drawing.Point(610, 153);
            this._accountUsernameLabel.Name = "_accountUsernameLabel";
            this._accountUsernameLabel.Size = new System.Drawing.Size(90, 18);
            this._accountUsernameLabel.TabIndex = 11;
            this._accountUsernameLabel.Text = "Username";
            this._accountUsernameLabel.Visible = false;
            // 
            // _accountLabel
            // 
            this._accountLabel.AutoSize = true;
            this._accountLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accountLabel.Location = new System.Drawing.Point(610, 133);
            this._accountLabel.Name = "_accountLabel";
            this._accountLabel.Size = new System.Drawing.Size(78, 18);
            this._accountLabel.TabIndex = 10;
            this._accountLabel.Text = "Account";
            this._accountLabel.Visible = false;
            // 
            // _accountRoleLabel
            // 
            this._accountRoleLabel.AutoSize = true;
            this._accountRoleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._accountRoleLabel.Location = new System.Drawing.Point(610, 171);
            this._accountRoleLabel.Name = "_accountRoleLabel";
            this._accountRoleLabel.Size = new System.Drawing.Size(44, 18);
            this._accountRoleLabel.TabIndex = 12;
            this._accountRoleLabel.Text = "Role";
            this._accountRoleLabel.Visible = false;
            // 
            // ChatWindow
            // 
            this.AcceptButton = this._sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 459);
            this.Controls.Add(this._accountRoleLabel);
            this.Controls.Add(this._accountUsernameLabel);
            this.Controls.Add(this._accountLabel);
            this.Controls.Add(this._disconnectButton);
            this.Controls.Add(this._channelListButton);
            this.Controls.Add(this._channelLabel);
            this.Controls.Add(this._channelTagLabel);
            this.Controls.Add(this._usernameLabel);
            this.Controls.Add(this._usernameTagLabel);
            this.Controls.Add(this._output);
            this.Controls.Add(this._messageInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._sendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(813, 498);
            this.MinimumSize = new System.Drawing.Size(813, 498);
            this.Name = "ChatWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talky | Chat Session";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ChatWindow_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _statusToolStripTagLabel;
        private System.Windows.Forms.ToolStripStatusLabel _statusToolStripLabel;
        private System.Windows.Forms.TextBox _messageInput;
        private System.Windows.Forms.TextBox _output;
        private System.Windows.Forms.Label _usernameTagLabel;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.Label _channelLabel;
        private System.Windows.Forms.Label _channelTagLabel;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Button _channelListButton;
        private System.Windows.Forms.Button _disconnectButton;
        private System.Windows.Forms.Label _accountUsernameLabel;
        private System.Windows.Forms.Label _accountLabel;
        private System.Windows.Forms.Label _accountRoleLabel;
    }
}