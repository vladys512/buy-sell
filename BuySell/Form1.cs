using BuySell.Data;
using BuySell.Models;
using BuySell.Services;
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
        // Уся логіка та списки
        private ExchangeService _service;

        // Змінні для збереження контексту пошуку
        private Seller _currentSearchSeller = null;
        private Buyer _currentSearchBuyer = null;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Завантажуємо дані при старті програми
            _service = DataStorageManager.LoadData();

            // Прив'язуємо дані до таблиць
            dgvSellers.DataSource = _service.Sellers;
            dgvBuyers.DataSource = _service.Buyers;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Автоматично зберігаємо дані при закритті програми
            DataStorageManager.SaveData(_service);
        }

        private void button1_Click(object sender, EventArgs e) // Кнопка AddSellerBtn
        {
            using (var addSeller = new AddSellerForm())
            {
                if (addSeller.ShowDialog() == DialogResult.OK)
                {
                    _service.AddSeller(addSeller._Seller);
                }
            }
        }

        private void DeleteSellerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSellers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Будь ласка, оберіть продавця для видалення.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Seller selectedSeller = (Seller)dgvSellers.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show($"Ви впевнені, що хочете видалити продавця з товаром '{selectedSeller.ProductName}'?",
                                             "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _service.RemoveSeller(selectedSeller);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла непередбачувана ситуація під час видалення. Спробуйте ще раз.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SearchSellersBtn_Click(object sender, EventArgs e)
        {
            if (dgvBuyers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть покупця зі списку, щоб знайти для нього варіанти.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _currentSearchBuyer = (Buyer)dgvBuyers.SelectedRows[0].DataBoundItem;
            _currentSearchSeller = null;

            UpdateCUSearchUI();
            PerformSearch();

            tabControl1.SelectedTab = tabPageSearch; // Перехід на вкладку пошуку
        }

        private void AddBuyerBtn_Click(object sender, EventArgs e)
        {
            using (var addBuyer = new AddBuyerForm())
            {
                if (addBuyer.ShowDialog() == DialogResult.OK)
                {
                    _service.AddBuyer(addBuyer._Buyer);
                }
            }
        }
        private void DeleteBuyerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBuyers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Будь ласка, оберіть покупця для видалення.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Buyer selectedBuyer = (Buyer)dgvBuyers.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show($"Ви впевнені, що хочете видалити заявку на покупку '{selectedBuyer.ProductName}'?",
                                             "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _service.RemoveBuyer(selectedBuyer);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла помилка під час видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchBuyersBtn_Click(object sender, EventArgs e)
        {
            if (dgvSellers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть продавця зі списку, щоб знайти для нього варіанти.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Отримуємо об'єкт з таблиці
            _currentSearchSeller = (Seller)dgvSellers.SelectedRows[0].DataBoundItem;
            _currentSearchBuyer = null;

            UpdateCUSearchUI();
            PerformSearch();

            tabControl1.SelectedTab = tabPageSearch; // Перехід на вкладку пошуку
        }

        // Оновлення інформації в лейблі про обраного клієнта для якого ведеться пошук
        private void UpdateCUSearchUI()
        {
            if (_currentSearchSeller != null)
            {
                lblSearchRole.Text = "Шукаємо: ПОКУПЦІВ для обраного продавця";
                lblClientProduct.Text = $"Товар: {_currentSearchSeller.ProductName}";
                lblClientPrice.Text = $"Ціна продавця: {_currentSearchSeller.Price} грн";
                lblClientQuantity.Text = $"Обсяг: {_currentSearchSeller.Quantity} шт.";
            }
            else if (_currentSearchBuyer != null)
            {
                lblSearchRole.Text = "Шукаємо: ПРОДАВЦІВ для обраного покупця";
                lblClientProduct.Text = $"Товар: {_currentSearchBuyer.ProductName}";
                lblClientPrice.Text = $"Готовий заплатити до: {_currentSearchBuyer.MaxPrice} грн";
                lblClientQuantity.Text = $"Потрібний обсяг: {_currentSearchBuyer.Quantity} шт.";
            }
        }
        //Функція пошуку співпадінь
        private void PerformSearch()
        {
            try
            {
                bool sortByQuantity = rbSortByQuantity != null && rbSortByQuantity.Checked;

                if (_currentSearchSeller != null)
                {
                    BindingList<Buyer> results = _service.FindMatchingBuyers(_currentSearchSeller, sortByQuantity);
                    dgvSearchResults.DataSource = results;
                }
                else if (_currentSearchBuyer != null)
                {
                    BindingList<Seller> results = _service.FindMatchingSellers(_currentSearchBuyer, sortByQuantity);
                    dgvSearchResults.DataSource = results;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час пошуку варіантів. Перевірте введені дані.", "Помилка пошуку", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
