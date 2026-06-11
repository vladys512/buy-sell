using BuySell.Models;
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
    public partial class AddSellerForm : Form
    {
        public Seller _Seller { get; private set; }
        public AddSellerForm()
        {
            InitializeComponent();
        }
        private void AddSellerForm_Load(object sender, EventArgs e)
        {

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Валідація обов'язкових текстових полів
            if (string.IsNullOrWhiteSpace(tbSellerName.Text))
            {
                MessageBox.Show("Будь ласка, вкажіть ім'я або найменування організації продавця. Це поле є обов'язковим для заповнення.",
                                "Заповніть форму", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSellerName.Focus(); 
                return;
            }

            if (string.IsNullOrWhiteSpace(tbProductName.Text))
            {
                MessageBox.Show("Поле 'Найменування товару' не може бути порожнім. Будь ласка, введіть назву товару.",
                                "Заповніть форму", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbProductName.Focus();
                return;
            }

            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Обсяг партії товару вказано некоректно. Будь ласка, введіть ціле додатне число (наприклад: 10, 250).",
                                "Некоректний формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbQuantity.Focus();
                return;
            }

            if (!decimal.TryParse(tbPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Ціну товару вказано некоректно. Будь ласка, введіть числове значення більше нуля (наприклад: 150 або 45.50).",
                                "Некоректний формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbContact.Text))
            {
                MessageBox.Show("Будь ласка, заповніть контактні дані (номер телефону або адресу електронної пошти), щоб покупці могли зв'язатися з Вами.",
                                "Заповніть форму", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbContact.Focus();
                return;
            }

            // Усі перевірки пройдені — створюємо об'єкт
            _Seller = new Seller(
                tbSellerName.Text.Trim(),
                tbProductName.Text.Trim(),
                quantity,
                price,
                tbDeliveryTerms.Text.Trim(),
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
