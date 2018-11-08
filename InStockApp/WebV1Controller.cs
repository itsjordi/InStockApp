using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStockApp
{
    public class WebV1Controller
    {
        private ICustomer Customer { get; }
        private IProduct Product { get; }
        private ICar Car { get; }

        public WebV1Controller(
            ICustomer customer,
            IProduct product,
            ICar car)
        {
            Customer = customer;
            Product = product;
            Car = car;  
        }

        public void GetCustomer(int customerID, string name, string address, string postalCode, string city, int phone)
        {
            Customer.CustomerID = customerID;
            Customer.Name = name;
            Customer.Address = address;
            Customer.PostalCode = postalCode;
            Customer.City = city;
            Customer.Phone = phone;
        }

        public void GetProducts(int id, DateTime leaveDate, string productLocation, int productPrice, Enum productType, DateTime productRegistratedDate, string name, int totalProducts)
        {
            Product.Id= id;
            Product.LeaveData = leaveDate;
            Product.Location = productLocation;
            Product.Price = productPrice;
            Product.ProductType = productType;
            Product.RegistratedDate = productRegistratedDate;
            Product.Name = name;
            Product.Total = totalProducts;
        }

        public void GetCar(int customerID, string name, int establishedYear, int km, string kenteken, int price)
        {
            Car.Id = customerID;
            Car.CarName = name;
            Car.EstablishedYear = establishedYear;
            Car.KM = km;
            Car.Kenteken = kenteken;
            Car.Price = price;
        }
    }
}
