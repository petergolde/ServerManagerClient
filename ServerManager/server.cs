using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerManager
{
    public partial class server : Form
    {
        
        public Form1 form1;
        public RemoteServer remoteServer = new RemoteServer();
        
        public String getUsername { get; set; }
        public String getPassword { get; set; }




        public server()
        {
            //something goes here
        }

        public void StartForm2()
        {
            
            InitializeComponent();
            Console.WriteLine("Username: " + getUsername);
            //fix
            this.Text = "ServerManager " + Form1.version + " | Logged in as: " + getUsername;
            updateDebugLabel();

            remoteServer.UserName = getUsername;
            remoteServer.Password = getPassword;
            updateTabs();
            updateDebugLabel();

            if (tabs.SelectedTab != null) {
                populateTreeWithServer(tabs.SelectedTab.Text);
            }

            // Start the timer.
            timer1.Enabled = true;

        }

        public void updateDebugLabel()
        {
            debugLabel.Text = "Logged in as: " + getUsername + "     |     Application Version: " + Form1.version + "     |     Servers: " + tabs.TabCount;
        }

        public void updateTabs()
        {
            String[] serverNames = remoteServer.ServerList();
            tabs.TabPages.Clear();
            foreach(String s in serverNames)
            {
                tabs.TabPages.Add(s);
            }
        }

        public void populateTreeWithServer(String server)
        {
            remoteServer.Server = server;
            remoteServer.PopulateTreeViewWithFileList(fileTree);
        }

        public void updateConsole(String server)
        {
            remoteServer.Server = server;
            String log = remoteServer.DownloadFileAsString("logs\\latest.log");
            serverConsole.Text = log;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                //logout
                form1.Show();
                form1.logout(); //fix
                this.Hide();
            }
            
        }

        
        private void server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void sendCommandButton_Click(object sender, EventArgs e)
        {
            String commandToSend = sendCommand.Text;
            //send command to plugin over web server

            //sendCommand.Text = "";
        }

        private void tabs_Selected(object sender, TabControlEventArgs e)
        {
            populateTreeWithServer(tabs.SelectedTab.Text);
        }

        private void fileUpload_Click(object sender, EventArgs e)
        {
            remoteServer.UploadFileToTreeView(fileTree);
        }

        private void fileDownload_Click(object sender, EventArgs e)
        {
            remoteServer.DownloadFileFromTreeView(fileTree);
        }

        private void fileDelete_Click(object sender, EventArgs e)
        {
            remoteServer.DeleteFileFromTreeView(fileTree);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabs.SelectedTab != null) {
                updateConsole(tabs.SelectedTab.Text);
            }
        }
    }
}
