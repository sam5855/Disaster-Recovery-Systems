using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaster_Recovery_Solution
{
    internal class Loan
    {
        public int loanID { get; set; }
        public string loanDate { get; set; }
        public int initialRate { get; set; }
        public string repaymentMethod { get; set; }
        public int loanTerm { get; set; }
        public int amortizedTerm { get; set;}
        public decimal amountBorrowed { get; set; }
        public int paymentFrequency { get; set; }
        public string firstPaymentDate { get; set; }
        public string maturityDate { get; set; }
        public decimal paymentAmountOverride { get; set; }


        //Blank Constructor
        public Loan() { }


        public Loan(int loanID, string loanDate, int initialRate, string repaymentMethod, int loanTerm, int amortizedTerm, decimal amountBorrowed, int paymentFrequency, string firstPaymentDate, string maturityDate, decimal paymentAmountOverride)
        {
            this.loanID = loanID;
            this.loanDate = loanDate;
            this.initialRate = initialRate;
            this.repaymentMethod = repaymentMethod;
            this.loanTerm = loanTerm;
            this.amortizedTerm = amortizedTerm;
            this.amountBorrowed = amountBorrowed;
            this.paymentFrequency = paymentFrequency;
            this.firstPaymentDate = firstPaymentDate;
            this.maturityDate = maturityDate;
            this.paymentAmountOverride = paymentAmountOverride;
        }
    }
}
