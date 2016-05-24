namespace ServerManager
{
    partial class server
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
            this.button1 = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fileUpload = new System.Windows.Forms.Button();
            this.fileDownload = new System.Windows.Forms.Button();
            this.fileDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxFileManager = new System.Windows.Forms.GroupBox();
            this.fileTree = new System.Windows.Forms.TreeView();
            this.groupBoxConsole = new System.Windows.Forms.GroupBox();
            this.sendCommandButton = new System.Windows.Forms.Button();
            this.sendCommand = new System.Windows.Forms.TextBox();
            this.serverConsole = new System.Windows.Forms.TextBox();
            this.tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxFileManager.SuspendLayout();
            this.groupBoxConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(780, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(12, 464);
            this.debugLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(467, 13);
            this.debugLabel.TabIndex = 2;
            this.debugLabel.Text = "██████████████████████████████████████████████";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(20, 11);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(810, 19);
            this.tabs.TabIndex = 5;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(802, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(802, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fileUpload
            // 
            this.fileUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileUpload.Location = new System.Drawing.Point(430, 452);
            this.fileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.fileUpload.Name = "fileUpload";
            this.fileUpload.Size = new System.Drawing.Size(66, 26);
            this.fileUpload.TabIndex = 6;
            this.fileUpload.Text = "Upload";
            this.fileUpload.UseVisualStyleBackColor = true;
            this.fileUpload.Click += new System.EventHandler(this.fileUpload_Click);
            // 
            // fileDownload
            // 
            this.fileDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileDownload.Location = new System.Drawing.Point(500, 452);
            this.fileDownload.Margin = new System.Windows.Forms.Padding(2);
            this.fileDownload.Name = "fileDownload";
            this.fileDownload.Size = new System.Drawing.Size(66, 26);
            this.fileDownload.TabIndex = 7;
            this.fileDownload.Text = "Download";
            this.fileDownload.UseVisualStyleBackColor = true;
            this.fileDownload.Click += new System.EventHandler(this.fileDownload_Click);
            // 
            // fileDelete
            // 
            this.fileDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileDelete.Location = new System.Drawing.Point(571, 452);
            this.fileDelete.Margin = new System.Windows.Forms.Padding(2);
            this.fileDelete.Name = "fileDelete";
            this.fileDelete.Size = new System.Drawing.Size(66, 26);
            this.fileDelete.TabIndex = 8;
            this.fileDelete.Text = "Delete";
            this.fileDelete.UseVisualStyleBackColor = true;
            this.fileDelete.Click += new System.EventHandler(this.fileDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(20, 38);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBoxFileManager);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBoxConsole);
            this.splitContainer.Size = new System.Drawing.Size(814, 392);
            this.splitContainer.SplitterDistance = 271;
            this.splitContainer.TabIndex = 9;
            // 
            // groupBoxFileManager
            // 
            this.groupBoxFileManager.Controls.Add(this.fileTree);
            this.groupBoxFileManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFileManager.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFileManager.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFileManager.Name = "groupBoxFileManager";
            this.groupBoxFileManager.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFileManager.Size = new System.Drawing.Size(271, 392);
            this.groupBoxFileManager.TabIndex = 4;
            this.groupBoxFileManager.TabStop = false;
            this.groupBoxFileManager.Text = "File Manager";
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTree.Location = new System.Drawing.Point(4, 17);
            this.fileTree.Margin = new System.Windows.Forms.Padding(2);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(263, 372);
            this.fileTree.TabIndex = 0;
            // 
            // groupBoxConsole
            // 
            this.groupBoxConsole.Controls.Add(this.sendCommandButton);
            this.groupBoxConsole.Controls.Add(this.sendCommand);
            this.groupBoxConsole.Controls.Add(this.serverConsole);
            this.groupBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxConsole.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConsole.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConsole.Name = "groupBoxConsole";
            this.groupBoxConsole.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConsole.Size = new System.Drawing.Size(539, 392);
            this.groupBoxConsole.TabIndex = 5;
            this.groupBoxConsole.TabStop = false;
            this.groupBoxConsole.Text = "Console";
            // 
            // sendCommandButton
            // 
            this.sendCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendCommandButton.Location = new System.Drawing.Point(478, 370);
            this.sendCommandButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendCommandButton.Name = "sendCommandButton";
            this.sendCommandButton.Size = new System.Drawing.Size(56, 19);
            this.sendCommandButton.TabIndex = 2;
            this.sendCommandButton.Text = "Send";
            this.sendCommandButton.UseVisualStyleBackColor = true;
            // 
            // sendCommand
            // 
            this.sendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendCommand.Location = new System.Drawing.Point(4, 370);
            this.sendCommand.Margin = new System.Windows.Forms.Padding(2);
            this.sendCommand.Name = "sendCommand";
            this.sendCommand.ReadOnly = true;
            this.sendCommand.Size = new System.Drawing.Size(470, 20);
            this.sendCommand.TabIndex = 1;
            this.sendCommand.Text = "This Does Not Work Yet";
            // 
            // serverConsole
            // 
            this.serverConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverConsole.Location = new System.Drawing.Point(4, 17);
            this.serverConsole.Margin = new System.Windows.Forms.Padding(2);
            this.serverConsole.Multiline = true;
            this.serverConsole.Name = "serverConsole";
            this.serverConsole.ReadOnly = true;
            this.serverConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serverConsole.Size = new System.Drawing.Size(533, 348);
            this.serverConsole.TabIndex = 0;
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 488);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.fileDelete);
            this.Controls.Add(this.fileDownload);
            this.Controls.Add(this.fileUpload);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "server";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.server_FormClosed);
            this.tabs.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxFileManager.ResumeLayout(false);
            this.groupBoxConsole.ResumeLayout(false);
            this.groupBoxConsole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button fileUpload;
        private System.Windows.Forms.Button fileDownload;
        private System.Windows.Forms.Button fileDelete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBoxFileManager;
        private System.Windows.Forms.TreeView fileTree;
        private System.Windows.Forms.GroupBox groupBoxConsole;
        private System.Windows.Forms.Button sendCommandButton;
        private System.Windows.Forms.TextBox sendCommand;
        private System.Windows.Forms.TextBox serverConsole;
    }
}