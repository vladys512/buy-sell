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
        public Form1()
        {
            InitializeComponent();
            dgvSellers.DataSource = Sellers;
            dgvBuyers.DataSource = Buyers;
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

    }
}
