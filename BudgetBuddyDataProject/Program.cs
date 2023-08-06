using Student_Financial_Assisstance;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Security.AccessControl;

namespace BudgetBuddyProject;
internal class Program
{
    private static void Main(string[] args)
    {
        /*Budget budget1 = new Budget("jake", 1000);
        BudgetActivity a1 = new BudgetActivity("travel", "desc", 500, BudgetActivityType.Expense);
        budget1.AddActivity(a1);
        BudgetActivity a2 = new BudgetActivity("Movie", "desc", 200, BudgetActivityType.Expense);
        budget1.AddActivity(a2);
        a2.AddItem(new Item("ticket", 100, 2));
        a1.AddItem(new Item("fare", 100, 1));
        BudgetActivity a11 = new BudgetActivity("eat", "desc", 250, BudgetActivityType.Expense);
        a1.AddSubActivity(a11);
        a11.AddItem(new Item("fish", 50, 2));
        a11.AddItem(new Item("rice", 10, 3));

        Budget budget2 = new Budget("judy", 2000);
        BudgetActivity b1 = new BudgetActivity("Grocery", "desc", 1000, BudgetActivityType.Expense);
        budget2.AddActivity(b1);
        b1.AddItem(new Item("Sardines", 25.5, 1));
        b1.AddItem(new Item("Biscuit", 50.21, 2));
        b1.AddItem(new Item("Shampoo", 7.89, 12));

        DataBase.Budgets.Add(budget1);
        DataBase.Budgets.Add(budget2);
        DataBase.SaveBudget();*/

        /*DataBase.LoadBudget();
        Item item = new Item("swimSuit", 20, 1);
        DataBase.addItem(item, "jake", "Swimming");
        DataBase.SaveBudget();*/

        Statistic stat = new Statistic();
        DataBase.LoadBudget();
        foreach(Budget b in DataBase.Budgets)
        {
            Console.WriteLine(b);
            stat.dailySpent = 0;
            stat.weeklySpent = 0;
            stat.monthlySpent = 0;
            stat.computeMoneyUsed(b);
            stat.calculateActivitySpent(b);
        }

        #region old
        /* Budget budget = new Budget("Jake", 10000);
         DataBase forBudget = new DataBase("budget.json");

         BudgetActivity budgetActivity = new BudgetActivity("activity", "desc", 1000, BudgetActivityType.Expense);
         budget.AddActivity(budgetActivity);

         Item item = new Item("fon", 10, 1);
         budgetActivity.AddItem(item);
         Item item1 = new Item("fon", 10, 1);
         budgetActivity.AddItem(item1);

         BudgetActivity subActivity = new BudgetActivity("subAct", "desc", 50, BudgetActivityType.Expense);
         budgetActivity.AddSubActivity(subActivity);
         BudgetActivity subActivity1 = new BudgetActivity("subAct1", "desc", 50, BudgetActivityType.Expense);
         budgetActivity.AddSubActivity(subActivity1);
         Item subItem = new Item("subFood", 20, 1);
         subActivity.AddItem(subItem);

         forBudget.save(budget);*/
        //DataBase dataBase = new DataBase("budget.json");
        //DataBase dataBase = new DataBase("budget.json");
        // Budget budget = DataBase.load();

        //Console.WriteLine(budget);

        // Budget budget1 = new Budget("jake", 100);
        //budget1.PrintBudget();
        //Console.WriteLine(budget1);

        // Load budget from JSON file
        /*Budget loadedBudget = Budget.LoadFromJson(fileName);
        Console.WriteLine("Loaded budget:");
        Console.WriteLine(loadedBudget.ToString());*/

        /* Console.WriteLine("Hello");
         Budget budget = new Budget("Nina", 1000);
         BudgetActivity budgetAct = new BudgetActivity("Grocery Shoppping", "Desc.", 100);
         budget.AddActivity(budgetAct);
         Item item = new Item("Biscuit", 50, 1);
         item.AddTag("Snack");
         budgetAct.AddItem(item);
         IReadOnlyCollection<Item> read = (ReadOnlyCollection<Item>)budgetAct.GetItems();
         foreach (var item1 in read)
         {
             IReadOnlyCollection<String> itemTags = (ReadOnlyCollection<String>)item1.Tags();
             if (itemTags.Contains("Snack"))
                 Console.WriteLine("Naay isnak");
             else Console.WriteLine("Wa");
         }*/
        /* Budget budget = new Budget("Nina", 1000);
         BudgetActivity budgetAct = new BudgetActivity("Grocery Shoppping", "Desc.", 100,BudgetActivityType.Expense);
         BudgetActivity budgetAct0 = new BudgetActivity("Grocery Shoppping", "Desc.", 100, BudgetActivityType.Expense);
         BudgetActivity budgetAct1 = new BudgetActivity("Grocery Shoppping", "Desc.", 100, BudgetActivityType.Expense);
         BudgetActivity budgetAct2 = new BudgetActivity("Grocery Shoppping", "Desc.", 100, BudgetActivityType.Expense);
         budget.AddActivity(budgetAct);
         budget.AddActivity(budgetAct0);
         budget.AddActivity(budgetAct1);
         budget.AddActivity(budgetAct2);
         Item item = new Item("Biscuit", 50, 1);
         Item item12 = new Item("Biscuit", 10, 1);
         Item item0 = new Item("Biscuit", 50, 1);
         Item item1 = new Item("Biscuit", 20, 1);
         Item item2 = new Item("Biscuit", 10, 1);
         budgetAct.AddItem(item);
         budgetAct.AddItem(item12);
         budgetAct0.AddItem(item0);
         budgetAct1.AddItem(item1);
         budgetAct2.AddItem(item2);
         BudgetActivity subAct = new BudgetActivity("eat0", "desc", 50, BudgetActivityType.Expense);
         BudgetActivity subAct1 = new BudgetActivity("eat1", "desc", 10, BudgetActivityType.Expense);
         BudgetActivity subAct2 = new BudgetActivity("eat2", "desc", 90, BudgetActivityType.Expense);
         BudgetActivity subAct3 = new BudgetActivity("eat3", "desc", 90, BudgetActivityType.Expense);
         budgetAct.AddSubActivity(subAct);
         budgetAct.AddSubActivity(subAct1);
         budgetAct.AddSubActivity(subAct2);
         budgetAct.AddSubActivity(subAct3);

         Item subItem = new Item("fish", 10, 1);
         subAct1.AddItem(subItem);
         Item subItem1 = new Item("fish", 10, 1);
         subAct.AddItem(subItem1);

         Statistic stats = new Statistic();

         //Console.WriteLine(budgetAct.Actual);
         stats.computeMoneyUsed(budget);
         stats.calculateActivitySpent(budgetAct);*/

        /* Budget budget = new Budget("Jake", 1000);
         BudgetActivity budgetActivity = new BudgetActivity("Travel", "description", 200, BudgetActivityType.Expense);
         budget.AddActivity(budgetActivity);
         BudgetActivity subActivity = new BudgetActivity("kaon", "description", 20, BudgetActivityType.Expense);
         BudgetActivity subActivity1 = new BudgetActivity("kaon", "description", 50, BudgetActivityType.Expense);
         BudgetActivity subActivity2 = new BudgetActivity("kaon", "description", 50, BudgetActivityType.Expense);
         BudgetActivity subActivity3 = new BudgetActivity("kaon", "description", 50, BudgetActivityType.Expense);
         BudgetActivity subActivity4 = new BudgetActivity("kaon", "description", 50, BudgetActivityType.Expense);
         Item item = new Item("Phone", 100, 1);

         budgetActivity.AddItem(item);

         //Act
         var result = budgetActivity.AddSubActivity(subActivity);
         budgetActivity.AddSubActivity(subActivity1);
         budgetActivity.AddSubActivity(subActivity2);
         budgetActivity.AddSubActivity(subActivity3);
         budgetActivity.AddSubActivity(subActivity4);

         ReadOnlyCollection<BudgetActivity> activitiesList = (ReadOnlyCollection<BudgetActivity>)budgetActivity.GetSubActivities();
         foreach (BudgetActivity activity in activitiesList)
         {
             Console.WriteLine(activity.Name);
         }*/

        /*Budget budget = new Budget("Jake", 1000);
        BudgetActivity budgetActivity = new BudgetActivity("Travel", "desc", 500, BudgetActivityType.Expense);
        budget.AddActivity(budgetActivity);
        Item item = new Item("Fon", 100, 2);
        budgetActivity.AddItem(item);
        BudgetActivity savingsActivity = new BudgetActivity("Savings", "desc", 500, BudgetActivityType.Savings);

        //Act
       budgetActivity.transferAmountToActivity(100, savingsActivity);

        Console.WriteLine(savingsActivity.Actual);*/

        /*Budget budget = new Budget("Jake", 1000);
        BudgetActivity budgetActivity = new BudgetActivity("Travel", "desc", 500, BudgetActivityType.Expense);
        budget.AddActivity(budgetActivity);
        Item item = new Item("Fon", 100, 2);
        budgetActivity.AddItem(item);
        BudgetActivity savingsActivity = new BudgetActivity("Savings", "desc", 500, BudgetActivityType.Savings);

        budgetActivity.transferAmountToActivity(450, savingsActivity);
        double sum = budgetActivity.Projected - budgetActivity.GetSummedProjectedsItems();

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Savings Actual: " + savingsActivity.Actual);
        Console.WriteLine("BudgetActivity Actual:" + budgetActivity.Actual);*/

        /* Budget budget = new Budget("Nina", 1000);
         BudgetActivity budgetAct = new BudgetActivity("Grocery Shoppping", "Desc.", 100, BudgetActivityType.Expense);
         budget.AddActivity(budgetAct);
         Item item = new Item("Biscuit", 50, 1);
         budgetAct.AddItem(item);
         BudgetActivity subActivity = new BudgetActivity("subAct", "desc", 10, BudgetActivityType.Expense);
         budgetAct.AddSubActivity(subActivity);
         Item food = new Item("food", 10, 1);
         subActivity.AddItem(food);

         ReadOnlyCollection<Item> itemList = budgetAct.GetAllItems();
         foreach (Item items in itemList)
         {
             Console.WriteLine(items.Name);
         }*/
        #endregion
    }
}