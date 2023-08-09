using BudgetBuddyProject;
using System;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Financial_Assisstance
{
    public class BudgetActivity
    {
        /*
         * A financial Activity.
         */

        /// <summary>
        /// Descriptive name of the activity
        /// </summary>
        [JsonRequired]
        private string name;

        /// <summary>
        /// Additional information about the activity
        /// </summary>
        [JsonRequired]
        private string description;

        /// <summary>
        /// projected cost of the activity
        /// </summary>
        [JsonRequired]
        private double projected;

        /// <summary>
        /// actual cost of the activity
        /// </summary>
        [JsonRequired]
        private double actual;

        /// <summary>
        /// Determines if the object BudgetActivity is Active or not.
        /// Inactive activities are kept in the archive.
        /// </summary>
        [JsonRequired]
        private bool isActive;

        /// <summary>
        /// Can be eithern an expense type activity which deducts budget funds or a savings activity.
        /// </summary>
        [JsonRequired]
        private BudgetActivityType activityType;

        /// <summary>
        /// Public accesor and mutator of private field name.
        /// Descriptive name of the activity.
        /// </summary>
        [JsonIgnore]
        public string Name
        {
            get => name;
            set => this.name = value;
        }

        /// <summary>
        /// Public accesor and mutator of private field description.
        /// Additional information about the activity
        /// </summary>
        [JsonIgnore]
        public string Description
        {
            get => description;
            set => this.description = value;
        }

        /// <summary>
        /// Public accesor of private field projected.
        /// Projected or expected amount that the activity may cost.
        /// Allocated amount.
        /// </summary>
        [JsonIgnore]
        public double Projected
        {
            get => this.projected;
        }

        /// <summary>
        /// Public accesor of private field actual.
        /// Actual or total amount that the activity cost.
        /// </summary>
        [JsonIgnore]
        public double Actual
        {
            get
            {
                this.computeActual();
                return this.actual;
            }
        }

        /// <summary>
        /// Public accesor and mutator of private field isActive.
        /// Determines if the activity is active or inactive, or being used or not.
        /// Inactive activities are kept in archive
        /// </summary>
        [JsonIgnore]
        public bool IsActive
        {
            get => this.isActive;
            set => this.isActive = value;
        }

        /// <summary>
        /// Public accessor of private field activityType.
        /// Either an expense type which deducts funds from budget or a savings type which do not.
        /// </summary>
        [JsonIgnore]
        public BudgetActivityType ActivityType
        {
            get => this.activityType;
        }

        /// <summary>
        /// A collection of items.
        /// Items with cost, constributing to the BudgetActivity's amount.
        /// </summary>
        [JsonRequired]
        private HashSet<Item> items = new HashSet<Item>();

        /// <summary>
        /// BudgetActivity within BudgetActivity.
        /// Collection of sub activities of BudgetActivity type.
        /// Allow nested activities.
        /// </summary>
        [JsonRequired]
        private HashSet<BudgetActivity> subActivities = new HashSet<BudgetActivity>();

        /// <summary>
        /// Public accesor for public field named items.
        /// </summary>
        [JsonIgnore]
        public HashSet<Item> Items
        {
            get { return items; }
        }

        /// <summary>
        /// Public accesor for private field named subActivities.
        /// </summary>
        [JsonIgnore]
        public HashSet<BudgetActivity> SubActivities
        {
            get { return subActivities; }
        }

        /// <summary>
        /// The Date to when the activity was added.
        /// </summary>
        [JsonRequired]
        public DateTime DateAdded { get; private set; }

        /// <summary>
        /// The Date to When the activity will end.
        /// </summary>
        public DateTime DeadLine { get; set; }

        /// <summary>
        /// Constructor for class Activity
        /// </summary>
        /// <param name="name">name of activity</param>
        /// <param name="description">additional info</param>
        public BudgetActivity(string name, string description, double projected, BudgetActivityType type)
        {
            this.name = name;
            this.description = description;
            this.projected = projected;
            this.actual = 0;
            this.items = Items;
            this.subActivities = SubActivities;
            this.isActive = true;
            this.DateAdded = DateTime.Now;
            this.activityType = type;
            //this.DeadLine = DeadLine;
        }


        /// <summary>
        /// Add an item to the collection of items.
        /// If the available amount is less than the cost of the item, it wont proceed addition, otherwise, it will be deducting its cost from the actual of the activity.
        /// </summary>
        /// <param name="item">item to be added from the collection</param>
        /// <returns>Confirmation of the addition of item</returns>
        public bool AddItem(Item item)
        {
            if((this.projected - this.GetSummedProjectedsItems()) < (item.Cost * item.Quantity))
            {
                return false;
            }
            this.items.Add(item);
            this.computeActual();
            return this.items.Contains(item);
        }

        /// <summary>
        /// Remove an item from the collection.
        /// Adding its cost to the actual amount.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool RemoveItem(Item itemToRemove)
        {
            this.items.Remove(itemToRemove);
            this.computeActual();
            return !this.items.Contains(itemToRemove);
        }

        /// <summary>
        /// Activities cannot have savings-type subactivities.
        /// Adds the subactivity if the available balance including the projected is not less than the cost of the subactivity.
        /// </summary>
        /// <param name="subActivity">subActivity of type-BudgetActivity to be added.</param>
        /// <returns>Confirmation for the addition.</returns>
        public bool AddSubActivity(BudgetActivity subActivity)
        {
            if (this.activityType == BudgetActivityType.Savings || subActivity.ActivityType == BudgetActivityType.Savings)
                return false; //** only items can be added to savings type activities and savings can only be added within budget, not within an activity
            if ((this.projected - this.GetSummedProjectedsItems()) < subActivity.Projected) //** since the actual is changed to actual values of the subActivities and items it contained, to determine if our activity can still fund another activity, we must include the projections of the activities it contained
                return false;
            this.subActivities.Add(subActivity);
            this.computeActual();
            return this.subActivities.Contains(subActivity);
        }

        /// <summary>
        /// Removes the instance of subActivity from the subActivities.
        /// Will not proceed if actual is greater than zero or if any of the involved activity is a savings type.
        /// </summary>
        /// <param name="subActivity">subActivity of type-BudgetActivity to be removed.</param>
        /// <returns>boolean confirmaiton of removal</returns>
        public bool RemoveSubActivity(BudgetActivity subActivity)
        {
            if (this.activityType == BudgetActivityType.Savings || subActivity.ActivityType == BudgetActivityType.Savings || subActivity.Actual > 0)
                return false;
                //** only items can be added to savings type activities and savings can only be added within budget, not within an activity
               //** not allow removal once the subActivity has an actual because once the subactivity is removed, the computeActual would return the actual without the subActivity ever existing. It is also unrealistic to remove the subActivity because there is no other way of knowing where the money spent went and the actual will return to previous amount.
            this.subActivities.Remove(subActivity);
            this.computeActual();
            return !this.subActivities.Contains(subActivity);
        }

        /// <summary>
        /// Transfers the amount to a savings activity.
        /// </summary>
        /// <param name="amount">amount to transfer</param>
        /// <param name="activity">destination activity</param>
        /// <returns></returns>
        public bool TransferAmountToSavings(double amount, BudgetActivity activity)
        {
            // should be Savings type, funds to move can be supported, and destination funds will not exceed projected if added
            if (activity.ActivityType != BudgetActivityType.Savings || (this.Projected - this.GetSummedProjectedsItems()) < amount || (activity.Projected - activity.Actual) < amount)  
                return false;
            Item savings = new Item($"Saved amount {amount} for {activity.name}", amount, 1);
            this.AddItem(savings);
            activity.AddItem(savings);
            return true;
        }

        /// <summary>
        /// Helper function.
        /// Computes the actual cost of all contained items and activities.
        /// Useful to keep track of nested activities during numerous additions and removals of items and activities.
        /// </summary>
        private void computeActual()
        {
            this.actual = this.items.Sum(item => (item.Cost * item.Quantity)) + this.subActivities.Sum(subActivities => subActivities.actual); //** changed to actual so that the actual for this item will be the sum of actual of its subactivities and items
        }

        /// <summary>
        /// Computes the sum of all of the items' total cost and the sub-activities projected amount.
        /// </summary>
        /// <returns>returns the double amount of the summed up items cost*quantity and projected from sub-activities</returns>
        public double GetSummedProjectedsItems()
        {
            return this.items.Sum(item => (item.Cost * item.Quantity)) + this.subActivities.Sum(subActivities => subActivities.projected);
        }

        /// <summary>
        /// Gets all the Items from the mainActivity and its subActivity
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            // Add items in this activity
            items.AddRange(this.GetItems());
 
            foreach (BudgetActivity subActivity in this.subActivities)
            {
                items.AddRange(subActivity.GetAllItems());
            }
            return items.AsReadOnly();
        }

        public void SetDeadLine(DateTime date)
        {
            this.DeadLine = date;
        }

        /* 
         * The following methods sort the items in different orders using OrderBy extension method from LINQ, and then creates a new List of items objects using ToList() extension method, and finally returns a read-only collection of item objects using AsReadOnly() method.
         * 
         * The IReadOnlyCollection interface allows read-only access to a collection. By returning a read-only collection, the caller cannot modify the collection directly.
         */

        public IReadOnlyCollection<Item> GetItems()
        {
            return this.items.ToList().AsReadOnly();
        }

        public IReadOnlyCollection<Item> GetItemsSortedByNameAscending()
        {
            return this.items.OrderBy(a => a.Name).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<Item> GetItemsSortedByNameDescending()
        {
            return this.items.OrderByDescending(a => a.Name).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<Item> GetItemsSortedByCostAscending()
        {
            return this.items.OrderBy(a => a.Cost).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<Item> GetItemsSortedByCostDescending()
        {
            return this.items.OrderByDescending(a => a.Cost).ToList().AsReadOnly();
        }
        public IReadOnlyCollection<BudgetActivity> GetSubActivities()
        {
            return this.subActivities.ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetSubActivitiesSortedByNameAscending()
        {
            return this.subActivities.OrderBy(a => a.Name).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetSubActivitiesSortedByNameDescending()
        {
            return this.subActivities.OrderByDescending(a => a.Name).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetSubActivitiesSortedByCostAscending()
        {
            return this.subActivities.OrderBy(a => a.Actual).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<BudgetActivity> GetSubActivitiesSortedByCostDescending()
        {
            return this.subActivities.OrderByDescending(a => a.Actual).ToList().AsReadOnly();
        }

        public override string ToString()
        {
            string result = this.Name + "(" + this.Projected + ")\n";

            foreach (BudgetActivity subActivity in this.SubActivities)
            {
                result += "+" + subActivity + "\n";
            }
            foreach(Item item in this.Items)
            {
                result += "-" + item + "\n";
            }
            return result;
        }
    }
}
