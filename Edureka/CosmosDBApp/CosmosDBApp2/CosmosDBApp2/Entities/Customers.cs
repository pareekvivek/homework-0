using Microsoft.WindowsAzure.Storage.Table;

namespace TableDemo.Entities
{
    class Customer : TableEntity
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerType { get; set; }

        public string Gender { get; set; }


        public Customer() { }

        public Customer(string name, string email, string type)
        {
            this.CustomerName = name;
            this.CustomerEmail = email;
            this.CustomerType = type;
            this.PartitionKey = type;
            this.RowKey = email;
        }

        public Customer(string name, string email, string type, string gender)
        {
            this.CustomerName = name;
            this.CustomerEmail = email;
            this.CustomerType = type;
            this.PartitionKey = type;
            this.RowKey = email;
            this.Gender = gender;
        }
    }
}
