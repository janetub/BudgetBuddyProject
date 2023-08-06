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
         * An object that keeps inactive BudgetActivities.
         */

        /// <summary>
        /// List of inactive/archived activities.
        /// </summary>
        private HashSet<BudgetActivity> activities;

        /// <summary>
        /// Constructor for Archive class.
        /// </summary>
        public Archive()
        {
            this.activities = new HashSet<BudgetActivity>();
        }

        /// <summary>
        /// Add an activity.
        /// </summary>
        /// <param name="activity"></param>
        public void AddActivity(BudgetActivity activity)
        {
            activity.IsActive = false;
            this.activities.Add(activity);
        }

        /// <summary>
        /// Remove an activity
        /// </summary>
        /// <param name="activity"></param>
        /// <returns>The removed activity.</returns>
        public BudgetActivity RemoveActivity(BudgetActivity activity)
        {
            activity.IsActive = true;
            this.activities.Remove(activity);
            return activity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A read-only collection of the archives.</returns>
        public IReadOnlyCollection<BudgetActivity> GetArchives()
        {
            return this.activities.ToList().AsReadOnly();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Read-only collection of the archives in reverse order.</returns>
        public IReadOnlyCollection<BudgetActivity> GetArchivesReversed()
        {
            return this.activities.AsEnumerable().Reverse().ToList().AsReadOnly();
        }
    }
}
