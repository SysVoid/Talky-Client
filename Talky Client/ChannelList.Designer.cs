namespace Talky_Client
{
    partial class ChannelList
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
            this._channelList = new System.Windows.Forms.ComboBox();
            this._joinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _channelList
            // 
            this._channelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._channelList.FormattingEnabled = true;
            this._channelList.Location = new System.Drawing.Point(12, 12);
            this._channelList.Name = "_channelList";
            this._channelList.Size = new System.Drawing.Size(466, 320);
            this._channelList.TabIndex = 0;
            // 
            // _joinButton
            // 
            this._joinButton.Location = new System.Drawing.Point(365, 338);
            this._joinButton.Name = "_joinButton";
            this._joinButton.Size = new System.Drawing.Size(113, 23);
            this._joinButton.TabIndex = 2;
            this._joinButton.Text = "Join Channel";
            this._joinButton.UseVisualStyleBackColor = true;
            this._joinButton.Click += new System.EventHandler(this._joinButton_Click);
            // 
            // ChannelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 376);
            this.Controls.Add(this._joinButton);
            this.Controls.Add(this._channelList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChannelList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChannelList";
            this.Load += new System.EventHandler(this.ChannelList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _channelList;
        private System.Windows.Forms.Button _joinButton;
    }
}