namespace Payment2
{
    partial class frmPayment
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
            groupBox1 = new GroupBox();
            rdoBillCustomer = new RadioButton();
            rdoCreditCard = new RadioButton();
            label1 = new Label();
            lstCreditCardType = new ListBox();
            label2 = new Label();
            txtCardNumber = new TextBox();
            label3 = new Label();
            cboExpirationMonth = new ComboBox();
            cboExpirationYear = new ComboBox();
            chkDefault = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoBillCustomer);
            groupBox1.Controls.Add(rdoCreditCard);
            groupBox1.Location = new Point(33, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            rdoBillCustomer.AutoSize = true;
            rdoBillCustomer.Location = new Point(325, 43);
            rdoBillCustomer.Name = "rdoBillCustomer";
            rdoBillCustomer.Size = new Size(116, 24);
            rdoBillCustomer.TabIndex = 1;
            rdoBillCustomer.Text = "Bill customer";
            rdoBillCustomer.UseVisualStyleBackColor = true;
            rdoBillCustomer.CheckedChanged += Billing_CheckChanged;
            // 
            // rdoCreditCard
            // 
            rdoCreditCard.AutoSize = true;
            rdoCreditCard.Checked = true;
            rdoCreditCard.Location = new Point(69, 43);
            rdoCreditCard.Name = "rdoCreditCard";
            rdoCreditCard.Size = new Size(103, 24);
            rdoCreditCard.TabIndex = 0;
            rdoCreditCard.TabStop = true;
            rdoCreditCard.Text = "Credit card";
            rdoCreditCard.UseVisualStyleBackColor = true;
            rdoCreditCard.CheckedChanged += Billing_CheckChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 163);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 1;
            label1.Text = "Credit card type:";
            // 
            // lstCreditCardType
            // 
            lstCreditCardType.FormattingEnabled = true;
            lstCreditCardType.Items.AddRange(new object[] { "Visa", "Mastercard", "American Express" });
            lstCreditCardType.Location = new Point(199, 163);
            lstCreditCardType.Name = "lstCreditCardType";
            lstCreditCardType.Size = new Size(334, 104);
            lstCreditCardType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 294);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Card number:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(199, 291);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(334, 27);
            txtCardNumber.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 354);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 5;
            label3.Text = "Expiration date:";
            // 
            // cboExpirationMonth
            // 
            cboExpirationMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationMonth.FormattingEnabled = true;
            cboExpirationMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cboExpirationMonth.Location = new Point(199, 346);
            cboExpirationMonth.Name = "cboExpirationMonth";
            cboExpirationMonth.Size = new Size(151, 28);
            cboExpirationMonth.TabIndex = 6;
            // 
            // cboExpirationYear
            // 
            cboExpirationYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpirationYear.FormattingEnabled = true;
            cboExpirationYear.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            cboExpirationYear.Location = new Point(382, 346);
            cboExpirationYear.Name = "cboExpirationYear";
            cboExpirationYear.Size = new Size(151, 28);
            cboExpirationYear.TabIndex = 7;
            // 
            // chkDefault
            // 
            chkDefault.AutoSize = true;
            chkDefault.Checked = true;
            chkDefault.CheckState = CheckState.Checked;
            chkDefault.Location = new Point(33, 416);
            chkDefault.Name = "chkDefault";
            chkDefault.Size = new Size(223, 24);
            chkDefault.TabIndex = 8;
            chkDefault.Text = "Set as default billing method";
            chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(324, 451);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(439, 451);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(569, 503);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkDefault);
            Controls.Add(cboExpirationYear);
            Controls.Add(cboExpirationMonth);
            Controls.Add(label3);
            Controls.Add(txtCardNumber);
            Controls.Add(label2);
            Controls.Add(lstCreditCardType);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "frmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += frmPayment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoBillCustomer;
        private RadioButton rdoCreditCard;
        private Label label1;
        private ListBox lstCreditCardType;
        private Label label2;
        private TextBox txtCardNumber;
        private Label label3;
        private ComboBox cboExpirationMonth;
        private ComboBox cboExpirationYear;
        private CheckBox chkDefault;
        private Button btnOK;
        private Button btnCancel;
    }
}