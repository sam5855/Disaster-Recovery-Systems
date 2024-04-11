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

        //User input attributes
        public int LoanID { get; set; }
        public string LoanDate { get; set; }
        public int InitialRate { get; set; }
        public string RepaymentMethod { get; set; }
        public int LoanTerm { get; set; }
        public int AmortizedTerm { get; set; }
        public decimal AmountBorrowed { get; set; }
        public int PaymentFrequency { get; set; }
        public string FirstPaymentDate { get; set; }
        public string MaturityDate { get; set; }
        public decimal PaymentAmountOverride { get; set; }
        public string AprCollectionMethod { get; set; }
        public string JonCollectionMethod { get; set; }
        public string Jon2CollectionMethod { get; set; }
        public string AprPayableBy { get; set; }
        public string JonPayableBy { get; set; }
        public string Jon2PayableBy { get; set; }
        public decimal AprAmount { get; set; }
        public decimal JonAmount { get; set; }
        public decimal Jon2Amount { get; set; }
        public string AprEffecting { get; set; }
        public string JonEffecting { get; set; }
        public string Jon2Effecting { get; set; }





        //Calculated attributes

        //Amounts Effecting Apr 
        public decimal AprAmountEffectingApr { get; set; }
        public decimal JonAmountEffectingApr { get; set; }
        public decimal Jon2AmountEffectingApr { get; set; }
        public decimal AmountEffectingAprTotal { get; set; }

        //Fee Collection Effecting Loan Amount
        public decimal AprEffectingLoanAmount { get; set; }
        public decimal JonEffectingLoanAmount { get; set; }
        public decimal Jon2EffectingLoanAmount { get; set; }
        public decimal FeeCollectionEffectingLoanAmountTotal { get; set; }


        //Apr Fees Removed from Proceeds
        public decimal AprRemovedFromProceeds { get; set; }
        public decimal JonRemovedFromProceeds { get; set; }
        public decimal Jon2RemovedFromProceeds { get; set; }
        public decimal AprFeeRemovedFromProceedsTotal { get; set; }



        //Calculated attributes returned at top of spreadsheet
        public decimal TotalFinancedWithFees { get; set; }



        //Blank Constructor
        public Loan() { }

        //Constructor with parameters
        public Loan(int loanID, string loanDate, int initialRate, string repaymentMethod, int loanTerm, int amortizedTerm, decimal amountBorrowed, int paymentFrequency, string firstPaymentDate, string maturityDate, decimal paymentAmountOverride, string aprCollectionMethod, string jonCollectionMethod, string jon2CollectionMethod, string aprPayableBy,
            string jonPayableBy, string jon2PayableBy, decimal aprAmount, decimal jonAmount, decimal jon2Amount, string aprEffecting, string jonEffecting, string jon2Effecting)
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
            AprCollectionMethod = aprCollectionMethod;
            JonCollectionMethod = jonCollectionMethod;
            Jon2CollectionMethod = jon2CollectionMethod;
            AprPayableBy = aprPayableBy;
            JonPayableBy = jonPayableBy;
            Jon2PayableBy = jon2PayableBy;
            AprAmount = aprAmount;
            JonAmount = jonAmount;
            Jon2Amount = jon2Amount;
            AprEffecting = aprEffecting;
            JonEffecting = jonEffecting;
            Jon2Effecting = jon2Effecting;





            //Methods to calculate loan attributes 
            //TotalFinancedWithFees = setTotalFinanced(repaymentMethod, amountBorrowed);

            //Method calls to set Amount Effecting Apr cells [I27 - I31]
            AprAmountEffectingApr = setAprAmountEffectingApr(AprEffecting, AprAmount);
            JonAmountEffectingApr = setJonAmountEffectingApr(JonEffecting, JonAmount);
            Jon2AmountEffectingApr = setJon2AmountEffectingApr(Jon2Effecting, Jon2Amount);
            AmountEffectingAprTotal = setAmountEffectingAprTotal(AprAmountEffectingApr, JonAmountEffectingApr, Jon2AmountEffectingApr);

            //Method calls to set Amount Effecting Apr cells [J27 - J31]
            //Testing pushing from pc

            //Method calls to set Amount Effecting Apr cells [K27 - K31]


        }




        //Class methods for calculations
        //Logic below works, constructor calls method to set variable. Need to build out correct logic for this. 
        public static decimal setTotalFinanced(string repaymentMethod, decimal amountBorrowed)
        {
            if (repaymentMethod == "Term Loan (P&I)")
            {
                return 6.69m;
            }
            else
            {
                return 2.32m;
            }

        }


        //Methods to calculate Amount Effecting Apr Fee cells[I27 - I31]
        public static decimal setAprAmountEffectingApr(string aprEffecting, decimal aprAmount)
        {
            if (aprEffecting == "Yes")
            {
                return aprAmount;
            }
            else
            {
                return 0.00m;
            }
        }
        public static decimal setJonAmountEffectingApr(string jonEffecting, decimal jonAmount)
        {
            if (jonEffecting == "Yes")
            {
                return jonAmount;
            }
            else
            {
                return 0.00m;
            }
        }
        public static decimal setJon2AmountEffectingApr(string jon2Effecting, decimal jon2Amount)
        {
            if (jon2Effecting == "Yes")
            {
                return jon2Amount;
            }
            else
            {
                return 0.00m;
            }
        }
        public static decimal setAmountEffectingAprTotal(decimal aprAmountEffectingApr, decimal jonAmountEffectingApr, decimal jon2AmountEffectingApr)
        {
            return aprAmountEffectingApr + jonAmountEffectingApr + jon2AmountEffectingApr;
        }











    }
}
