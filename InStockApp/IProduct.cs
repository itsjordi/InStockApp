using System;

namespace InStockApp
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        Enum ProductType { get; set; }
        DateTime RegistratedDate { get; set; }
        DateTime LeaveData { get; set; }
        int Total { get; set; }
        int Price { get; set; }
        string Location { get; set; }
    }
}
