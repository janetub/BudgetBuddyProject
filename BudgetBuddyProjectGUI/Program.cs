using Student_Financial_Assisstance;
using BudgetBuddyProject;

namespace Budget_Buddy_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            HashSet<Budget> budgets = new();
            Item item1 = new("1", 1, 1);
            BudgetActivity buda1 = new("1", "", 3, BudgetActivityType.Expense);
            Budget bud1 = new("1", 5);
            budgets.Add(bud1);
            bud1.AddActivity(buda1);
            buda1.AddItem(item1);

            Item longItem = new("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.", 999999.99, 9999);
            BudgetActivity longActivity = new("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.", "long subact", 9999999999.99, BudgetActivityType.Expense);
            BudgetActivity longSubactivity = new("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.", "long act", 1000000.99, BudgetActivityType.Expense);
            Budget longBudget = new("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.", 999999999999.99);
            budgets.Add(longBudget);
            longBudget.AddActivity(longActivity);
            longActivity.AddItem(longItem);
            longActivity.AddSubActivity(longSubactivity);

            Budget wedding = new("Wedding", 500000);
            budgets.Add(wedding);
            BudgetActivity venueAndCatering = new("Venue and Catering", "Bethany catering services", 250000, BudgetActivityType.Expense);
            BudgetActivity venueRental = new("Venue rental", "Bethany", 100000, BudgetActivityType.Expense);
            BudgetActivity decor = new("Decorations", "Flower deco", 70000, BudgetActivityType.Expense);
            Item flowers = new("Flowers", 599, 7);
            Item deposit = new("Deposit", 20000, 1);
            wedding.AddActivity(venueAndCatering);
            venueAndCatering.AddSubActivity(venueRental);
            venueRental.AddItem(deposit);
            venueRental.AddSubActivity(decor);
            decor.AddItem(flowers);
            BudgetActivity foodAndBeverage = new("Food and Beverage", "steak for 99 people", 125000, BudgetActivityType.Expense);
            Item steak = new("steak", 899, 99);
            wedding.AddActivity(foodAndBeverage);
            foodAndBeverage.AddItem(steak);

            Application.Run(new AppPanel_Form(budgets));
            //Application.Run(new AppPanel_SampleForm());
        }
    }
}