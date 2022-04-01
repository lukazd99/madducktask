using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain.Models
{
    
    public class Product
    {
        public enum ProductType
        {
            Food,
            Drink,
            Medicine,
            Cigarettes,
            Toys,
            ParkingTicket
        };

        public ProductType Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string SerialNumber { get; set; }

        public Product()
        {

        }

        public Product(ProductType type, string name, double price, int quantity, string serialNum = "")
        {
            Type = type;
            Name = name;
            Price = price;
            Quantity = quantity;
            SerialNumber = serialNum;
        }
    }
}
