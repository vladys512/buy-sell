namespace BuySell
{
    partial class DealConfirmationForm
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
            lblInfo = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(89, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(50, 20);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "label1";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(89, 386);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(182, 52);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Підтвердити";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(277, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(182, 52);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DealConfirmationForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(538, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblInfo);
            Name = "DealConfirmationForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnConfirm;
        private Button btnCancel;
    }
}