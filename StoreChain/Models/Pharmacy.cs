using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain.Models
{
    public class Pharmacy : Shop
    {
        public override Bill Sell(Product product, CustomerData customerData)
        {
            if (product.Type == Product.ProductType.Cigarettes)
                return null;

            if (product.Quantity - 1 < 0)
                return null;

            product.Quantity -= 1;

            Bill result = new Bill
            {
                CustomerData = customerData,
                DateTime = DateTime.Now,
            };

            if (product.Type == Product.ProductType.Medicine || product.Type == Product.ProductType.ParkingTicket)
                result.Number = product.SerialNumber;

            result.BoughtProducts.Add(product);

            Bills.Add(result);

            return result;
        }
    }
}
