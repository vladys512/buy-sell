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

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Завантажуємо дані при старті програми
            _service = DataStorageManager.LoadData();

            // Прив'язуємо дані до таблиць
            dgvSellers.DataSource = _service.Sellers;
            dgvBuyers.DataSource = _service.Buyers;
            dgvArchive.DataSource = _service.DealsArchive;

            cmbSortOptions.Items.Clear();
            cmbSortOptions.Items.AddRange(new string[] { "Без сортування", "За ціною", "За обсягом" });
            cmbSortOptions.SelectedIndex = 0;

            lblClientPrice.Visible = false;
            lblClientProduct.Visible = false;
            lblClientQuantity.Visible = false;
            lblSearchRole.Visible = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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
        // Обробник натискання клавіш для таблиці продавців
        private void dgvSellers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSellerBtn_Click(sender, e);

                e.Handled = true;
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

            tabControl1.SelectedTab = tabPageSearch;
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
        // Обробник натискання клавіш для таблиці покупців
        private void dgvBuyers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteBuyerBtn_Click(sender, e);
                e.Handled = true;
            }
        }

        private void SearchBuyersBtn_Click(object sender, EventArgs e)
        {
            if (dgvSellers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть продавця зі списку, щоб знайти для нього варіанти.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _currentSearchSeller = (Seller)dgvSellers.SelectedRows[0].DataBoundItem;
            _currentSearchBuyer = null;

            UpdateCUSearchUI();
            PerformSearch();

            tabControl1.SelectedTab = tabPageSearch;
        }

        // Оновлення інформації в лейблі про обраного клієнта для якого ведеться пошук
        private void UpdateCUSearchUI()
        {
            if (_currentSearchSeller != null)
            {
                lblClientPrice.Visible = true;
                lblClientProduct.Visible = true;
                lblClientQuantity.Visible = true;
                lblSearchRole.Visible = true;
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
        /// <summary>
        /// Програмно налаштовує зовнішній вигляд та заголовки таблиці пошуку
        /// </summary>
        /// <param name="showingBuyers">Якщо true — налаштовуємо під покупців, якщо false — під продавців</param>
        private void SetupSearchResultsColumns(bool showingBuyers)
        {
            dgvSearchResults.AutoGenerateColumns = true;

            if (dgvSearchResults.Columns.Contains("Id"))
                dgvSearchResults.Columns["Id"].Visible = false;

            if (dgvSearchResults.Columns.Contains("IsActive"))
                dgvSearchResults.Columns["IsActive"].Visible = false;

            if (showingBuyers)
            {
                if (dgvSearchResults.Columns.Contains("Name"))
                    dgvSearchResults.Columns["Name"].HeaderText = "Ім'я покупця";

                if (dgvSearchResults.Columns.Contains("ProductName"))
                    dgvSearchResults.Columns["ProductName"].HeaderText = "Найменування товару";

                if (dgvSearchResults.Columns.Contains("Quantity"))
                    dgvSearchResults.Columns["Quantity"].HeaderText = "Обсяг покупки";

                if (dgvSearchResults.Columns.Contains("MaxPrice"))
                    dgvSearchResults.Columns["MaxPrice"].HeaderText = "Прийнятна ціна (грн)";

                if (dgvSearchResults.Columns.Contains("PaymentType"))
                    dgvSearchResults.Columns["PaymentType"].HeaderText = "Форма оплати";

                if (dgvSearchResults.Columns.Contains("Contact"))
                    dgvSearchResults.Columns["Contact"].HeaderText = "Контактні дані";

                if (dgvSearchResults.Columns.Contains("Note"))
                    dgvSearchResults.Columns["Note"].HeaderText = "Примітка";
            }
            else
            {
                if (dgvSearchResults.Columns.Contains("Name"))
                    dgvSearchResults.Columns["Name"].HeaderText = "Ім'я продавця";

                if (dgvSearchResults.Columns.Contains("ProductName"))
                    dgvSearchResults.Columns["ProductName"].HeaderText = "Найменування товару";

                if (dgvSearchResults.Columns.Contains("Quantity"))
                    dgvSearchResults.Columns["Quantity"].HeaderText = "Обсяг партії (опт)";

                if (dgvSearchResults.Columns.Contains("Price"))
                    dgvSearchResults.Columns["Price"].HeaderText = "Ціна (грн)";

                if (dgvSearchResults.Columns.Contains("DeliveryTerms"))
                    dgvSearchResults.Columns["DeliveryTerms"].HeaderText = "Умови відвантаження";

                if (dgvSearchResults.Columns.Contains("PaymentType"))
                    dgvSearchResults.Columns["PaymentType"].HeaderText = "Форма оплати";

                if (dgvSearchResults.Columns.Contains("Contact"))
                    dgvSearchResults.Columns["Contact"].HeaderText = "Контактні дані";

                if (dgvSearchResults.Columns.Contains("Note"))
                    dgvSearchResults.Columns["Note"].HeaderText = "Примітка";
            }
            dgvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchResults.MultiSelect = false;
            dgvSearchResults.AllowUserToAddRows = false;
            dgvSearchResults.ReadOnly = true;
            dgvSearchResults.RowHeadersVisible = false;
        }

        private ExchangeService.SortOption GetSelectedSortOption()
        {
            switch (cmbSortOptions.SelectedIndex)
            {
                case 1: return ExchangeService.SortOption.ByPrice;
                case 2: return ExchangeService.SortOption.ByQuantity;
                default: return ExchangeService.SortOption.None;
            }
        }

        private void PerformSearch()
        {
            try
            {
                ExchangeService.SortOption activeSort = GetSelectedSortOption();

                if (_currentSearchSeller != null)
                {
                    dgvSearchResults.DataSource = _service.FindMatchingBuyers(_currentSearchSeller, activeSort);
                    SetupSearchResultsColumns(showingBuyers: true);
                }
                else if (_currentSearchBuyer != null)
                {
                    dgvSearchResults.DataSource = _service.FindMatchingSellers(_currentSearchBuyer, activeSort);
                    SetupSearchResultsColumns(showingBuyers: false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час фільтрації варіантів.", "Помилка пошуку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshMainTables()
        {
            // Примусово сповіщаємо таблицю архіву про оновлення статусів задоволеності
            dgvArchive.Invalidate();
        }
        private void MakeDealBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSearchResults.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Будь ласка, оберіть варіант зі списку.",
                                    "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Seller targetSeller = null;
                Buyer targetBuyer = null;

                if (_currentSearchSeller != null)
                {
                    targetSeller = _currentSearchSeller;
                    targetBuyer = (Buyer)dgvSearchResults.SelectedRows[0].DataBoundItem;
                }
                else if (_currentSearchBuyer != null)
                {
                    targetBuyer = _currentSearchBuyer;
                    targetSeller = (Seller)dgvSearchResults.SelectedRows[0].DataBoundItem;
                }

                // Вікно підтвердження параметрів перед фіксацією
                using (var confirmForm = new DealConfirmationForm(targetSeller, targetBuyer))
                {
                    if (confirmForm.ShowDialog() == DialogResult.OK)
                    {
                        Deal completedDeal = _service.MakeDeal(targetSeller, targetBuyer);

                        PerformSearch();
                        RefreshMainTables();

                        var sellerFeedback = MessageBox.Show(
                            $"Угоду оформлено.\n\nЧи задоволений ПРОДАВЕЦЬ (контакт: {completedDeal.SellerContact}) умовами та проведенням операції?",
                            "Опитування сторін: Продавець",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        completedDeal.IsSellerSatisfied = (sellerFeedback == DialogResult.Yes);

                        var buyerFeedback = MessageBox.Show(
                            $"Чи задоволений ПОКУПЕЦЬ (контакт: {completedDeal.BuyerContact}) умовами та проведенням операції?",
                            "Опитування сторін: Покупець",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        completedDeal.IsBuyerSatisfied = (buyerFeedback == DialogResult.Yes);

                        RefreshMainTables();

                        DataStorageManager.SaveData(_service);

                        MessageBox.Show("Інформацію про угоду та відгуки клієнтів успішно збережено в архіві системи.",
                                        "Операцію завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла непередбачувана помилка при оформленні угоди. Перевірте коректність даних.",
                                "Помилка системи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PrintSellerAnnouncementBtn_Click(object sender, EventArgs e)
        {
            if (dgvSellers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть запис для формування оголошення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Seller selectedSeller = (Seller)dgvSellers.SelectedRows[0].DataBoundItem;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.FileName = $"Оголошення_Продаж_{selectedSeller.ProductName}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string announcement = AnnouncementService.GenerateSellerAnnouncement(selectedSeller);
                        System.IO.File.WriteAllText(sfd.FileName, announcement);
                        MessageBox.Show("Оголошення успішно збережено та готове до друку!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // За бажанням: автоматично відкрити файл у Блокноті
                        System.Diagnostics.Process.Start("notepad.exe", sfd.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Помилка при створенні файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void PrintBuyerAnnouncementBtn_Click(object sender, EventArgs e)
        {
            if (dgvBuyers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть запис для формування оголошення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Buyer selectedBuyer = (Buyer)dgvBuyers.SelectedRows[0].DataBoundItem;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.FileName = $"Оголошення_Купівля_{selectedBuyer.ProductName}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string announcement = AnnouncementService.GenerateBuyerAnnouncement(selectedBuyer);

                        System.IO.File.WriteAllText(sfd.FileName, announcement);
                        MessageBox.Show("Оголошення успішно збережено та готове до друку!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // За бажанням: автоматично відкрити файл у Блокноті
                        System.Diagnostics.Process.Start("notepad.exe", sfd.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Помилка при створенні файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Вимога методички: F1 – допомога
            if (e.KeyCode == Keys.F1)
            {
                ShowHelpBulletin();
                e.Handled = true;
            }
        }
        /// <summary>
        /// Вікно довідки
        /// </summary>
        private void ShowHelpBulletin()
        {
            string helpText = "Ласкаво просимо до інформаційної системи «Біржа товарів»!\n\n" +
                              "Програма призначена для реєстрації заявок покупців, пропозицій продавців " +
                              "та автоматичного пошуку взаємовигідних варіантів для укладання угод.\n\n" +
                              "Правила використання клавіатури в системі:\n" +
                              "• [F1] – Виклик цього вікна довідки;\n" +
                              "• [Delete] – Вилучення обраного клієнта з активної таблиці;\n" +
                              "• [Enter] – Підтвердження збереження даних (у вікнах вводу);\n" +
                              "• [Esc] – Скасування поточної операції або закриття діалогового вікна;\n" +
                              "• [Tab] – Перехід до наступного текстового поля;\n" +
                              "• [Shift + Tab] – Повернення до попереднього текстового поля.\n\n" +
                              "Всі дії, які призводять до видалення інформації, потребують Вашого підтвердження.";

            MessageBox.Show(helpText, "Довідка користувача системи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
