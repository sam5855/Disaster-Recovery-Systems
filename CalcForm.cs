using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disaster_Recovery_Solution
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();

            loanDetailsDGV.DataSource = Inventory.AllLoans;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        private void calculateLoanButton_Click(object sender, EventArgs e)
        {
            int loanID;
            string loanDate;
            int initialRate;
            string repaymentMethod;
            int loanTerm;
            int amortizedTerm;
            decimal amountBorrowed;
            int paymentFrequency;
            string firstPaymentDate;
            string maturityDate;
            decimal paymentAmountOverride;

            //Include error handling later

            //----------------------------

            loanID = (Inventory.AllLoans.Count + 1);
            loanDate = loanDatePicker.Text;
            initialRate = int.Parse(initialRateTextBox.Text);
            repaymentMethod = repaymentMethodComboBox.Text;
            loanTerm = int.Parse(loanTermTextBox.Text);
            amortizedTerm = int.Parse(amortizedTermTextBox.Text);
            amountBorrowed = decimal.Parse(amountBorrowedTextBox.Text);
            paymentFrequency = int.Parse(paymentFreqComboBox.Text);
            firstPaymentDate = firstPaymentDatePicker.Text;
            maturityDate = maturityDatePicker.Text;
            paymentAmountOverride = decimal.Parse(paymentAmountOverrideTextBox.Text);

            Loan newLoan = new Loan(loanID, loanDate, initialRate, repaymentMethod, loanTerm, amortizedTerm, amountBorrowed, paymentFrequency, firstPaymentDate, maturityDate, paymentAmountOverride);
            Inventory.AddLoan(newLoan);








        }
    }
}
