namespace BuySell
{
    partial class AddSellerForm
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
            tbProductName = new TextBox();
            tbQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPrice = new TextBox();
            label4 = new Label();
            tbDeliveryTerms = new TextBox();
            label5 = new Label();
            tbPaymentType = new TextBox();
            label6 = new Label();
            tbContact = new TextBox();
            label7 = new Label();
            tbNote = new TextBox();
            SaveBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(84, 16);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(341, 27);
            tbProductName.TabIndex = 0;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(127, 71);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(341, 27);
            tbQuantity.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Товар:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 74);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Обсяг партії:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 127);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Ціна:";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(74, 124);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(341, 27);
            tbPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 182);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 6;
            label4.Text = "Умови продажу-відв.:";
            // 
            // tbDeliveryTerms
            // 
            tbDeliveryTerms.Location = new Point(190, 179);
            tbDeliveryTerms.Name = "tbDeliveryTerms";
            tbDeliveryTerms.Size = new Size(341, 27);
            tbDeliveryTerms.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 230);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 8;
            label5.Text = "Форма оплати:";
            // 
            // tbPaymentType
            // 
            tbPaymentType.Location = new Point(143, 227);
            tbPaymentType.Name = "tbPaymentType";
            tbPaymentType.Size = new Size(341, 27);
            tbPaymentType.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 280);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Контакти:";
            // 
            // tbContact
            // 
            tbContact.Location = new Point(105, 277);
            tbContact.Name = "tbContact";
            tbContact.Size = new Size(341, 27);
            tbContact.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 330);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 12;
            label7.Text = "Примітки:";
            // 
            // tbNote
            // 
            tbNote.Location = new Point(108, 327);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(341, 27);
            tbNote.TabIndex = 13;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(127, 374);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(134, 44);
            SaveBtn.TabIndex = 14;
            SaveBtn.Text = "Зберегти";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(267, 374);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(134, 44);
            CancelBtn.TabIndex = 15;
            CancelBtn.Text = "Скасувати";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AddSellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(tbNote);
            Controls.Add(label7);
            Controls.Add(tbContact);
            Controls.Add(label6);
            Controls.Add(tbPaymentType);
            Controls.Add(label5);
            Controls.Add(tbDeliveryTerms);
            Controls.Add(label4);
            Controls.Add(tbPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbQuantity);
            Controls.Add(tbProductName);
            Name = "AddSellerForm";
            Text = "Form2";
            Load += AddSellerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProductName;
        private TextBox tbQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbPrice;
        private Label label4;
        private TextBox tbDeliveryTerms;
        private Label label5;
        private TextBox tbPaymentType;
        private Label label6;
        private TextBox tbContact;
        private Label label7;
        private TextBox tbNote;
        private Button SaveBtn;
        private Button CancelBtn;
    }
}