using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        public static void RemoveLoan(int loanID)
        {

        }

    }
}
