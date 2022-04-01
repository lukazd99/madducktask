using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain.Models
{
    public class CustomerData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }

        public override string ToString()
        {
            return FirstName + "\n" + LastName + "\n" + TelephoneNumber;
        }
    }
}
