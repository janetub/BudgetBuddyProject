using BudgetBuddyProject;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_Financial_Assisstance
{
    public class Budget
    {
        /*
         * This object will hold financial activities planned or done by user
         */

        /// <summary>
        /// A brief descriptive name for budget
        /// </summary>
        [JsonRequired]
        private string name;

        /// <summary>
        /// Amount of budget
        /// </summary>
        [JsonRequired]
        private double amount;

        /// <summary>
        /// Financial activities that can affect the balance of the budget.
        /// A colltection of actions or events that has a financial impact or consequence.
        /// </summary>
        [JsonRequired]
        private HashSet<BudgetActivity> activities = new HashSet<BudgetActivity>();

        /// <summary>
        /// Public accesor of private firld name activities.
        /// </summary>
        [JsonIgnore]
        public HashSet<BudgetActivity> Activities
        { get { return activities; } }

        /// <summary>
        /// Public accesor and mutator of private field name.
        /// Descriptive name of the activity.
        /// </summary>
        [JsonIgnore]
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        /// <summary>
        /// Public accesor and mutator of private field amount.
        /// </summary>
        [JsonIgnore]
        public double Amount
        {
            get => this.amount;
        }

        /// <summary>
        /// constructor for budget class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        public Budget(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
            this.activities = Activities;
        }

        /// <summary>
        /// Adds an object of type BudgetActivity.
        /// Adds the activity if allocation of the certain amount is possible/ projected of the activity can be funded.
        /// Once confirmed that projected does not exceed amount, it will proceed to deduct allocated or projected amount from the budget.
        /// Savings activity wont deduct from budget funds.
        /// </summary>
        /// <param name="activity">activity to be added</param>
        /// <returns>confirmation of the addition of activity to activities</returns>
        public bool AddActivity(BudgetActivity activity)
        {
            if(activity.ActivityType == BudgetActivityType.Expense)
            {
                if (this.amount < activity.Projected)
                    return false;
                this.activities.Add(activity);
                this.amount -= activity.Projected;
                return true;
            }
            this.activities.Add(activity);
            return true;
        }

        /// <summary>
        /// Removes the instance of the activity from the activities.
        /// Allow removal if projected is greater than actual total cost of the activity or if there is no remaining balance in the activity.
        /// </summary>
        /// <param name="activity">the activity to be removed</param>
        /// <param name="records">Holder/recorder for expenses and savings.</param>
        /// <returns>returns confirmation if an intance of activity is in activities</returns>
        public bool RemoveActivity(BudgetActivity activity)
        {
            ReadOnlyCollection<BudgetActivity> activitiesList = (ReadOnlyCollection<BudgetActivity>)activity.GetSubActivities();
            foreach (BudgetActivity act in activitiesList)
            {
                if (act.Projected > activity.Actual)
                    return false;
            }
            if (activity.Projected > activity.Actual)
                return false;
            this.activities.Remove(activity);
            //records.AddActivity(activity)
            return !this.activities.Contains(activity);
        }

        /// <summary>
        /// Transfers or moves the remaining unused money to back to budget.
        /// </summary>
        /// <param name="activity">activity with having a positive difference between projected and actual</param>
        /// <returns>Confimation for transfer</returns>
        public bool TransferBalanceToBudget(BudgetActivity activity)
        {
            if (activity.Projected <= activity.Actual)
                return false;
            double balance = activity.Projected - activity.Actual;
            this.amount += balance;
            Item transfer = new("Transfer Balance To Budget", balance, 1);
            activity.AddItem(transfer);
            return true;
        }

        /// <summary>
        /// Adds an amount to budget's amount or available funds
        /// </summary>
        /// <param name="amount">amount to add</param>
        public void AddBudgetAmount(double amount)
        {
            this.amount += amount;
        }

        /// <summary>
        /// Removed an amount to budget's amount or available funds
        /// </summary>
        /// <param name="amount">amount to add</param>
        public void RemoveBudgetAmount(double amount)
        {
            this.amount -= amount;
        }

        /*
         * The following methods sort the activities in different orders using OrderBy extension method from LINQ, and then creates a new List of BudgetActivity objects using ToList() extension method, and finally returns a read-only collection of BudgetActivity objects using AsReadOnly() method.
         * 
         * The IReadOnlyCollection interface allows read-only access to a collection. By returning a read-only collection, the caller cannot modify the collection directly.
         */

        public IReadOnlyCollection<BudgetActivity> GetActivities()
        {
            return this.activities.ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetActivitiesSortedByNameAscending()
        {
            return this.activities.OrderBy(a => a.Name).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetActivitiesSortedByNameDescending()
        {
            return this.activities.OrderByDescending(a => a.Name).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetActivitiesSortedByCostAscending()
        {
            return this.activities.OrderBy(a => a.Actual).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetActivitiesSortedByCostDescending()
        {
            return this.activities.OrderByDescending(a => a.Actual).ToList().AsReadOnly();
        }

        public override string ToString()
        {
            string result = this.name + "(" + this.Amount + ")\n";

            foreach(BudgetActivity budgetActivity in this.Activities) 
            {
                result += "+" + budgetActivity + "\n";
            }

            return result;
        }
    }
}
