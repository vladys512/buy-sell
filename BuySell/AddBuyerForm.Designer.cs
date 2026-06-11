namespace BuySell
{
    partial class AddBuyerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbProductName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbQuantity = new TextBox();
            tbMaxPrice = new TextBox();
            tbPaymentType = new TextBox();
            tbContact = new TextBox();
            tbNote = new TextBox();
            SaveBtn = new Button();
            CancelBtn = new Button();
            tbBuyerName = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Товар:";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(174, 21);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(228, 27);
            tbProductName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 107);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Обсяг товару:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 149);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 6;
            label3.Text = "Максимальна ціна:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 192);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "Форма оплати:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 231);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Контакти:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 273);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 9;
            label6.Text = "Примітки:";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(174, 104);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(228, 27);
            tbQuantity.TabIndex = 10;
            // 
            // tbMaxPrice
            // 
            tbMaxPrice.Location = new Point(174, 146);
            tbMaxPrice.Name = "tbMaxPrice";
            tbMaxPrice.Size = new Size(228, 27);
            tbMaxPrice.TabIndex = 11;
            // 
            // tbPaymentType
            // 
            tbPaymentType.Location = new Point(174, 189);
            tbPaymentType.Name = "tbPaymentType";
            tbPaymentType.Size = new Size(228, 27);
            tbPaymentType.TabIndex = 12;
            // 
            // tbContact
            // 
            tbContact.Location = new Point(174, 228);
            tbContact.Name = "tbContact";
            tbContact.Size = new Size(228, 27);
            tbContact.TabIndex = 13;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(174, 270);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(228, 27);
            tbNote.TabIndex = 14;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(110, 393);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(133, 48);
            SaveBtn.TabIndex = 15;
            SaveBtn.Text = "Зберегти";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(249, 393);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(133, 48);
            CancelBtn.TabIndex = 16;
            CancelBtn.Text = "Скасувати";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // tbBuyerName
            // 
            tbBuyerName.Location = new Point(174, 62);
            tbBuyerName.Name = "tbBuyerName";
            tbBuyerName.Size = new Size(228, 27);
            tbBuyerName.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 65);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 18;
            label7.Text = "Ім'я";
            // 
            // AddBuyerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(label7);
            Controls.Add(tbBuyerName);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(tbNote);
            Controls.Add(tbContact);
            Controls.Add(tbPaymentType);
            Controls.Add(tbMaxPrice);
            Controls.Add(tbQuantity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbProductName);
            Controls.Add(label1);
            Name = "AddBuyerForm";
            Text = "Додавання покупця";
            Load += AddBuyerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbProductName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbQuantity;
        private TextBox tbMaxPrice;
        private TextBox tbPaymentType;
        private TextBox tbContact;
        private TextBox tbNote;
        private Button SaveBtn;
        private Button CancelBtn;
        private TextBox tbBuyerName;
        private Label label7;
    }
}