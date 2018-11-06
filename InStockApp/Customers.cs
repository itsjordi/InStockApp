using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStockApp
{
    class Customers : ICustomer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }

        public Customers()
        {

        }

        public void GetCustomer(int customerID, string name, string address, string postalCode, string city, int phone)
        {
            CustomerID = customerID;
            Name = name;
            Address = address;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
        }
    }
}
