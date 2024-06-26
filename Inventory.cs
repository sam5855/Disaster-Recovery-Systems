﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Disaster_Recovery_Solution
{

    //Inventory class to track Loans
    internal class Inventory
    {
        public static BindingList<Loan> AllLoans = new BindingList<Loan>();



        //Inventory Methods
        
        //Add Loans to binding list
        public static void AddLoan(Loan newLoan)
        {
            AllLoans.Add(newLoan);
        }

        //Remove Loan from binding list
        public static bool RemoveLoan(int loanID)
        {
            bool success = false;

            foreach (Loan currentLoan in AllLoans)
            {
                if (loanID == currentLoan.LoanID)
                {
                    AllLoans.Remove(currentLoan);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Could not delete Loan");
                    return success = false;
                }
            }
            return success;
        }

        


    }
}
