using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace searching_service_v._2
{
    public partial class Form1 : Form
    {
        Thread search;
        Thread state;
        bool validSearch = false;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = new Thread(() => fileSearch(txtPath.Text));
            state = new Thread(() => isStopped());
            search.IsBackground = true;
            state.IsBackground = true;
            listResults.Items.Clear();
            search.Start();
            labelSearching.Visible = true;
        }

        private void fileSearch(string path)
        {
            string fileName = txtFileName.Text;
            if (fileName == "")
            {
                labelSearching.Visible = false;
                MessageBox.Show("File name is required.");
                return;
            }
            // if the path does not exists the search will stop. 
            if (!Directory.Exists(path))
            {
                labelSearching.Visible = false;
                MessageBox.Show("The path you have searched doesn't exist");
                return;
            }
            //Checks if access to the folder has been denied 
            if (!isAccessible(path)) return;

            if (!validSearch)
            {
                validSearch = true;
                state.Start();
            }
            string[] filesArr = Directory.GetFiles(path, $"*{fileName}*");
            string[] foldersArr = Directory.GetDirectories(path);
            foreach (string i in filesArr)
            {
                listResults.Items.Add(i);
            }

            //The search continues in each of the subfolders
            for (int i = 0; i < foldersArr.Length; i++)
            {
                fileSearch(foldersArr[i]);
            }

        }

        private bool isAccessible(string path)
        {
            try
            {
                Directory.GetDirectories(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();
            txtFileName.Text = "";
            txtPath.Text = "";
        }

        private void isStopped()
        {
            switching();
            while (search.IsAlive)
            {
                Thread.Sleep(1000);
            }
            if (listResults.Items.Count == 0)
            {
                MessageBox.Show("No file found");
            }
            validSearch = false;
            switching();
        }

        private void switching()
        {
            if (validSearch)
            {
                txtFileName.Enabled = false;
                txtPath.Enabled = false;
                btnClear.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                labelSearching.Visible = false;
                txtFileName.Enabled = true;
                txtPath.Enabled = true;
                btnClear.Enabled = true;
                btnSearch.Enabled = true;
            }
        }

        private void listResults_DoubleClick(object sender, EventArgs e)
        {
            if (listResults.SelectedItem == null) return;
            string location = listResults.SelectedItem.ToString();
            string fileName = location.Split("\\")[^1];
            location = location.Substring(0, (location.Length - fileName.Length - 1));
            Process.Start("explorer.exe", location);

        }
    }
}
