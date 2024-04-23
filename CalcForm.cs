using System;
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
            string accrualMethod;
            int paymentFrequency;
            string firstPaymentDate;
            string maturityDate;
            decimal paymentAmountOverride;

            string aprCollectionMethod;
            string jonCollectionMethod;
            string jon2CollectionMethod;
            string aprPayableBy;
            string jonPayableBy;
            string jon2PayableBy;
            decimal aprAmount;
            decimal jonAmount;
            decimal jon2Amount;
            string aprEffecting;
            string jonEffecting;
            string jon2Effecting;

                

            //Include error handling later

            //----------------------------

            //Transaction Inputs
            loanID = (Inventory.AllLoans.Count + 1);
            loanDate = loanDatePicker.Text;
            initialRate = int.Parse(initialRateTextBox.Text);
            repaymentMethod = repaymentMethodComboBox.Text;
            loanTerm = int.Parse(loanTermTextBox.Text);
            amortizedTerm = int.Parse(amortizedTermTextBox.Text);
            amountBorrowed = decimal.Parse(amountBorrowedTextBox.Text);
            accrualMethod = accrualMethodComboBox.Text;
            
           
            //Specified Term Inputs
            paymentFrequency = int.Parse(paymentFreqComboBox.Text);
            firstPaymentDate = firstPaymentDatePicker.Text;
            maturityDate = maturityDatePicker.Text;
            paymentAmountOverride = decimal.Parse(paymentAmountOverrideTextBox.Text);


            //Fee Inputs
            aprCollectionMethod = aprEffectingCollectionComboBox.Text;
            jonCollectionMethod = jonCollectionComboBox.Text;
            jon2CollectionMethod = jon2CollectionComboBox.Text;
            aprPayableBy = aprPayableComboBox.Text;
            jonPayableBy = jonPayableComboBox.Text;
            jon2PayableBy = jon2PayableComboBox.Text;
            aprAmount = decimal.Parse(aprAmountTextBox.Text);
            jonAmount = decimal.Parse(jonAmountTextBox.Text);
            jon2Amount = decimal.Parse(jon2AmountTextBox.Text);
            aprEffecting = aprAprComboBox.Text;
            jonEffecting = jonAprComboBox.Text;
            jon2Effecting = jon2AprComboBox.Text;




    
            Loan newLoan = new Loan(loanID, loanDate, initialRate, repaymentMethod, loanTerm, amortizedTerm, amountBorrowed, accrualMethod, paymentFrequency, firstPaymentDate, maturityDate, paymentAmountOverride, aprCollectionMethod, jonCollectionMethod, jon2CollectionMethod, aprPayableBy,
            jonPayableBy, jon2PayableBy, aprAmount, jonAmount, jon2Amount, aprEffecting, jonEffecting, jon2Effecting);
            Inventory.AddLoan(newLoan);

           


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
            using (var writer = new StreamWriter($"C:\\Users\\Sam\\Downloads\\LoanID-{DateTime.Now.ToString("yyy-MM-dd")}.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(Inventory.AllLoans);
            }
             


        }

        private void labelTotalFinancedWithFees_Click(object sender, EventArgs e)
        {

        }

        //Displays loan details in Loan Details text boxes based on selected row
        private void loanDetailsDGV_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in loanDetailsDGV.SelectedRows)
            {
                Loan displayLoan = (Loan)loanDetailsDGV.CurrentRow.DataBoundItem;
                textBoxTotalFinancedWithFees.Text = displayLoan.TotalFinancedWithFees.ToString();

                return;
            }
        }


        

        //Clears Loan Inputs
        private void clearInputsButton_Click(object sender, EventArgs e)
        {
            foreach (var grpBox in this.Controls.OfType<GroupBox>())
            {
                foreach (var textBox in grpBox.Controls.OfType<TextBox>())
                    textBox.Text = string.Empty;
                foreach (var comboBox in grpBox.Controls.OfType<ComboBox>())
                    comboBox.Text = string.Empty;
            }
        }


        //Loads Text file to populate input fields
        private void importProgressButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\";
            openFile.Title = "Select File to Import";
            //openFile.Filter = "Text Files Only (*.txt) | *.txt";
            openFile.DefaultExt = "txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                

                var lines = File.ReadAllLines(openFile.FileName);
                foreach (var line in lines)
                {
                    var col = line.Split(',');
                    loanDatePicker.Text = col[0];
                    initialRateTextBox.Text = col[1];
                    repaymentMethodComboBox.Text = col[2];
                    loanTermTextBox.Text = col[3];
                    amortizedTermTextBox.Text = col[4];
                    amountBorrowedTextBox.Text = col[5];
                    accrualMethodComboBox.Text = col[6];
                    paymentFreqComboBox.Text = col[7];
                    firstPaymentDatePicker.Text = col[8];
                    maturityDatePicker.Text = col[9];
                    paymentAmountOverrideTextBox.Text = col[10];
                    aprEffectingCollectionComboBox.Text = col[11];
                    aprPayableComboBox.Text = col[12];
                    aprAmountTextBox.Text = col[13];
                    aprAprComboBox.Text = col[14];
                    jonCollectionComboBox.Text = col[15];
                    jonPayableComboBox.Text = col[16];
                    jonAmountTextBox.Text = col[17];
                    jonAprComboBox.Text = col[18];
                    jon2CollectionComboBox.Text = col[19];
                    jon2PayableComboBox.Text= col[20];
                    jon2AmountTextBox.Text = col[21];
                    jon2AprComboBox.Text = col[22];
                }

            }


        }

        //Saves progress to text file
        private void exportProgressButton_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(Application);
            using (var writer = new StreamWriter($"C:\\Users\\Sam\\Downloads\\LoanID-{DateTime.Now.ToString("yyy-MM-dd")}.txt"))
            {
                writer.WriteLine(loanDatePicker.Text + "," + initialRateTextBox.Text + "," + repaymentMethodComboBox.Text + "," + loanTermTextBox.Text + 
                    "," + amortizedTermTextBox.Text + "," + amountBorrowedTextBox.Text + "," + accrualMethodComboBox.Text + "," + paymentFreqComboBox.Text +
                    "," + firstPaymentDatePicker.Text + "," + maturityDatePicker.Text + "," + paymentAmountOverrideTextBox.Text + "," + aprEffectingCollectionComboBox.Text + 
                    "," + aprPayableComboBox.Text + "," + aprAmountTextBox.Text + "," + aprAprComboBox.Text + "," + jonCollectionComboBox.Text + "," + jonPayableComboBox.Text + 
                    "," + jonAmountTextBox.Text + "," + jonAprComboBox.Text + "," + jon2CollectionComboBox.Text + "," + jon2PayableComboBox.Text + "," + jon2AmountTextBox.Text + "," + jon2AprComboBox.Text);
            }
        }
    }
}
