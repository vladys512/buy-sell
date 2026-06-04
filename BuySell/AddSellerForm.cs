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
            if (string.IsNullOrWhiteSpace(tbProductName.Text) ||
                string.IsNullOrWhiteSpace(tbContact.Text))
            {
                MessageBox.Show("Заповніть обов'язкові поля: Товар та Контакт!",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Валідація кількості
            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Кількість повинна бути цілим числом більше 0!",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Валідація ціни
            if (!decimal.TryParse(tbPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Ціна повинна бути числом більше 0!",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Усі перевірки пройдені — створюємо об'єкт
            _Seller = new Seller(
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
