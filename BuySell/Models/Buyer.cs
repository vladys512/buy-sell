using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Models
{
    public class Buyer
    {
        public Guid Id { get; private set; } // Унікальний ідентифікатор
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal MaxPrice { get; set; }
        public string PaymentType { get; set; }
        public string Contact { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; } // true - в пулі, false - в архіві (після угоди)
        public Buyer(string productName, int quantity, decimal maxPrice, string paymentType, string contact, string note)
        {
            Id = Guid.NewGuid(); // Генеруємо унікальний ID при створенні
            IsActive = true;
            ProductName = productName;
            Quantity = quantity;
            MaxPrice = maxPrice;
            PaymentType = paymentType;
            Contact = contact;
            Note = note;
        }
    }
}
