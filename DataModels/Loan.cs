﻿using System;
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
        public string AccrualMethod { get; set; }
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

        //public decimal EstimatedPayment { get; set; }
        //public decimal TotalInterestPaid { get; set; }
        //public decimal TotalPrinciplePaid { get; set; }
        //public decimal TotalAmountPaid { get; set; }
        //public decimal AprNoFeesIncluded { get; set; }
        //public decimal AprEffectingFee { get; set; }
        //public decimal TotalFinanceCharge { get; set; }
        //public decimal AprWithFees { get; set; }



        //Blank Constructor
        public Loan() { }

        //Constructor with parameters
        public Loan(int loanID, string loanDate, int initialRate, string repaymentMethod, int loanTerm, int amortizedTerm, decimal amountBorrowed, string accrualMethod, int paymentFrequency, string firstPaymentDate, string maturityDate, decimal paymentAmountOverride, string aprCollectionMethod, string jonCollectionMethod, string jon2CollectionMethod, string aprPayableBy,
            string jonPayableBy, string jon2PayableBy, decimal aprAmount, decimal jonAmount, decimal jon2Amount, string aprEffecting, string jonEffecting, string jon2Effecting)
        {
            LoanID = loanID;
            LoanDate = loanDate;
            InitialRate = initialRate;
            RepaymentMethod = repaymentMethod;
            LoanTerm = loanTerm;
            AmortizedTerm = amortizedTerm;
            AmountBorrowed = amountBorrowed;
            AccrualMethod = accrualMethod;
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
            

            //Method calls to set Amount Effecting Apr cells [I27 - I31]
            AprAmountEffectingApr = SetAprAmountEffectingApr(AprEffecting, AprAmount);
            JonAmountEffectingApr = SetJonAmountEffectingApr(JonEffecting, JonAmount);
            Jon2AmountEffectingApr = SetJon2AmountEffectingApr(Jon2Effecting, Jon2Amount);
            AmountEffectingAprTotal = SetAmountEffectingAprTotal(AprAmountEffectingApr, JonAmountEffectingApr, Jon2AmountEffectingApr);

            //Method calls to set Fee Collection Effecting Loan Amount cells [J27 - J31]
            AprEffectingLoanAmount = SetAprEffectingLoanAmount(AprCollectionMethod, AprAmount);
            JonEffectingLoanAmount = SetJonEffectingLoanAmount(JonCollectionMethod, JonAmount);
            Jon2EffectingLoanAmount = SetJon2EffectingLoanAmount(Jon2CollectionMethod, Jon2Amount);
            FeeCollectionEffectingLoanAmountTotal = SetFeeCollectionEffectingLoanAmountTotal(AprEffectingLoanAmount, JonEffectingLoanAmount, Jon2EffectingLoanAmount);


            //Method calls to set APR Fees Removed from Proceeds cells [K27 - K31]
            AprRemovedFromProceeds = SetAprRemovedFromProceeds(AprEffecting, AprEffectingLoanAmount);
            JonRemovedFromProceeds = SetJonRemovedFromProceeds(JonEffecting, JonEffectingLoanAmount);
            Jon2RemovedFromProceeds = SetJon2RemovedFromProceeds(Jon2Effecting, Jon2EffectingLoanAmount);
            AprFeeRemovedFromProceedsTotal = SetAprFeeRemovedFromProceedsTotal(AprRemovedFromProceeds, JonRemovedFromProceeds, Jon2RemovedFromProceeds);

            //Method calls to set calculated attributes at top of spreadsheet 
            TotalFinancedWithFees = SetTotalFinancedWithFees(AprFeeRemovedFromProceedsTotal, AmountBorrowed);

        }




        //Class methods for calculations
        //Logic below works, constructor calls method to set variable. Need to build out correct logic for this. 
        public static decimal SetTotalFinancedWithFees(decimal aprFeeRemovedFromProceedsTotal, decimal amountBorrowed)
        {
            return amountBorrowed + aprFeeRemovedFromProceedsTotal;

        }








        //Methods to calculate Amount Effecting Apr Fee cells[I27 - I31]
        public static decimal SetAprAmountEffectingApr(string aprEffecting, decimal aprAmount)
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
        public static decimal SetJonAmountEffectingApr(string jonEffecting, decimal jonAmount)
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
        public static decimal SetJon2AmountEffectingApr(string jon2Effecting, decimal jon2Amount)
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
        public static decimal SetAmountEffectingAprTotal(decimal aprAmountEffectingApr, decimal jonAmountEffectingApr, decimal jon2AmountEffectingApr)
        {
            return aprAmountEffectingApr + jonAmountEffectingApr + jon2AmountEffectingApr;
        }


        //Methods to calculate Fee Collection Effecting Loan Amounts cells[J27 - J31]
        //Double check the negative amount calculation in this function
        public static decimal SetAprEffectingLoanAmount(string aprCollectionMethod, decimal aprAmount)
        {
            if (aprCollectionMethod == "Added to Amount Financed")
            {
                return aprAmount;
            }
            else if (aprCollectionMethod == "Subtracted from Amount Financed")
            {
                return aprAmount * -1.00m;
            }
            else
            {
                return 0.00m;
            }
        }
        public static decimal SetJonEffectingLoanAmount(string jonCollectionMethod, decimal jonAmount)
        {
            if (jonCollectionMethod == "Added to Amount Financed")
            {
                return jonAmount;
            }
            else if (jonCollectionMethod == "Subtracted from Amount Financed")
            {
                return jonAmount * -1.00m;
            }
            else
            {
                return 0.00m;
            }
        }
        public static decimal SetJon2EffectingLoanAmount(string jon2CollectionMethod, decimal jon2Amount)
        {
            if (jon2CollectionMethod == "Added to Amount Financed")
            {
                return jon2Amount;
            }
            else if (jon2CollectionMethod == "Subtracted from Amount Financed")
            {
                return jon2Amount * -1.00m;
            }
            else
            {
                return 0.00m;
            }
        }
        public static decimal SetFeeCollectionEffectingLoanAmountTotal(decimal aprEffectingLoanAmount, decimal jonEffectingLoanAmount, decimal jon2EffectingLoanAmount)
        {
            return aprEffectingLoanAmount + jonEffectingLoanAmount + jon2EffectingLoanAmount;
        }



        //Methods to calculate APR Fee Removed From Proceeds Amounts cells[K27 - K31]
        public static decimal SetAprRemovedFromProceeds(string aprEffecting, decimal aprEffectingLoanAmount)
        {
            if (aprEffecting == "Yes")
            {
                return 0.00m;
            }
            else
            {
                return aprEffectingLoanAmount;
            }
        }
        public static decimal SetJonRemovedFromProceeds(string jonEffecting, decimal jonEffectingLoanAmount)
        {
            if (jonEffecting == "Yes")
            {
                return 0.00m;
            }
            else
            {
                return jonEffectingLoanAmount;
            }
        }
        public static decimal SetJon2RemovedFromProceeds(string jon2Effecting, decimal jon2EffectingLoanAmount)
        {
            if (jon2Effecting == "Yes")
            {
                return 0.00m;
            }
            else
            {
                return jon2EffectingLoanAmount;
            }
        }
        public static decimal SetAprFeeRemovedFromProceedsTotal(decimal aprRemovedFromProceeds, decimal jonRemovedFromProceeds, decimal jon2RemovedFromProceeds)
        {
            return aprRemovedFromProceeds + jonRemovedFromProceeds + jon2RemovedFromProceeds;
        }




    }
}
