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
            HashSet<Budget> budgets = new HashSet<Budget>();
            Item item1 = new("1", 1, 1);
            BudgetActivity buda1 = new("1", "", 3, BudgetActivityType.Expense);
            buda1.AddItem(item1);
            Budget bud1 = new("1", 5);
            bud1.AddActivity(buda1);
            budgets.Add(bud1);
            Application.Run(new AppPanel_Form(budgets));
            //Application.Run(new AppPanel_SampleForm());
        }
    }
}