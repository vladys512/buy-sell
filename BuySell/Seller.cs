using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell
{
    public class Seller
    {
        //public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string DeliveryTerms { get; set; }
        public string PaymentType { get; set; }
        public string Contact { get; set; }
        public string Note { get; set; }

        public Seller(string productName, int quantity, decimal price, string deliveryTerms, string paymentType, string contact, string note)
        {
            ProductName = productName;
            Quantity = quantity;
            Price = price;
            DeliveryTerms = deliveryTerms;
            PaymentType = paymentType;
            Contact = contact;
            Note = note;
        }
    }
}
