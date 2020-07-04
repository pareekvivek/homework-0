using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
//using TableDemo.Entities;

namespace CosmosDBApp.HelperClasses
{
    public static class ConnectToAzureCosmos
    {
        public static CloudTableClient GetCloudTableClient(string StorageConnection)
        {
            CloudTableClient tableClient;

            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting(StorageConnection));
                tableClient = storageAccount.CreateCloudTableClient();
            }
            catch (Exception e)
            {
                throw e;
            }
            return tableClient;
        }

    }
}
