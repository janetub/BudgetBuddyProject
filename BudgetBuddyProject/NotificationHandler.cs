 using Student_Financial_Assisstance;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddyProject
{
    public class NotificationHandler
    {
        private HashSet<string> notifications = new HashSet<string>();

        public bool isNotifiable(DateTime deadline)
        {
            if (deadline <= DateTime.Now.AddDays(1))
                return true;

            return false;
        }

        public void getNotifications(Budget budget)
        {
            ReadOnlyCollection<BudgetActivity> activities = (ReadOnlyCollection<BudgetActivity>)budget.GetActivities();
            foreach (BudgetActivity activity in activities)
            {
                if (this.isNotifiable(activity.DeadLine))
                {
                    string notification = "Hello, just a friendly reminder that the deadline for " + activity.Name + " is now less than a day. Don't forget to check it out!";
                   this.notifications.Add(notification);
                }
            }
        }

        public IReadOnlyCollection<String> GetNotifications()
        {
            return this.notifications.ToList().AsReadOnly();
        }
    }
}
