using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStockApp
{
    public interface ICustomer
    {
        int CustomerID { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string PostalCode { get; set; }
        string City { get; set; }
        int Phone { get; set; }
    }
}

