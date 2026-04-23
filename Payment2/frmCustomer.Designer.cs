namespace Payment2
{
    partial class frmCustomer
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
            label1 = new Label();
            cboNames = new ComboBox();
            label2 = new Label();
            lblPayment = new Label();
            btnSave = new Button();
            btnExit = new Button();
            btnSelectPayment = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer name:";
            // 
            // cboNames
            // 
            cboNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNames.FormattingEnabled = true;
            cboNames.Location = new Point(196, 30);
            cboNames.Name = "cboNames";
            cboNames.Size = new Size(453, 28);
            cboNames.TabIndex = 1;
            cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 115);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Payment method:";
            // 
            // lblPayment
            // 
            lblPayment.BorderStyle = BorderStyle.Fixed3D;
            lblPayment.Location = new Point(29, 151);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(379, 209);
            lblPayment.TabIndex = 3;
            lblPayment.TextChanged += lblPayment_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(435, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(555, 372);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSelectPayment
            // 
            btnSelectPayment.Location = new Point(435, 148);
            btnSelectPayment.Name = "btnSelectPayment";
            btnSelectPayment.Size = new Size(214, 29);
            btnSelectPayment.TabIndex = 6;
            btnSelectPayment.Text = "Select Payment";
            btnSelectPayment.UseVisualStyleBackColor = true;
            btnSelectPayment.Click += btnSelectPayment_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(690, 427);
            Controls.Add(btnSelectPayment);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblPayment);
            Controls.Add(label2);
            Controls.Add(cboNames);
            Controls.Add(label1);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            FormClosing += frmCustomer_FormClosing;
            Load += frmCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboNames;
        private Label label2;
        private Label lblPayment;
        private Button btnSave;
        private Button btnExit;
        private Button btnSelectPayment;
    }
}
