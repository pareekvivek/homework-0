using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;


namespace CosmosDBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectToCosmosDB_Click(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigSetting.Text);
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            IEnumerable<CloudTable> cosomosDBTables = tableClient.ListTables();

            foreach (CloudTable t in cosomosDBTables)
            {
                treeView1.Nodes.Add(t.Name);
            }

        }

        private void GetFromConfigrations_Click(object sender, EventArgs e)
        {
            AppSettingsReader appSettings = new AppSettingsReader();
            //string StorageConnection = appSettings.GetValue("StorageConnection", string. );
            string StorageConnection = ConfigurationManager.AppSettings.Get("StorageConnection");
            if (!string.IsNullOrEmpty(StorageConnection))
                ConfigSetting.Text = StorageConnection;
            else
                MessageBox.Show("StorageConnection config not found in config"); 
        }
    }
}
