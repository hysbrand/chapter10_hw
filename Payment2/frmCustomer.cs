using System;
using System.Windows.Forms;

namespace Payment2
{
    public partial class frmCustomer : Form
    {
        private bool isDataSaved = true;
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cboNames.Items.Add("Nancy Jones");
            cboNames.Items.Add("Bill More");
            cboNames.Items.Add("John Smith");
            cboNames.SelectedIndex = 0;
        }
        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            frmPayment paymentForm = new frmPayment();
            DialogResult result = paymentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblPayment.Text = paymentForm.PaymentDescription;
                isDataSaved = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDataSaved)
            {
                DialogResult button = MessageBox.Show(
                    "Do you want to save this data?",
                    "Data not saved", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (button == DialogResult.Yes)
                {
                    SaveData();
                }
                else if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPayment.Text = "";
            isDataSaved = false;
        }
        private void lblPayment_TextChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
        }
        private bool IsValidData()
        {
            if (cboNames.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer name.");
                cboNames.Focus();
                return true;
            }
            if (lblPayment.Text == "")
            {
                MessageBox.Show("Please select a payment method.");
                btnSelectPayment.Focus();
                return false;
            }
            return true;
        }
        private void SaveData()
        {
            if (IsValidData())
            {
                MessageBox.Show("The data has been saved.", "Save");
                isDataSaved = true;
            }
        }
    }
}
