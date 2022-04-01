using StoreChain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain
{
    public abstract class Shop
    {
        public string Name { get; set; }

        public List<Product> Products = new List<Product>();

        protected List<Bill> Bills = new List<Bill>();

        public abstract Bill Sell(Product product, CustomerData customerData);

        public List<Bill> GetReport(DateTime date)
        {
            List<Bill> result = Bills.Where(x => x.DateTime == date).ToList();
            return result;
        }
    }
}
