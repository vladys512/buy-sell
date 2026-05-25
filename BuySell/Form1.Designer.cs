namespace BuySell
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            FindBuyersBtn = new Button();
            DeleteSellerBtn = new Button();
            AddSeller = new Button();
            dgvSellers = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deliveryTermsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellerBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            FindSellersBtn = new Button();
            dgvBuyers = new DataGridView();
            productNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            contactDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            buyerBindingSource = new BindingSource(components);
            DeleteBuyerBtn = new Button();
            AddBuyerBtn = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSellers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellerBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buyerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(902, 453);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(FindBuyersBtn);
            tabPage1.Controls.Add(DeleteSellerBtn);
            tabPage1.Controls.Add(AddSeller);
            tabPage1.Controls.Add(dgvSellers);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(894, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Продавці";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // FindBuyersBtn
            // 
            FindBuyersBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FindBuyersBtn.Location = new Point(6, 360);
            FindBuyersBtn.Name = "FindBuyersBtn";
            FindBuyersBtn.Size = new Size(878, 54);
            FindBuyersBtn.TabIndex = 3;
            FindBuyersBtn.Text = "Пошук покупців";
            FindBuyersBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteSellerBtn
            // 
            DeleteSellerBtn.Location = new Point(148, 6);
            DeleteSellerBtn.Name = "DeleteSellerBtn";
            DeleteSellerBtn.Size = new Size(136, 44);
            DeleteSellerBtn.TabIndex = 2;
            DeleteSellerBtn.Text = "Видалити";
            DeleteSellerBtn.UseVisualStyleBackColor = true;
            DeleteSellerBtn.Click += DeleteSellerBtn_Click;
            // 
            // AddSeller
            // 
            AddSeller.Location = new Point(6, 6);
            AddSeller.Name = "AddSeller";
            AddSeller.Size = new Size(136, 44);
            AddSeller.TabIndex = 1;
            AddSeller.Text = "Додати";
            AddSeller.UseVisualStyleBackColor = true;
            AddSeller.Click += button1_Click;
            // 
            // dgvSellers
            // 
            dgvSellers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSellers.AutoGenerateColumns = false;
            dgvSellers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSellers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSellers.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, deliveryTermsDataGridViewTextBoxColumn, paymentTypeDataGridViewTextBoxColumn, contactDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn });
            dgvSellers.DataSource = sellerBindingSource;
            dgvSellers.Location = new Point(6, 56);
            dgvSellers.Name = "dgvSellers";
            dgvSellers.ReadOnly = true;
            dgvSellers.RowHeadersVisible = false;
            dgvSellers.RowHeadersWidth = 51;
            dgvSellers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSellers.Size = new Size(878, 298);
            dgvSellers.TabIndex = 0;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Товар";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Обсяг партії";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryTermsDataGridViewTextBoxColumn
            // 
            deliveryTermsDataGridViewTextBoxColumn.DataPropertyName = "DeliveryTerms";
            deliveryTermsDataGridViewTextBoxColumn.HeaderText = "Умови";
            deliveryTermsDataGridViewTextBoxColumn.MinimumWidth = 6;
            deliveryTermsDataGridViewTextBoxColumn.Name = "deliveryTermsDataGridViewTextBoxColumn";
            deliveryTermsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            paymentTypeDataGridViewTextBoxColumn.HeaderText = "Форма оплати";
            paymentTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            contactDataGridViewTextBoxColumn.HeaderText = "Контакти";
            contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "Примітки";
            noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerBindingSource
            // 
            sellerBindingSource.DataSource = typeof(Seller);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(FindSellersBtn);
            tabPage2.Controls.Add(dgvBuyers);
            tabPage2.Controls.Add(DeleteBuyerBtn);
            tabPage2.Controls.Add(AddBuyerBtn);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(894, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Покупці";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FindSellersBtn
            // 
            FindSellersBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FindSellersBtn.Location = new Point(6, 360);
            FindSellersBtn.Name = "FindSellersBtn";
            FindSellersBtn.Size = new Size(878, 54);
            FindSellersBtn.TabIndex = 5;
            FindSellersBtn.Text = "Пошук покупців";
            FindSellersBtn.UseVisualStyleBackColor = true;
            // 
            // dgvBuyers
            // 
            dgvBuyers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBuyers.AutoGenerateColumns = false;
            dgvBuyers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuyers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuyers.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn1, quantityDataGridViewTextBoxColumn1, maxPriceDataGridViewTextBoxColumn, paymentTypeDataGridViewTextBoxColumn1, contactDataGridViewTextBoxColumn1, noteDataGridViewTextBoxColumn1 });
            dgvBuyers.DataSource = buyerBindingSource;
            dgvBuyers.Location = new Point(6, 56);
            dgvBuyers.Name = "dgvBuyers";
            dgvBuyers.ReadOnly = true;
            dgvBuyers.RowHeadersVisible = false;
            dgvBuyers.RowHeadersWidth = 51;
            dgvBuyers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuyers.Size = new Size(878, 298);
            dgvBuyers.TabIndex = 4;
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn1.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            productNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maxPriceDataGridViewTextBoxColumn
            // 
            maxPriceDataGridViewTextBoxColumn.DataPropertyName = "MaxPrice";
            maxPriceDataGridViewTextBoxColumn.HeaderText = "MaxPrice";
            maxPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxPriceDataGridViewTextBoxColumn.Name = "maxPriceDataGridViewTextBoxColumn";
            maxPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn1
            // 
            paymentTypeDataGridViewTextBoxColumn1.DataPropertyName = "PaymentType";
            paymentTypeDataGridViewTextBoxColumn1.HeaderText = "PaymentType";
            paymentTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            paymentTypeDataGridViewTextBoxColumn1.Name = "paymentTypeDataGridViewTextBoxColumn1";
            paymentTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn1
            // 
            contactDataGridViewTextBoxColumn1.DataPropertyName = "Contact";
            contactDataGridViewTextBoxColumn1.HeaderText = "Contact";
            contactDataGridViewTextBoxColumn1.MinimumWidth = 6;
            contactDataGridViewTextBoxColumn1.Name = "contactDataGridViewTextBoxColumn1";
            contactDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn1.HeaderText = "Note";
            noteDataGridViewTextBoxColumn1.MinimumWidth = 6;
            noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            noteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // buyerBindingSource
            // 
            buyerBindingSource.DataSource = typeof(Buyer);
            // 
            // DeleteBuyerBtn
            // 
            DeleteBuyerBtn.Location = new Point(148, 6);
            DeleteBuyerBtn.Name = "DeleteBuyerBtn";
            DeleteBuyerBtn.Size = new Size(136, 44);
            DeleteBuyerBtn.TabIndex = 3;
            DeleteBuyerBtn.Text = "Видалити";
            DeleteBuyerBtn.UseVisualStyleBackColor = true;
            DeleteBuyerBtn.Click += DeleteBuyerBtn_Click;
            // 
            // AddBuyerBtn
            // 
            AddBuyerBtn.Location = new Point(6, 6);
            AddBuyerBtn.Name = "AddBuyerBtn";
            AddBuyerBtn.Size = new Size(136, 44);
            AddBuyerBtn.TabIndex = 2;
            AddBuyerBtn.Text = "Додати";
            AddBuyerBtn.UseVisualStyleBackColor = true;
            AddBuyerBtn.Click += AddBuyerBtn_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(894, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Пошук варіантів";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(894, 420);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Архів";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 453);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Біржа товарів";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSellers).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellerBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).EndInit();
            ((System.ComponentModel.ISupportInitialize)buyerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button DeleteSellerBtn;
        private Button AddSeller;
        private DataGridView dgvSellers;
        private Button DeleteBuyerBtn;
        private Button AddBuyerBtn;
        private BindingSource sellerBindingSource;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliveryTermsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private Button FindBuyersBtn;
        private DataGridView dgvBuyers;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private BindingSource buyerBindingSource;
        private Button FindSellersBtn;
    }
}
