using System;
using System.ComponentModel;

namespace BuySell
{
    public partial class Form1 : Form
    {
        private BindingList<Seller> Sellers = new BindingList<Seller>();
        public Form1()
        {
            InitializeComponent();
            dgvSellers.DataSource = Sellers;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
