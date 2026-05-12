using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell
{
    internal class Buyer
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal MaxPrice { get; set; }
        public string PaymentType { get; set; }
        public string Contact { get; set; }
        public string Note { get; set; }
    }
}
