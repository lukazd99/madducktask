using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain.Models
{
    public class Bill
    {
        public string Number { get; set; }
        public DateTime DateTime { get; set; }
        public CustomerData CustomerData { get; set; }
        public List<Product> BoughtProducts = new List<Product>();
    }
}
