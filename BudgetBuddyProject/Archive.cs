using Student_Financial_Assisstance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Financial_Assisstance
{
    public class Archive
    {
        /*
         * an object that keeps inactive BudgetActivities.
         */

        /// <summary>
        /// List of activities.
        /// </summary>
        private HashSet<BudgetActivity> activities;

        /// <summary>
        /// constructor for ExpenseRecords class.
        /// </summary>
        public Archive()
        {
            this.activities = new HashSet<BudgetActivity>();
        }

        public void AddActivity(BudgetActivity activity)
        {
            activity.IsActive = false;
            this.activities.Add(activity);
        }

        public void RemoveActivity(BudgetActivity activity)
        {
            activity.IsActive = true;
            this.activities.Remove(activity);
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
