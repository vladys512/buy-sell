using BuySell.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuySell
{
    /// <summary>
    /// Модальне діалогове вікно для реєстрації нового запиту від покупця.
    /// </summary>
    public partial class AddBuyerForm : Form
    {
        public Buyer _Buyer { get; private set; }
        public AddBuyerForm()
        {
            InitializeComponent();
        }

        private void AddBuyerForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Валідація обов'язкових текстових полів
            if (string.IsNullOrWhiteSpace(tbBuyerName.Text))
            {
                MessageBox.Show("Будь ласка, вкажіть ім'я або найменування організації покупця. Це поле є обов'язковим для заповнення списку.",
                                "Заповніть форму", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBuyerName.Focus(); 
                return;
            }

            // 2. Перевірка найменування товару
            if (string.IsNullOrWhiteSpace(tbProductName.Text))
            {
                MessageBox.Show("Поле 'Найменування товару' не може бути порожнім. Будь ласка, введіть назву товару, який Ви шукаєте.",
                                "Заповніть форму", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbProductName.Focus();
                return;
            }

            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Необхідний обсяг покупки вказано некоректно. Будь ласка, введіть ціле додатне число (наприклад: 5, 120).",
                                "Некоректний формат даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbQuantity.Focus();
                return;
            }

            if (!decimal.TryParse(tbMaxPrice.Text, out decimal maxPrice) || maxPrice <= 0)
            {
                MessageBox.Show("Прийнятну ціну товару вказано некоректно. Будь ласка, введіть числове значення більше нуля (наприклад: 250 або 99.90).",
                                "Некоректний формат даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMaxPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbContact.Text))
            {
                MessageBox.Show("Будь ласка, заповніть контактні дані (номер телефону або адресу електронної пошти), щоб продавці могли зв'язатися з Вами для укладання угоди.",
                                "Заповніть форму", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbContact.Focus();
                return;
            }

            // Усі перевірки пройдені — створюємо об'єкт
            _Buyer = new Buyer(
                tbBuyerName.Text.Trim(),
                tbProductName.Text.Trim(),
                quantity,
                maxPrice,
                tbPaymentType.Text.Trim(),
                tbContact.Text.Trim(),
                tbNote.Text.Trim()
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
