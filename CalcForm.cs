﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace Disaster_Recovery_Solution
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();

            //Links data source to DataGridView
            loanDetailsDGV.DataSource = Inventory.AllLoans;

            //Removes blank row
            loanDetailsDGV.AllowUserToAddRows = false;

            //Enables full DGV row select
            loanDetailsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Makes DGV read only
            loanDetailsDGV.ReadOnly = true;

            //Makes only one DGV row selectable at a time
            loanDetailsDGV.MultiSelect = false;




            
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

        //Calculates and creates new Loan
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

            newLoan.totalFinancedWithFees = Calc.setTotalFinanced(repaymentMethod);


        }

        //Closes calc engine window
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Deletes selected loan
        private void deleteLoanButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this loan? This cannot be undone", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Gets selected part
                Loan deleteLoan = (Loan)loanDetailsDGV.CurrentRow.DataBoundItem;

                //Iterates through selected rows 
                foreach (DataGridViewRow row in loanDetailsDGV.SelectedRows)
                {
                    loanDetailsDGV.Rows.Remove(row);
                    return;
                }
            }
        }

        //Exports AllLoans list to CSV file
        private void exportCSVButton_Click(object sender, EventArgs e)
        {
            //var csvPath = Path.Combine("C:\\Users\\Sam\\Downloads\\", $"Loans-{DateTime.Today.ToFileTime}.csv");
            //using (var writer = new StreamWriter(csvPath))
            using (var writer = new StreamWriter($"C:\\Users\\Sam\\Downloads\\loans.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(Inventory.AllLoans);
            }
             


        }
    }
}
