using BuySell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Services
{
    internal class AnnouncementService
    {
        /// <summary>
        /// Формує індивідуальне оголошення для продавця
        /// </summary>
        public static string GenerateSellerAnnouncement(Seller seller)
        {
            if (seller == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================================");
            sb.AppendLine("          ОГОЛОШЕННЯ ПРО ПРОДАЖ          ");
            sb.AppendLine("=========================================");
            sb.AppendLine($"Продавець: {seller.Name}");
            sb.AppendLine($"Пропонуємо до продажу: {seller.ProductName}");
            sb.AppendLine($"Обсяг партії: {seller.Quantity} шт.");
            sb.AppendLine($"Ціна за одиницю: {seller.Price:N2} грн");
            sb.AppendLine($"Умови відвантаження: {seller.DeliveryTerms}");
            sb.AppendLine($"Форма оплати: {seller.PaymentType}");
            sb.AppendLine();
            sb.AppendLine($"Контакти для зв'язку: {seller.Contact}");
            if (!string.IsNullOrWhiteSpace(seller.Note))
                sb.AppendLine($"Примітка: {seller.Note}");
            sb.AppendLine("=========================================");

            return sb.ToString();
        }

        /// <summary>
        /// Формує індивідуальне оголошення для покупця
        /// </summary>
        public static string GenerateBuyerAnnouncement(Buyer buyer)
        {
            if (buyer == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================================");
            sb.AppendLine("          ОГОЛОШЕННЯ ПРО КУПІВЛЮ         ");
            sb.AppendLine("=========================================");
            sb.AppendLine($"Покупець: {buyer.Name}");
            sb.AppendLine($"Шукаємо для купівлі: {buyer.ProductName}");
            sb.AppendLine($"Необхідний обсяг: {buyer.Quantity} шт.");
            sb.AppendLine($"Прийнятна ціна до: {buyer.MaxPrice:N2} грн");
            sb.AppendLine($"Бажана форма оплати: {buyer.PaymentType}");
            sb.AppendLine();
            sb.AppendLine($"Контакти для зв'язку: {buyer.Contact}");
            if (!string.IsNullOrWhiteSpace(buyer.Note))
                sb.AppendLine($"Примітка: {buyer.Note}");
            sb.AppendLine("=========================================");

            return sb.ToString();
        }
    }
}
