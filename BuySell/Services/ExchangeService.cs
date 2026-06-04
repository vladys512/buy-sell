using System;
using System.ComponentModel;
using System.Linq;
using BuySell.Models;

namespace BuySell.Services
{
    // Головний клас бізнес-логіки біржі
    public class ExchangeService
    {
        public BindingList<Seller> Sellers { get; set; }
        public BindingList<Buyer> Buyers { get; set; }
        public BindingList<Deal> DealsArchive { get; set; }

        public ExchangeService()
        {
            Sellers = new BindingList<Seller>();
            Buyers = new BindingList<Buyer>();
            DealsArchive = new BindingList<Deal>();
        }

        public void AddSeller(Seller seller) => Sellers.Add(seller);
        public void AddBuyer(Buyer buyer) => Buyers.Add(buyer);

        public void RemoveSeller(Seller seller) => Sellers.Remove(seller);
        public void RemoveBuyer(Buyer buyer) => Buyers.Remove(buyer);

        // Логіка пошуку ПОКУПЦІВ для конкретного ПРОДАВЦЯ
        public BindingList<Buyer> FindMatchingBuyers(Seller seller, bool sortByQuantity)
        {
            var matching = Buyers.Where(b =>
                b.IsActive &&
                b.ProductName.Equals(seller.ProductName, StringComparison.OrdinalIgnoreCase) &&
                b.MaxPrice >= seller.Price);

            var sorted = sortByQuantity
                ? matching.OrderByDescending(b => b.Quantity)
                : matching.OrderByDescending(b => b.MaxPrice);

            return new BindingList<Buyer>(sorted.ToList());
        }

        // Логіка пошуку ПРОДАВЦІВ для конкретного ПОКУПЦЯ
        public BindingList<Seller> FindMatchingSellers(Buyer buyer, bool sortByQuantity)
        {
            var matching = Sellers.Where(s =>
                s.IsActive &&
                s.ProductName.Equals(buyer.ProductName, StringComparison.OrdinalIgnoreCase) &&
                s.Price <= buyer.MaxPrice);

            var sorted = sortByQuantity
                ? matching.OrderByDescending(s => s.Quantity)
                : matching.OrderBy(s => s.Price);

            return new BindingList<Seller>(sorted.ToList());
        }
    }
}
