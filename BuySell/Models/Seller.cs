using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Models
{
    /// <summary>
    /// Клас, що представляє продавця на біржі товарів.
    /// </summary>
    public class Seller
    {
        public Guid Id { get; private set; } // Унікальний ідентифікатор
        public string Name { get; set; } 
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string DeliveryTerms { get; set; }
        public string PaymentType { get; set; }
        public string Contact { get; set; }
        public string Note { get; set; }
        public Seller(string name, string productName, int quantity, decimal price, string deliveryTerms, string paymentType, string contact, string note)
        {
            Id = Guid.NewGuid(); // Генеруємо унікальний ID при створенні
            Name = name;
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
