using System;
using System.ComponentModel;
using System.Linq;
using BuySell.Models;

namespace BuySell.Services
{
    /// <summary>
    /// Головний сервіс бізнес-логіки біржі товарів.
    /// Відповідає за управління колекціями клієнтів (продавців, покупців, архіву), 
    /// реалізує алгоритми пошуку варіантів та логіку оформлення угод.
    /// </summary>
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

        // Елементи типів сортування
        public enum SortOption
        {
            None,       
            ByPrice,    
            ByQuantity    
        }
        // Пошук покупців 
        public BindingList<Buyer> FindMatchingBuyers(Seller seller, SortOption sortOption)
        {
            var matching = Buyers.Where(b =>
                b.ProductName.Equals(seller.ProductName, StringComparison.OrdinalIgnoreCase) &&
                b.MaxPrice >= seller.Price);

            switch (sortOption)
            {
                case SortOption.ByPrice:
                    matching = matching.OrderByDescending(b => b.MaxPrice); // Продавцю вигідна більша ціна
                    break;
                case SortOption.ByQuantity:
                    matching = matching.OrderByDescending(b => b.Quantity);
                    break;
            }

            return new BindingList<Buyer>(matching.ToList());
        }
        // Пошук продавців 
        public BindingList<Seller> FindMatchingSellers(Buyer buyer, SortOption sortOption)
        {
            var matching = Sellers.Where(s =>
                s.ProductName.Equals(buyer.ProductName, StringComparison.OrdinalIgnoreCase) &&
                s.Price <= buyer.MaxPrice);

            switch (sortOption)
            {
                case SortOption.ByPrice:
                    matching = matching.OrderBy(s => s.Price); // Покупцю вигідна менша ціна
                    break;
                case SortOption.ByQuantity:
                    matching = matching.OrderByDescending(s => s.Quantity);
                    break;
            }

            return new BindingList<Seller>(matching.ToList());
        }
        //Створення угоди
        public Deal MakeDeal(Seller seller, Buyer buyer)
        {
            if (seller == null || buyer == null)
                throw new ArgumentException("Не обрано учасників угоди.");

            int dealQuantity = Math.Min(seller.Quantity, buyer.Quantity);

            Deal newDeal = new Deal
            {
                Id = Guid.NewGuid(),
                SellerId = seller.Id,
                BuyerId = buyer.Id,
                DealDate = DateTime.Now,
                ProductName = seller.ProductName,
                Price = seller.Price,
                Quantity = dealQuantity,
                SellerName = seller.Name,
                BuyerName = buyer.Name,
                SellerContact = seller.Contact,
                BuyerContact = buyer.Contact,
                IsSellerSatisfied = true,
                IsBuyerSatisfied = true
            };

            // Додаємо запис в історію угод
            DealsArchive.Add(newDeal);

            // Зменшуємо обсяги
            seller.Quantity -= dealQuantity;
            buyer.Quantity -= dealQuantity;

            // якщо потреба закрита повністю (залишок 0) — стираємо з бази
            if (seller.Quantity == 0)
            {
                Sellers.Remove(seller);
            }
            if (buyer.Quantity == 0)
            {
                Buyers.Remove(buyer);
            }

            return newDeal;
        }
    }
}
