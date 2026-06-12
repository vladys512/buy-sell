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
    public partial class DealConfirmationForm : Form
    {
        public DealConfirmationForm(Seller seller, Buyer buyer)
        {
            InitializeComponent();

            int dealQuantity = Math.Min(seller.Quantity, buyer.Quantity);
            decimal totalSum = dealQuantity * seller.Price;

            lblInfo.Text = $"Підготовка угоди:\n\n" +
                           $"Товар: {seller.ProductName}\n" +
                           $"Обсяг угоди: {dealQuantity} шт.\n" +
                           $"Ціна за штуку: {seller.Price} грн\n" +
                           $"Загальна сума: {totalSum} грн\n\n" +
                           $"Контакт продавця: {seller.Contact}\n" +
                           $"Контакт покупця: {buyer.Contact}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
