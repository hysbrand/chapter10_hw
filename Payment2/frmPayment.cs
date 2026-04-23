using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payment2
{
    public partial class frmPayment : Form
    {
        public string PaymentDescription { get; private set; }
        public frmPayment()
        {
            InitializeComponent();
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            lstCreditCardType.SelectedIndex = 0;
            cboExpirationMonth.SelectedIndex = 0;
            cboExpirationYear.SelectedIndex = 0;
            EnableControls();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
                this.DialogResult = DialogResult.OK;
            }
        }
        private void Billing_CheckChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
                EnableControls();
            else DisableControls();
        }
        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboExpirationMonth.Enabled = true;
            cboExpirationYear.Enabled = true;
            chkDefault.Enabled = true;
        }
        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboExpirationMonth.Enabled = false;
            cboExpirationYear.Enabled = false;
            chkDefault.Enabled = false;
        }
        private bool IsValidData()
        {
            if (rdoCreditCard.Checked)
            {
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show("Enter card number.");
                    txtCardNumber.Focus();
                    return false;
                }
            }
            return true;
        }
        private void SaveData()
        {
            if (rdoCreditCard.Checked)
            {
                PaymentDescription =
                    "Charge to credit card.\n" +
                    "Card type: " + lstCreditCardType.Text + "\n" +
                    "Card number: " + txtCardNumber.Text + "\n" +
                    "Expiration date: " + cboExpirationMonth.Text + "/" + cboExpirationYear + "\n" +
                    "Default billing: " + chkDefault.Checked;
            }
            else
            {
                PaymentDescription = "Bill Customer";
            }
        }
    }
}
