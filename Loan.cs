using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Disaster_Recovery_Solution
{
    internal class Loan
    {
        public int LoanID { get; set; }
        public string LoanDate { get; set; }
        public int InitialRate { get; set; }
        public string RepaymentMethod { get; set; }
        public int LoanTerm { get; set; }
        public int AmortizedTerm { get; set;}
        public decimal AmountBorrowed { get; set; }
        public int PaymentFrequency { get; set; }
        public string FirstPaymentDate { get; set; }
        public string MaturityDate { get; set; }
        public decimal PaymentAmountOverride { get; set; }

        
        //Testing first calculation
        public decimal TotalFinancedWithFees { get; set; }
        


        //Blank Constructor
        public Loan() { }

        //Constructor with parameters
        public Loan(int loanID, string loanDate, int initialRate, string repaymentMethod, int loanTerm, int amortizedTerm, decimal amountBorrowed, int paymentFrequency, string firstPaymentDate, string maturityDate, decimal paymentAmountOverride)
        {
            LoanID = loanID;
            LoanDate = loanDate;
            InitialRate = initialRate;
            RepaymentMethod = repaymentMethod;
            LoanTerm = loanTerm;
            AmortizedTerm = amortizedTerm;
            AmountBorrowed = amountBorrowed;
            PaymentFrequency = paymentFrequency;
            FirstPaymentDate = firstPaymentDate;
            MaturityDate = maturityDate;
            PaymentAmountOverride = paymentAmountOverride;
        }




        //Class methods for calculations
        public static decimal setTotalFinanced(string repaymentMethod)
        {
            
            if (repaymentMethod == "Balloon")
            {
                TotalFinancedWithFees = this.amountBorrowed + 
            }
        }
    }
}
