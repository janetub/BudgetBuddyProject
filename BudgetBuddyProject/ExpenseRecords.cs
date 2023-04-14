using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Financial_Assisstance
{
    public class ExpenseRecords
    {
        /*
         * Will hold lists of expenses aka the activities that has been done.
         * History.
         */

        /// <summary>
        /// List of activities. List is used to allow duplication
        /// </summary>
        private List<BudgetActivity> activities;

        /// <summary>
        /// constructor for ExpenseRecords class.
        /// </summary>
        public ExpenseRecords()
        {
            this.activities = new List<BudgetActivity>();
        }

        public void AddActivity(BudgetActivity activity)
        {
            this.activities.Add(activity);
        }

        public void RemoveActivity(BudgetActivity activity)
        {
            this.activities.Remove(activity);
        }

        public IReadOnlyList<string> Activities()
        {
            return (IReadOnlyList<string>)this.activities.ToList().AsReadOnly();
        }
        public IReadOnlyCollection<BudgetActivity> GetExpenseRecords()
        {
            return this.activities.ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetExpenseRecordsReversed()
        {
            return this.activities.AsEnumerable().Reverse().ToList().AsReadOnly();
        }
    }
}
