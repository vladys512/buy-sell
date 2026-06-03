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
            tabPageSellers = new TabPage();
            SearchBuyersBtn = new Button();
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
            tabPageBuyers = new TabPage();
            SearchSellersBtn = new Button();
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
            tabPageSearch = new TabPage();
            label1 = new Label();
            button1 = new Button();
            rbSortByQuantity = new RadioButton();
            rbSortByPrice = new RadioButton();
            groupBox1 = new GroupBox();
            lblClientQuantity = new Label();
            lblClientPrice = new Label();
            lblClientProduct = new Label();
            lblSearchRole = new Label();
            dgvSearchResults = new DataGridView();
            tabPage4 = new TabPage();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPageSellers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSellers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sellerBindingSource).BeginInit();
            tabPageBuyers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buyerBindingSource).BeginInit();
            tabPageSearch.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSellers);
            tabControl1.Controls.Add(tabPageBuyers);
            tabControl1.Controls.Add(tabPageSearch);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(902, 453);
            tabControl1.TabIndex = 6;
            // 
            // tabPageSellers
            // 
            tabPageSellers.Controls.Add(SearchBuyersBtn);
            tabPageSellers.Controls.Add(DeleteSellerBtn);
            tabPageSellers.Controls.Add(AddSeller);
            tabPageSellers.Controls.Add(dgvSellers);
            tabPageSellers.Location = new Point(4, 29);
            tabPageSellers.Name = "tabPageSellers";
            tabPageSellers.Padding = new Padding(3);
            tabPageSellers.Size = new Size(894, 420);
            tabPageSellers.TabIndex = 0;
            tabPageSellers.Text = "Продавці";
            tabPageSellers.UseVisualStyleBackColor = true;
            tabPageSellers.Click += tabPage1_Click;
            // 
            // SearchBuyersBtn
            // 
            SearchBuyersBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchBuyersBtn.Location = new Point(6, 360);
            SearchBuyersBtn.Name = "SearchBuyersBtn";
            SearchBuyersBtn.Size = new Size(878, 54);
            SearchBuyersBtn.TabIndex = 3;
            SearchBuyersBtn.Text = "Пошук покупців";
            SearchBuyersBtn.UseVisualStyleBackColor = true;
            SearchBuyersBtn.Click += SearchBuyersBtn_Click;
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
            dgvSellers.MultiSelect = false;
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
            // tabPageBuyers
            // 
            tabPageBuyers.Controls.Add(SearchSellersBtn);
            tabPageBuyers.Controls.Add(dgvBuyers);
            tabPageBuyers.Controls.Add(DeleteBuyerBtn);
            tabPageBuyers.Controls.Add(AddBuyerBtn);
            tabPageBuyers.Location = new Point(4, 29);
            tabPageBuyers.Name = "tabPageBuyers";
            tabPageBuyers.Padding = new Padding(3);
            tabPageBuyers.Size = new Size(894, 420);
            tabPageBuyers.TabIndex = 1;
            tabPageBuyers.Text = "Покупці";
            tabPageBuyers.UseVisualStyleBackColor = true;
            // 
            // SearchSellersBtn
            // 
            SearchSellersBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchSellersBtn.Location = new Point(6, 360);
            SearchSellersBtn.Name = "SearchSellersBtn";
            SearchSellersBtn.Size = new Size(878, 54);
            SearchSellersBtn.TabIndex = 5;
            SearchSellersBtn.Text = "Пошук покупців";
            SearchSellersBtn.UseVisualStyleBackColor = true;
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
            dgvBuyers.MultiSelect = false;
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
            // tabPageSearch
            // 
            tabPageSearch.Controls.Add(label1);
            tabPageSearch.Controls.Add(button1);
            tabPageSearch.Controls.Add(rbSortByQuantity);
            tabPageSearch.Controls.Add(rbSortByPrice);
            tabPageSearch.Controls.Add(groupBox1);
            tabPageSearch.Controls.Add(dgvSearchResults);
            tabPageSearch.Location = new Point(4, 29);
            tabPageSearch.Name = "tabPageSearch";
            tabPageSearch.Size = new Size(894, 420);
            tabPageSearch.TabIndex = 2;
            tabPageSearch.Text = "Пошук варіантів";
            tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 138);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "Сортувати:";
            // 
            // button1
            // 
            button1.Location = new Point(428, 12);
            button1.Name = "button1";
            button1.Size = new Size(463, 54);
            button1.TabIndex = 4;
            button1.Text = "Оформити угоду";
            button1.UseVisualStyleBackColor = true;
            // 
            // rbSortByQuantity
            // 
            rbSortByQuantity.AutoSize = true;
            rbSortByQuantity.Location = new Point(769, 136);
            rbSortByQuantity.Name = "rbSortByQuantity";
            rbSortByQuantity.Size = new Size(109, 24);
            rbSortByQuantity.TabIndex = 3;
            rbSortByQuantity.TabStop = true;
            rbSortByQuantity.Text = "За обсягом";
            rbSortByQuantity.UseVisualStyleBackColor = true;
            rbSortByQuantity.CheckedChanged += rbSortByQuantity_CheckedChanged;
            // 
            // rbSortByPrice
            // 
            rbSortByPrice.AutoSize = true;
            rbSortByPrice.Location = new Point(670, 136);
            rbSortByPrice.Name = "rbSortByPrice";
            rbSortByPrice.Size = new Size(93, 24);
            rbSortByPrice.TabIndex = 2;
            rbSortByPrice.TabStop = true;
            rbSortByPrice.Text = "За ціною";
            rbSortByPrice.UseVisualStyleBackColor = true;
            rbSortByPrice.CheckedChanged += rbSortByPrice_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblClientQuantity);
            groupBox1.Controls.Add(lblClientPrice);
            groupBox1.Controls.Add(lblClientProduct);
            groupBox1.Controls.Add(lblSearchRole);
            groupBox1.Location = new Point(8, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 157);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вибраний клієнт";
            // 
            // lblClientQuantity
            // 
            lblClientQuantity.AutoSize = true;
            lblClientQuantity.Location = new Point(6, 83);
            lblClientQuantity.Name = "lblClientQuantity";
            lblClientQuantity.Size = new Size(50, 20);
            lblClientQuantity.TabIndex = 3;
            lblClientQuantity.Text = "label2";
            // 
            // lblClientPrice
            // 
            lblClientPrice.AutoSize = true;
            lblClientPrice.Location = new Point(6, 63);
            lblClientPrice.Name = "lblClientPrice";
            lblClientPrice.Size = new Size(50, 20);
            lblClientPrice.TabIndex = 2;
            lblClientPrice.Text = "label1";
            // 
            // lblClientProduct
            // 
            lblClientProduct.AutoSize = true;
            lblClientProduct.Location = new Point(6, 43);
            lblClientProduct.Name = "lblClientProduct";
            lblClientProduct.Size = new Size(50, 20);
            lblClientProduct.TabIndex = 1;
            lblClientProduct.Text = "label1";
            // 
            // lblSearchRole
            // 
            lblSearchRole.AutoSize = true;
            lblSearchRole.Location = new Point(6, 23);
            lblSearchRole.Name = "lblSearchRole";
            lblSearchRole.Size = new Size(50, 20);
            lblSearchRole.TabIndex = 0;
            lblSearchRole.Text = "label1";
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(8, 166);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.RowHeadersWidth = 51;
            dgvSearchResults.Size = new Size(878, 246);
            dgvSearchResults.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            tabPageSellers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSellers).EndInit();
            ((System.ComponentModel.ISupportInitialize)sellerBindingSource).EndInit();
            tabPageBuyers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBuyers).EndInit();
            ((System.ComponentModel.ISupportInitialize)buyerBindingSource).EndInit();
            tabPageSearch.ResumeLayout(false);
            tabPageSearch.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageSellers;
        private TabPage tabPageBuyers;
        private TabPage tabPageSearch;
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
        private Button SearchBuyersBtn;
        private DataGridView dgvBuyers;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private BindingSource buyerBindingSource;
        private Button SearchSellersBtn;
        private DataGridView dgvSearchResults;
        private GroupBox groupBox1;
        private Label lblSearchRole;
        private RadioButton rbSortByPrice;
        private RadioButton rbSortByQuantity;
        private Button button1;
        private Label lblClientQuantity;
        private Label lblClientPrice;
        private Label lblClientProduct;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
    }
}
