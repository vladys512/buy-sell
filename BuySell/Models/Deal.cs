using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Models
{
    /// <summary>
    /// Клас, що представляє угоду між продавцем та покупцем на біржі товарів.
    /// </summary>
    public class Deal
    {
        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public Guid BuyerId { get; set; }
        public DateTime DealDate { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string SellerName { get; set; } 
        public string BuyerName { get; set; }  
        public string SellerContact { get; set; }
        public string BuyerContact { get; set; }
        public bool IsSellerSatisfied { get; set; }
        public bool IsBuyerSatisfied { get; set; }

        public string SellerFeedback => IsSellerSatisfied ? "Задоволений" : "Незадоволений";
        public string BuyerFeedback => IsBuyerSatisfied ? "Задоволений" : "Незадоволений";
    }
}
