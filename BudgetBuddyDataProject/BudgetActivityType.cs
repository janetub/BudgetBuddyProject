using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddyProject
{
    public enum BudgetActivityType
    // Added validation for Budget if projected of activity will be deducted from budget funds.
    {
        /// <summary>
        /// An expense activity will deduct funds from budget amount.
        /// </summary>
        Expense,

        /// <summary>
        /// A savings activity will not deduct funds from budget.
        /// </summary>
        Savings
    }
}
