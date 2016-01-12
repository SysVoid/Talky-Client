namespace Talky_Client
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this._connectButton = new System.Windows.Forms.Button();
            this._quitButton = new System.Windows.Forms.Button();
            this._connectionDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this._usernameErrorImage = new System.Windows.Forms.PictureBox();
            this._portErrorImage = new System.Windows.Forms.PictureBox();
            this._hostErrorImage = new System.Windows.Forms.PictureBox();
            this._usernameInput = new System.Windows.Forms.TextBox();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._portInput = new System.Windows.Forms.TextBox();
            this._portLabel = new System.Windows.Forms.Label();
            this._hostInput = new System.Windows.Forms.TextBox();
            this._hostLabel = new System.Windows.Forms.Label();
            this._iconImage = new System.Windows.Forms.PictureBox();
            this._titleLabel = new System.Windows.Forms.Label();
            this._connectionDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._usernameErrorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._portErrorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._hostErrorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._iconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // _connectButton
            // 
            this._connectButton.Location = new System.Drawing.Point(456, 236);
            this._connectButton.Name = "_connectButton";
            this._connectButton.Size = new System.Drawing.Size(119, 23);
            this._connectButton.TabIndex = 0;
            this._connectButton.Text = "Connect to Server";
            this._connectButton.UseVisualStyleBackColor = true;
            this._connectButton.Click += new System.EventHandler(this._connectButton_Click);
            // 
            // _quitButton
            // 
            this._quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._quitButton.Location = new System.Drawing.Point(12, 236);
            this._quitButton.Name = "_quitButton";
            this._quitButton.Size = new System.Drawing.Size(119, 23);
            this._quitButton.TabIndex = 1;
            this._quitButton.Text = "Quit";
            this._quitButton.UseVisualStyleBackColor = true;
            this._quitButton.Click += new System.EventHandler(this._quitButton_Click);
            // 
            // _connectionDetailsGroupBox
            // 
            this._connectionDetailsGroupBox.Controls.Add(this._usernameErrorImage);
            this._connectionDetailsGroupBox.Controls.Add(this._portErrorImage);
            this._connectionDetailsGroupBox.Controls.Add(this._hostErrorImage);
            this._connectionDetailsGroupBox.Controls.Add(this._usernameInput);
            this._connectionDetailsGroupBox.Controls.Add(this._usernameLabel);
            this._connectionDetailsGroupBox.Controls.Add(this._portInput);
            this._connectionDetailsGroupBox.Controls.Add(this._portLabel);
            this._connectionDetailsGroupBox.Controls.Add(this._hostInput);
            this._connectionDetailsGroupBox.Controls.Add(this._hostLabel);
            this._connectionDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._connectionDetailsGroupBox.Location = new System.Drawing.Point(12, 76);
            this._connectionDetailsGroupBox.Name = "_connectionDetailsGroupBox";
            this._connectionDetailsGroupBox.Size = new System.Drawing.Size(563, 140);
            this._connectionDetailsGroupBox.TabIndex = 5;
            this._connectionDetailsGroupBox.TabStop = false;
            this._connectionDetailsGroupBox.Text = "Connection Details";
            // 
            // _usernameErrorImage
            // 
            this._usernameErrorImage.Image = ((System.Drawing.Image)(resources.GetObject("_usernameErrorImage.Image")));
            this._usernameErrorImage.Location = new System.Drawing.Point(529, 90);
            this._usernameErrorImage.Name = "_usernameErrorImage";
            this._usernameErrorImage.Size = new System.Drawing.Size(28, 30);
            this._usernameErrorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._usernameErrorImage.TabIndex = 9;
            this._usernameErrorImage.TabStop = false;
            // 
            // _portErrorImage
            // 
            this._portErrorImage.Image = ((System.Drawing.Image)(resources.GetObject("_portErrorImage.Image")));
            this._portErrorImage.Location = new System.Drawing.Point(529, 62);
            this._portErrorImage.Name = "_portErrorImage";
            this._portErrorImage.Size = new System.Drawing.Size(28, 30);
            this._portErrorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._portErrorImage.TabIndex = 8;
            this._portErrorImage.TabStop = false;
            // 
            // _hostErrorImage
            // 
            this._hostErrorImage.Image = ((System.Drawing.Image)(resources.GetObject("_hostErrorImage.Image")));
            this._hostErrorImage.Location = new System.Drawing.Point(529, 34);
            this._hostErrorImage.Name = "_hostErrorImage";
            this._hostErrorImage.Size = new System.Drawing.Size(28, 30);
            this._hostErrorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._hostErrorImage.TabIndex = 7;
            this._hostErrorImage.TabStop = false;
            // 
            // _usernameInput
            // 
            this._usernameInput.Location = new System.Drawing.Point(99, 94);
            this._usernameInput.Name = "_usernameInput";
            this._usernameInput.Size = new System.Drawing.Size(423, 22);
            this._usernameInput.TabIndex = 5;
            this._usernameInput.TextChanged += new System.EventHandler(this._usernameInput_TextChanged);
            // 
            // _usernameLabel
            // 
            this._usernameLabel.AutoSize = true;
            this._usernameLabel.Location = new System.Drawing.Point(22, 97);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(71, 16);
            this._usernameLabel.TabIndex = 4;
            this._usernameLabel.Text = "Username";
            // 
            // _portInput
            // 
            this._portInput.Location = new System.Drawing.Point(99, 66);
            this._portInput.Name = "_portInput";
            this._portInput.Size = new System.Drawing.Size(423, 22);
            this._portInput.TabIndex = 3;
            this._portInput.TextChanged += new System.EventHandler(this._portInput_TextChanged);
            // 
            // _portLabel
            // 
            this._portLabel.AutoSize = true;
            this._portLabel.Location = new System.Drawing.Point(18, 69);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(75, 16);
            this._portLabel.TabIndex = 2;
            this._portLabel.Text = "Server Port";
            // 
            // _hostInput
            // 
            this._hostInput.Location = new System.Drawing.Point(99, 38);
            this._hostInput.Name = "_hostInput";
            this._hostInput.Size = new System.Drawing.Size(423, 22);
            this._hostInput.TabIndex = 1;
            this._hostInput.TextChanged += new System.EventHandler(this._hostInput_TextChanged);
            // 
            // _hostLabel
            // 
            this._hostLabel.AutoSize = true;
            this._hostLabel.Location = new System.Drawing.Point(7, 41);
            this._hostLabel.Name = "_hostLabel";
            this._hostLabel.Size = new System.Drawing.Size(86, 16);
            this._hostLabel.TabIndex = 0;
            this._hostLabel.Text = "Hostname/IP";
            // 
            // _iconImage
            // 
            this._iconImage.Image = ((System.Drawing.Image)(resources.GetObject("_iconImage.Image")));
            this._iconImage.Location = new System.Drawing.Point(208, 5);
            this._iconImage.Name = "_iconImage";
            this._iconImage.Size = new System.Drawing.Size(64, 64);
            this._iconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._iconImage.TabIndex = 6;
            this._iconImage.TabStop = false;
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.Location = new System.Drawing.Point(278, 18);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(101, 39);
            this._titleLabel.TabIndex = 6;
            this._titleLabel.Text = "Talky";
            // 
            // ConnectForm
            // 
            this.AcceptButton = this._connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this._quitButton;
            this.ClientSize = new System.Drawing.Size(587, 271);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._iconImage);
            this.Controls.Add(this._connectionDetailsGroupBox);
            this.Controls.Add(this._quitButton);
            this.Controls.Add(this._connectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(603, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(603, 310);
            this.Name = "ConnectForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to a Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectForm_FormClosing);
            this._connectionDetailsGroupBox.ResumeLayout(false);
            this._connectionDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._usernameErrorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._portErrorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._hostErrorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._iconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _connectButton;
        private System.Windows.Forms.Button _quitButton;
        private System.Windows.Forms.GroupBox _connectionDetailsGroupBox;
        private System.Windows.Forms.TextBox _portInput;
        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.TextBox _hostInput;
        private System.Windows.Forms.Label _hostLabel;
        private System.Windows.Forms.TextBox _usernameInput;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.PictureBox _iconImage;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.PictureBox _hostErrorImage;
        private System.Windows.Forms.PictureBox _usernameErrorImage;
        private System.Windows.Forms.PictureBox _portErrorImage;
    }
}

