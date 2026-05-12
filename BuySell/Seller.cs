using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell
{
    internal class Seller
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string DeliveryTerms { get; set; }
        public string PaymentType { get; set; }
        public string Contact { get; set; }
        public string Note { get; set; }
    }
}
