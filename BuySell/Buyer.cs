using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell
{
    public class Buyer
    {
        //public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal MaxPrice { get; set; }
        public string PaymentType { get; set; }
        public string Contact { get; set; }
        public string Note { get; set; }

        public Buyer(string productName, int quantity, decimal maxPrice, string paymentType, string contact, string note)
        {
            ProductName = productName;
            Quantity = quantity;
            MaxPrice = maxPrice;
            PaymentType = paymentType;
            Contact = contact;
            Note = note;
        }
    }
}
