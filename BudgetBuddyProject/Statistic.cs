using Student_Financial_Assisstance;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddyProject
{
    public class Statistic
    {
        /// <summary>
        /// Amount of Budget Left, either in Budget or in Activity(will be converted to percent)
        /// </summary>
        public double percentMoneyLeft { get; private set; }

        /// <summary>
        /// Amount of Money Used. either in Budget or in Activity(will be converted to percent)
        /// </summary>
        public double percentMoneyUsed { get; private set; }

        /// <summary>
        /// Total spent in Budget
        /// </summary>
        public double totalSPent { get; private set; }

        /// <summary>
        /// Spent Money daily in Budget
        /// </summary>
        public double dailySpent { get; set; }

        /// <summary>
        /// Spent Money Weekly in Budget
        /// </summary>
        public double weeklySpent { get; set; }

        /// <summary>
        /// Spent Money Monthly in Budget
        /// </summary>
        public double monthlySpent { get; set; }

        /// <summary>
        /// Spent Money Daily in Activity
        /// </summary>
        public double dailySpentActivity { get; private set; }

        /// <summary>
        /// Spent Money Weekly in Activity
        /// </summary>
        public double weeklySpentActivity { get; private set; }

        /// <summary>
        /// Spent Money Montly in Activity
        /// </summary>
        public double monthlySpentActivity { get; private set; }

        /// <summary>
        /// Gets the Date Today.
        /// </summary>
        public DateTime DateToday { get; private set; }

        /// <summary>
        /// Constructor for Statistic Class
        /// </summary>
        public Statistic() //* initialize attributes to zero
        {
            this.percentMoneyLeft = 0;
            this.percentMoneyUsed = 0;
            this.DateToday = DateTime.Now;
        }

        /// <summary>
        /// Tracking the money being used using the Amount in Budget.
        /// Tracking the money left also.
        /// Example: in weekly, it tracks the amount being used from 7 days ago till now.
        /// Money spent daily, weekly, monthly.
        /// </summary>
        /// <param name="budget"></param>
        public void computeMoneyUsed(Budget budget)
        {
            ReadOnlyCollection<BudgetActivity> activitiesList = (ReadOnlyCollection<BudgetActivity>)budget.GetActivities();
            // Calculate Daily Spent Using the Amount in Budget
            foreach (BudgetActivity activity in activitiesList)
            {
                if(activity.ActivityType == BudgetActivityType.Expense)
                {
                    int day = this.DateToday.Day;
                    int dayAct = activity.DateAdded.Day;
                    int difference = day - dayAct;

                    if (difference <= 1)
                    {
                        dailySpent += activity.Actual;
                    }
                }
                
            }

            // Calculate Weekly Spent Using the Amount in Budget
            foreach (BudgetActivity activity in activitiesList)
            {
                if (activity.ActivityType == BudgetActivityType.Expense)
                {
                    int day = this.DateToday.Day;
                    int dayAct = activity.DateAdded.Day;
                    int difference = day - dayAct; ;

                    if (difference <= 7)
                    {
                        weeklySpent += activity.Actual;
                    }
                }
            }

            // Calculate Monthly Spent Using the Amount in Budget
            foreach (BudgetActivity activity in activitiesList)
            {
                if (activity.ActivityType == BudgetActivityType.Expense)
                {
                    int day = this.DateToday.Day;
                    int dayAct = activity.DateAdded.Day;
                    int difference = day - dayAct;

                    if (difference <= 30)
                    {
                        monthlySpent += activity.Actual;
                    }
                }
            }
            //This is just to get the total projected of the activities added in Budget
            double totalProjected = 0;
            foreach (BudgetActivity activity in activitiesList)
            {
                if (activity.ActivityType == BudgetActivityType.Expense)
                {
                    totalProjected += activity.Projected;
                } 
            }
            // line 78 - 80 gets the percentage of money used and left in the Amount of Budget
            double temp = budget.Amount + totalProjected - weeklySpent;
            percentMoneyUsed = (weeklySpent / (budget.Amount + totalProjected)) * 100; //* budget.Amount is the current funds and the spent amount is already deducted from the funds. Must add all the projected first
            percentMoneyLeft = (temp / (budget.Amount + totalProjected)) * 100;

            Console.WriteLine("Daily Spent on " + budget.Name + "'s Budget: " + dailySpent);
            Console.WriteLine("Weekly Spent on " + budget.Name + "'s Budget: " + weeklySpent);
            Console.WriteLine("Monthly Spent on " + budget.Name + "'s Budget: " + monthlySpent);
            Console.WriteLine("Weekly Money Used on " + budget.Name + "'s Budget: " + percentMoneyUsed + "%");
            Console.WriteLine("Weekly Money Left on " + budget.Name + "'s Budget: " + percentMoneyLeft + "%\n");
        }

        /// <summary>
        /// Tracking the money being used inside the Projected amount of the Activity
        /// By adding an activity, you can then track how much money left you can use in this activity
        /// Money spent daily, weekly, monthly
        /// </summary>
        /// <param name="budgetActivity"></param>

        public void calculateActivitySpent(Budget budget) //* budgetActivities contain subActivities
        {
            ReadOnlyCollection<BudgetActivity> activities = (ReadOnlyCollection<BudgetActivity>)budget.GetActivities();
            //daily
            foreach (BudgetActivity activity in activities)
            {
                dailySpentActivity = 0;
                ReadOnlyCollection<Item> activityItemList = activity.GetAllItems();
                foreach (Item item in activityItemList)
                {
                    int day = this.DateToday.Day;
                    int dayAct = item.DateBought.Day;
                    int difference = day - dayAct;

                    if (difference <= 1)
                    {
                        dailySpentActivity += (item.Cost * item.Quantity);
                    }
                }
                Console.WriteLine("Daily Spent on " + activity.Name + "'s Activity: " + dailySpentActivity);
            }

            //weekly
            foreach (BudgetActivity activity in activities)
            {
                weeklySpentActivity = 0;
                ReadOnlyCollection<Item> activityItemList = activity.GetAllItems();
                foreach (Item item in activityItemList)
                {
                    int day = this.DateToday.Day;
                    int dayAct = item.DateBought.Day;
                    int difference = day - dayAct;

                    if (difference <= 7)
                    {
                        weeklySpentActivity += (item.Cost * item.Quantity);
                    }
                }
                Console.WriteLine("Weekly Spent on " + activity.Name + "'s Activity: " + weeklySpentActivity);
                Console.WriteLine("Weekly Money Spent on " + activity.Name + "'s Activity: " + percentMoneyUsed + "%");
                Console.WriteLine("Weekly Money Left on " + activity.Name + "'s Activity: " + percentMoneyLeft + "%");
            }

            //monthly
            foreach (BudgetActivity activity in activities)
            {
                monthlySpentActivity = 0;
                ReadOnlyCollection<Item> activityItemList = activity.GetAllItems();
                foreach (Item item in activityItemList)
                {
                    int day = this.DateToday.Day;
                    int dayAct = item.DateBought.Day;
                    int difference = day - dayAct;

                    if (difference <= 30)
                    {
                        monthlySpentActivity += (item.Cost * item.Quantity);
                    }
                }
                Console.WriteLine("Monthly Spent on " + activity.Name + "'s Activity: " + monthlySpentActivity);
            }
            foreach (BudgetActivity activity in activities)
            {
                double temp = activity.Projected - weeklySpentActivity;
                percentMoneyUsed = (weeklySpentActivity / activity.Projected) * 100;
                percentMoneyLeft = (temp / activity.Projected) * 100;
            }

        }

    }
}