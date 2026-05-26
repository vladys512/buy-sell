using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell
{
    // Клас угоди
    public class Deal
    {
        public DateTime DealDate { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string SellerContact { get; set; }
        public string BuyerContact { get; set; }

        public Deal(string productName, decimal price, int quantity, string sellerContact, string buyerContact)
        {
            DealDate = DateTime.Now; 
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            SellerContact = sellerContact;
            BuyerContact = buyerContact;
        }
    }
}
