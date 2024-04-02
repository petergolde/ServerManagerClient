using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerManager
{
    public class RemoteServer
    {
        public string UserName;
        public string Password;
        public string Server;

        WebClient web = new WebClient() { Encoding = Encoding.UTF8};

        const string urlBase = "http://web.golde.org/ServerManager";
        //const string urlBase = "http://localhost:3761";

        public string[] ServerList()
        {
            try {
                string url = GetUrlNoServer("ListServers");
                string[] servers = web.DownloadString(url).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                return servers;
            }
            catch (WebException e) {
                HandleWebException(e);
                return new string[0];
            }
        }

        public void PopulateTreeViewWithFileList(TreeView tv)
        {
            try {
                string url = GetUrl("ListFiles");
                string[] files = web.DownloadString(url).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                tv.Nodes.Clear();
                tv.BeginUpdate();
                foreach (string f in files) {
                    AddFileToTreeView(tv.Nodes, "", f);
                }
                tv.EndUpdate();
            }
            catch (WebException e) {
                HandleWebException(e);
            }
        }

        public void DownloadFileFromTreeView(TreeView tv)
        {
            try {
                TreeNode node = tv.SelectedNode;
                if (node != null) {
                    string serverPath = node.Name;
                    string clientPath = GetDownloadClientPath(serverPath);
                    if (clientPath == null)
                        return;
                    DownloadFile(serverPath, clientPath);
                }
            }
            catch (WebException e) {
                HandleWebException(e);
            }
        }

        public void DownloadFile(string serverPath, string localPath)
        {
            try {
                string url = GetUrl("DownloadFile") + "&filename=" + WebUtility.UrlEncode(serverPath);
                web.DownloadFile(url, localPath);
            }
            catch (WebException e) {
                HandleWebException(e);
            }
        }

        public string DownloadFileAsString(string serverPath)
        {
            try
            {
                string url = GetUrl("DownloadFile") + "&filename=" + WebUtility.UrlEncode(serverPath);
                return web.DownloadString(url);
            }
            catch (WebException e)
            {
                //HandleWebException(e);
                return "";
            }
        }

        public void UploadFileToTreeView(TreeView tv)
        {
            try {
                string clientPath = GetUploadClientPath();
                if (clientPath != null) {
                    TreeNode node = tv.SelectedNode;
                    if (node != null) {
                        if (node.Nodes.Count == 0) {
                            node = node.Parent;
                        }

                        string serverPath;
                        if (node != null)
                            serverPath = Path.Combine(node.Name, Path.GetFileName(clientPath));
                        else
                            serverPath = Path.GetFileName(clientPath);

                        UploadFile(clientPath, serverPath);
                        PopulateTreeViewWithFileList(tv);
                        TreeNode[] nodes = tv.Nodes.Find(serverPath, true);
                        if (nodes.Length >= 1) {
                            nodes[0].EnsureVisible();
                            tv.SelectedNode = nodes[0];
                            tv.Focus();
                        }
                    }
                }
            }
            catch (WebException e) {
                HandleWebException(e);
            }
        }

        public void UploadFile(string clientPath, string serverPath)
        {
            try {
                string url = GetUrl("UploadFile") + "&filename=" + WebUtility.UrlEncode(serverPath);
                web.UploadFile(url, clientPath);
            }

            catch (WebException e) {
                HandleWebException(e);
            }
        }

        public void DeleteFileFromTreeView(TreeView tv)
        {
            try {
                TreeNode node = tv.SelectedNode;
                if (node != null) {
                    if (node.Nodes.Count > 0) {
                        MessageBox.Show("Cannot delete directory");
                        return;
                    }
                    TreeNode parent = node.Parent;
                    string parentDirectory = (parent == null) ? "" : parent.Name;

                    string serverPath = node.Name;

                    DeleteFile(serverPath);
                    PopulateTreeViewWithFileList(tv);
                    TreeNode[] nodes = tv.Nodes.Find(parentDirectory, true);
                    if (nodes.Length >= 1) {
                        nodes[0].EnsureVisible();
                        tv.SelectedNode = nodes[0];
                        tv.SelectedNode.Expand();
                        tv.Focus();
                    }
                }
            }
            catch (WebException e) {
                HandleWebException(e);
            }
        }

        public void DeleteFile(string serverPath)
        {
            try {
                string url = GetUrl("DeleteFile") + "&filename=" + WebUtility.UrlEncode(serverPath);
                web.UploadString(url, "");
            }

            catch (WebException e) {
                HandleWebException(e);
            }
        }


        private string GetDownloadClientPath(string serverPath)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.FileName = System.IO.Path.GetFileName(serverPath);
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    return saveFileDialog.FileName;
                else
                    return null;
            }
        }

        private string GetUploadClientPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    return openFileDialog.FileName;
                else
                    return null;
            }
        }

        private void AddFileToTreeView(TreeNodeCollection nodes, string prefix, string name)
        {
            if (nodes.ContainsKey(prefix + name))
                return;

            if (name.Contains('\\')) {
                int index = name.IndexOf('\\');
                string first = name.Substring(0, index);
                string rest = name.Substring(index + 1);
                TreeNode treenode;
                if (nodes.ContainsKey(prefix + first))
                    treenode = nodes[prefix + first];
                else
                    treenode = nodes.Add(prefix + first, first);
                AddFileToTreeView(treenode.Nodes, prefix + first + "\\", rest);
            }
            else {
                nodes.Add(prefix + name, name);
            }
        }

        private void HandleWebException(WebException e)
        {
            string message;
            if (e.Response is HttpWebResponse && ((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.BadRequest) {
                message = ((HttpWebResponse)e.Response).StatusDescription;
            }
            else {
                message = e.Message;
            }
            MessageBox.Show(message);
        }

        private string GetUrl(string method)
        {
            return GetUrlNoServer(method) + "&server=" + WebUtility.UrlEncode(Server);
        }
        private string GetUrlNoServer(string method)
        {
            return urlBase + "/Main/" + method + "?user=" + WebUtility.UrlEncode(UserName) + "&pw=" + WebUtility.UrlEncode(Password);
        }

    }
}
