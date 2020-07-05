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
using System.Collections.Specialized;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Security.Cryptography;
using Microsoft.Azure;

namespace CosmosDBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Private Var Decleratopm

        CloudTableClient tableClient;

        #endregion

        private void ConnectToCosmosDB_Click(object sender, EventArgs e)
        {
            tableClient = PopulateTableClient(txtConfigSetting.Text);
            PopulateTreeView(tableClient);
        }

        private void GetFromConfigrations_Click(object sender, EventArgs e)
        {
            AppSettingsReader appSettings = new AppSettingsReader();
            //string StorageConnection = appSettings.GetValue("StorageConnection", string. );
            string StorageConnection = ConfigurationManager.AppSettings.Get("StorageConnection");
            if (!string.IsNullOrEmpty(StorageConnection))
                txtConfigSetting.Text = StorageConnection;
            else
                MessageBox.Show("StorageConnection config not found in config"); 
        }

        private void btnAddEntity_Click(object sender, EventArgs e)
        {
            if (tableClient == null)
            {
                tableClient = PopulateTableClient(txtConfigSetting.Text);
            }
            try
            {
                CloudTable table = tableClient.GetTableReference(txtNewEntity.Text);
                if (table.CreateIfNotExists())
                {
                    PopulateTreeView(tableClient);
                    txtNewEntity.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CloudTableClient PopulateTableClient(string conString)
        {
            CloudTableClient c = null;
            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(conString);
                c = storageAccount.CreateCloudTableClient();
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(System.FormatException)) 
                {
                    MessageBox.Show("Invalid Conneciton String: Detail Exception" + ex.ToString());
                }
                else 
                {
                    throw ex;
                }
            }
            return c;

        }

        private void PopulateTreeView(CloudTableClient tableClient)
        {
            IEnumerable<CloudTable> cosomosDBTables = tableClient.ListTables();
            tvEntities.Nodes.Clear();
            foreach (CloudTable t in cosomosDBTables)
            {
                tvEntities.Nodes.Add(t.Name);
            }
            tvEntities.Sort();
        }
    }
}
