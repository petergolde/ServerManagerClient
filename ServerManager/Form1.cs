using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerManager
{
    public partial class Form1 : Form
    {
        server server = new server();
        WebClient web = new WebClient();
        public static String version = "0.6 Alpha";
       
        
        
        public Form1()
        {
            server.form1 = this;
            InitializeComponent();
        }

        public void logout() 
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            String result = web.DownloadString("http://web.golde.org/ServerManager/Main/Authenticate?user=" + textBoxUsername.Text.ToLower() + "&pw=" + textBoxPassword.Text.ToLower());
            Console.WriteLine(textBoxUsername);
            Console.WriteLine(textBoxPassword);
            Console.WriteLine(result);
            if (result == "true")
            {
                //set some freeken public string to be the username
                //HOW
                
                server.getUsername = textBoxUsername.Text.ToLower();
                server.getPassword = textBoxPassword.Text.ToLower();
                server.StartForm2();

                server.Show();
                this.Hide();
            }
            else
            {
                //incorrect
                wrong();
            }
            
        }

        public void wrong()
        {
            MessageBox.Show("Wrong username or password. Please try again.");
            logout();
        }
    }
}
