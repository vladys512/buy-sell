using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BuySell
{
    public partial class Form1 : Form
    {
        private BindingList<Seller> Sellers = new BindingList<Seller>();
        private BindingList<Buyer> Buyers = new BindingList<Buyer>();

        private Seller currentSearchSeller = null;
        private Buyer currentSearchBuyer = null;

        // Цей список відображається на вкладці пошуку
        private BindingList<object> SearchResults = new BindingList<object>();
        public Form1()
        {
            InitializeComponent();
            dgvSellers.DataSource = Sellers;
            dgvBuyers.DataSource = Buyers;
            dgvSearchResults.DataSource = SearchResults;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addSeller = new AddSellerForm())
            {
                if (addSeller.ShowDialog() == DialogResult.OK)
                {
                    Seller newSeller = addSeller._Seller;

                    Sellers.Add(newSeller);
                }
            }
        }

        private void DeleteSellerBtn_Click(object sender, EventArgs e)
        {
            if (dgvSellers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть продавця для видалення");
                return;
            }

            int index = dgvSellers.SelectedRows[0].Index;

            var result = MessageBox.Show("Ви впевнені що хочете видалити цього продавця?",
                                         "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Sellers.RemoveAt(index);
            }
        }

        private void DeleteBuyerBtn_Click(object sender, EventArgs e)
        {
            if (dgvBuyers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть покупця для видалення");
                return;
            }

            int index = dgvBuyers.SelectedRows[0].Index;
            var result = MessageBox.Show("Ви впевнені, що хочете видалити цього покупця?",
                                         "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Buyers.RemoveAt(index);
            }
        }

        private void AddBuyerBtn_Click(object sender, EventArgs e)
        {
            using (var addBuyer = new AddBuyerForm())
            {
                if (addBuyer.ShowDialog() == DialogResult.OK)
                {
                    Buyer newBuyer = addBuyer._Buyer;

                    Buyers.Add(newBuyer);
                }
            }
        }

        private void SearchBuyersBtn_Click(object sender, EventArgs e)
        {
            if (dgvSellers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть продавця для пошуку варіантів!");
                return;
            }

            // Запам'ятовуємо обраного продавця
            int index = dgvSellers.SelectedRows[0].Index;
            currentSearchSeller = Sellers[index];
            currentSearchBuyer = null; // Очищаємо покупця, бо шукаємо для продавця

            UpdateCUSearchUI();
            PerformSearch();

            tabControl1.SelectedTab = tabPageSearch;
        }

        // Оновлення інформації в лейблі про обраного клієнта для якого ведеться пошук
        private void UpdateCUSearchUI()
        {
            if (currentSearchSeller != null)
            {
                lblSearchRole.Text = "Шукаємо: ПОКУПЦІВ для обраного продавця";
                lblClientProduct.Text = $"Товар: {currentSearchSeller.ProductName}";
                lblClientPrice.Text = $"Ціна продавця: {currentSearchSeller.Price} грн";
                lblClientQuantity.Text = $"Обсяг: {currentSearchSeller.Quantity} шт.";
            }
            else if (currentSearchBuyer != null)
            {
                lblSearchRole.Text = "Шукаємо: ПРОДАВЦІВ для обраного покупця";
                lblClientProduct.Text = $"Товар: {currentSearchBuyer.ProductName}";
                lblClientPrice.Text = $"Готовий заплатити до: {currentSearchBuyer.MaxPrice} грн";
                lblClientQuantity.Text = $"Потрібний обсяг: {currentSearchBuyer.Quantity} шт.";
            }
        }
        private void PerformSearch()
        {
            // Шукаємо ПОКУПЦІВ для обраного ПРОДАВЦЯ
            if (currentSearchSeller != null)
            {
                // Фільтруємо: однаковий товар і покупець готовий заплатити ціну продавця (або більше)
                var matchingBuyers = Buyers.Where(b =>
                    b.ProductName.Equals(currentSearchSeller.ProductName, StringComparison.OrdinalIgnoreCase) &&
                    b.MaxPrice >= currentSearchSeller.Price);

                // Сортування
                if (rbSortByQuantity != null && rbSortByQuantity.Checked)
                {
                    // За обсягом (від найбільшого до найменшого)
                    matchingBuyers = matchingBuyers.OrderByDescending(b => b.Quantity);
                }
                else
                {
                    // За замовчуванням: за ціною (від більшї до меншої)
                    matchingBuyers = matchingBuyers.OrderByDescending(b => b.MaxPrice);
                }

                // Виводимо в таблицю
                dgvSearchResults.DataSource = new BindingList<Buyer>(matchingBuyers.ToList());
            }
            // Шукаємо ПРОДАВЦІВ для обраного ПОКУПЦЯ
            else if (currentSearchBuyer != null)
            {
                // Фільтруємо: однаковий товар і ціна продавця менша або дорівнює максимальній ціні покупця
                var matchingSellers = Sellers.Where(s =>
                    s.ProductName.Equals(currentSearchBuyer.ProductName, StringComparison.OrdinalIgnoreCase) &&
                    s.Price <= currentSearchBuyer.MaxPrice);

                // Сортування
                if (rbSortByQuantity != null && rbSortByQuantity.Checked)
                {
                    // За обсягом
                    matchingSellers = matchingSellers.OrderByDescending(s => s.Quantity);
                }
                else
                {
                    // За замовчуванням: за ціною (від найдешевшого до найдорожчого)
                    matchingSellers = matchingSellers.OrderBy(s => s.Price);
                }

                // Виводимо в таблицю
                dgvSearchResults.DataSource = new BindingList<Seller>(matchingSellers.ToList());
            }
        }
        private void rbSortByPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSortByPrice.Checked) PerformSearch();
        }

        private void rbSortByQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSortByQuantity.Checked) PerformSearch();
        }

    }
}
