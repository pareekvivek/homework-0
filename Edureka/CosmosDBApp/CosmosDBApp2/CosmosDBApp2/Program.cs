using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using TableDemo.Entities;

namespace CosmosDBApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Reference to the ConnectionString in the App.Config file 
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            CloudConfigurationManager.GetSetting("StorageConnection"));
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference("customers");
            table.CreateIfNotExists();
            
            ///Region - Single Transaction
            {
                //CreateCustomer(table, new Customer("Customer1", "customer1@mail.com", "registered"));
                //Console.ReadLine();
            }

            ///Region - Batch Transaction
            {
                TableBatchOperation batchOperation = new TableBatchOperation();

                Customer customer2 = new Customer("Customer21",  Guid.NewGuid().ToString()+ "customer2@mail.com", "registered");
                Customer customer3 = new Customer("Customer22", Guid.NewGuid().ToString() + "customer3@mail.com", "registered","male");
                Customer customer4 = new Customer("Customer23", Guid.NewGuid().ToString() + "customer4@mail.com", "registered");
                Customer customer5 = new Customer("Customer24", Guid.NewGuid().ToString() + "customer5@mail.com", "registered","female");

                batchOperation.Insert(customer2);
                batchOperation.Insert(customer3);
                batchOperation.Insert(customer4);
                batchOperation.Insert(customer5);

                table.ExecuteBatch(batchOperation);
                Console.WriteLine("Record inserted");
                Console.ReadLine();
            }
            /// 

        }


        static void CreateCustomer(CloudTable table, Customer user)
        {
            TableOperation insert = TableOperation.Insert(user);
            table.Execute(insert);
            Console.WriteLine("Record inserted");
        }

    }
}
