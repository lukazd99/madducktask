using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreChain.Models;

namespace StoreChain
{
    class Program
    {
        static void Main(string[] args)
        {
            CornerShop cornerShop = new CornerShop() { Name = "CornerShop" };
            Pharmacy pharmacy = new Pharmacy() { Name = "Pharmacy" };
            Supermarket supermarket = new Supermarket() { Name = "Supermarket" };

            cornerShop.Products.Add(new Product()
            {
                Name = "Product1",
                Price = 15.99,
                Quantity = 1,
                Type = Product.ProductType.Cigarettes
            });

            cornerShop.Products.Add(new Product()
            {
                Name = "Product2",
                Price = 27.99,
                Quantity = 0,
                Type = Product.ProductType.Medicine,
                SerialNumber = "Lvw8V256"
            });

            pharmacy.Products.Add(new Product()
            {
                Name = "Product1",
                Price = 27.99,
                Quantity = 0,
                Type = Product.ProductType.ParkingTicket,
                SerialNumber = "Lvw8V256"
            });

            pharmacy.Products.Add(new Product()
            {
                Name = "Product2",
                Price = 30.99,
                Quantity = 0,
                Type = Product.ProductType.Toys,
            });

            supermarket.Products.Add(new Product()
            {
                Name = "Product1",
                Price = 10.99,
                Quantity = 1,
                Type = Product.ProductType.Cigarettes,
            });

            supermarket.Products.Add(new Product()
            {
                Name = "Product2",
                Price = 30.99,
                Quantity = 5,
                Type = Product.ProductType.Drink,
            });

            List<Bill> bills = new List<Bill>();

            CustomerData customer1 = new CustomerData()
            {
                FirstName = "Dave",
                LastName = "Stewart",
                TelephoneNumber = "+1 582-400-0206"
            };

            bills.Add(cornerShop.Sell(cornerShop.Products[0], customer1));
            bills.Add(cornerShop.Sell(cornerShop.Products[1], customer1));
            bills.Add(pharmacy.Sell(pharmacy.Products[0], customer1));
            bills.Add(pharmacy.Sell(pharmacy.Products[1], customer1));
            bills.Add(supermarket.Sell(supermarket.Products[0], customer1));
            bills.Add(supermarket.Sell(supermarket.Products[1], customer1));

            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/report.txt"))
            {
                foreach (Bill item in bills)
                {
                    if (item is null)
                        continue;

                    sw.WriteLine(item.Number + "\nDate: " 
                        + item.DateTime + "\nCustomer: \n" + item.CustomerData.ToString());
                }
            }
            
        }
    }
}
