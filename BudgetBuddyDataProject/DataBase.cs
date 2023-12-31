﻿using Student_Financial_Assisstance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO.Enumeration;
using System.Collections.ObjectModel;
using System.Numerics;

namespace BudgetBuddyProject
{
    public class DataBase
    {
        private static string RootDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static string BudgetFileName = "budget.bb";
        private static string BackupDirectoryPathFile = "backupDirectoryPath.txt";
        public static string? BackupDirectory;
        public static List<Budget> Budgets = new List<Budget>();

        public static void SaveBudget()
        {
            string json = JsonConvert.SerializeObject(Budgets, Formatting.Indented);
            File.WriteAllText(Path.Combine(RootDirectory, BudgetFileName),json);
        }

        public static void LoadBudget()
        {
           try
            {
                string json = File.ReadAllText(Path.Combine(RootDirectory, BudgetFileName));
                Budgets = JsonConvert.DeserializeObject<List<Budget>>(json)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }

        public static bool CreateBackup()
        {
            if (string.IsNullOrEmpty(BackupDirectory))
            {
                Console.WriteLine("Please choose a backup directory first.");
                return false;
            }

            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string backupFileName = $"budget_{timestamp}.bb";
            string json = JsonConvert.SerializeObject(Budgets, Formatting.Indented);
            File.WriteAllText(Path.Combine(BackupDirectory, backupFileName), json);
            return true;
        }

        /*public static void LoadBackup()
        {
            if (string.IsNullOrEmpty(BackupDirectory))
            {
                Console.WriteLine("Please choose a backup directory first.");
                return;
            }

            try
            {
                var directoryInfo = new DirectoryInfo(BackupDirectory);
                var latestBackupFile = directoryInfo.GetFiles()
                    .Where(f => f.Extension.Equals(".bb"))
                    .OrderByDescending(f => f.LastWriteTime)
                    .FirstOrDefault();

                if (latestBackupFile != null)
                {
                    string json = File.ReadAllText(latestBackupFile.FullName);
                    Budgets = JsonConvert.DeserializeObject<List<Budget>>(json)!;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }*/

        public static void SaveBackupDirectoryPath()
        {
            if (!string.IsNullOrEmpty(BackupDirectory))
            {
                File.WriteAllText(Path.Combine(RootDirectory, BackupDirectoryPathFile), BackupDirectory);
            }
        }

        public static void LoadBackupDirectoryPath()
        {
            try
            {
                if (File.Exists(Path.Combine(RootDirectory, BackupDirectoryPathFile)))
                {
                    BackupDirectory = File.ReadAllText(Path.Combine(RootDirectory, BackupDirectoryPathFile));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }

        public static void LoadSpecificBackup(string backupFilePath)
        {
            try
            {
                string json = File.ReadAllText(backupFilePath);
                Budgets = JsonConvert.DeserializeObject<List<Budget>>(json)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }


        /*

        public void addBudget(Budget budget)
        {
            Budgets.Add(budget);
        }

        public static void addActivity(BudgetActivity budgetActivity, string budgetName)
        {
            foreach(Budget b in Budgets)
            {
                if (b.Name == budgetName)
                {
                    b.AddActivity(budgetActivity);
                }
            }
        }

        public static void addItem(Item item, string budgetName, string actName)
        {
            foreach (Budget b in Budgets)
            {
                if(b.Name == budgetName) 
                {
                    foreach (BudgetActivity ba in b.Activities)
                    {
                        if(ba.Name == actName)
                        {
                            ba.AddItem(item);
                        }
                    }
                }   
            }
        }

        public void save(Budget budget)
        {
            addBudget(budget);
            addActivity(budget);
            addItem(budget);
            string jsonString = JsonConvert.SerializeObject(budget, new JsonSerializerSettings { Formatting = Formatting.Indented });
            File.WriteAllText(fileName, jsonString);
        }

        public void addBudget(Budget budget)
        {
            Budgets.Add(budget);
        }

        public void addActivity(Budget budget)
        {
            ReadOnlyCollection<BudgetActivity> activitiesList = (ReadOnlyCollection<BudgetActivity>)budget.GetActivities();

            foreach (BudgetActivity activity in activitiesList)
            {
                BudgetActivities.Add(activity);
            }
        }

        public void addItem(Budget budget)
        {
            ReadOnlyCollection<BudgetActivity> activitiesList = (ReadOnlyCollection<BudgetActivity>)budget.GetActivities();
            HashSet<Item> itemList = new HashSet<Item>();

            foreach (BudgetActivity activity in activitiesList)
            {
                ReadOnlyCollection<Item> activityItemList = activity.GetAllItems();
                foreach(Item item in activityItemList)
                {
                    Items.Add(item);
                }
            }
        }
        public static Budget load()
        {
            string fileName = @"C:\Users\MARY GRACE\source\repos\BudgetBuddyProject\BudgetBuddyProject\bin\Debug\net6.0\budget";
            if(System.IO.File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                Budget budget = JsonConvert.DeserializeObject<Budget>(jsonString);
                Console.WriteLine(budget);
                return budget;  
            }
            return null;
        }*/

    }
}
