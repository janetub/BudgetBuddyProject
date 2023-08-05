using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    // TODO add a dialog box w option to redirect to page of control
    // TODO add messagebox when creation is not processed or maximum amount is exceeded
    public partial class AppPanel_Form : Form
    {
        private HashSet<Budget> budgets = new HashSet<Budget>();
        private Budget? activeBudget = null;
        private LinkedList<BudgetActivity> currentDirectory = new LinkedList<BudgetActivity>();

        public AppPanel_Form(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.budgets = budgets;
            this.Placeholder_Panel.Controls.Add(new Placeholder_BudgetEntries_Control(budgets));
            this.Add_Button.Visible = true;
        }

        private void ShowCreateBudgetControl()
        {
            CreateBudget_Control createBudgetControl = new CreateBudget_Control();
            createBudgetControl.OnBudgetCreated += Add_BudgetEntry;
            createBudgetControl.OnBackButtonClicked += Refresh_BudgetEntriesPlaceholder;
            this.Placeholder_Panel.Controls.Add(createBudgetControl);
            createBudgetControl.Dock = DockStyle.Fill;
            this.PageName_Label.Text = "Create a Budget";
        }
        private void ShowCreateBudgetActivityControl()
        {
            CreateBudgetActivity_Control createBudgetActivityControl = new CreateBudgetActivity_Control(true);
            createBudgetActivityControl.OnActivityEntered += Add_BudgetActivityEntry;
            createBudgetActivityControl.OnBackButtonClicked += Refresh_BudgetActivityEntriesPlaceholder;
            this.Placeholder_Panel.Controls.Add(createBudgetActivityControl);
            createBudgetActivityControl.Dock = DockStyle.Fill;
            this.PageName_Label.Text = "Create an Activity";
        }

        private void ShowCreateItemControl()
        {
            CreateItem_Control createItem = new();
            createItem.OnBackButtonClicked += Refresh_BudgetActivityEntriesPlaceholder;
            createItem.OnItemCreationConfirmed += Add_ItemEntry;
            this.Placeholder_Panel.Controls.Add(createItem);
            createItem.Dock = DockStyle.Fill;
            this.PageName_Label.Text = "Create an Item";
        }

        private void Add_BudgetEntry(object? sender, EventArgs e)
        {
            try
            {
                CreateBudget_Control control = (CreateBudget_Control)sender!;
                Budget newBudget = (Budget)control.Tag;
                foreach (Budget b in this.budgets)
                {
                    if (b.Name == newBudget.Name)
                    {
                        MessageBox.Show("A budget with the same name already exists.");
                        return;
                    }
                }
                this.budgets.Add(newBudget);
                ShowPlaceholder_BudgetEntries();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while creating the Budget entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Add_ItemEntry(object? sender, EventArgs e)
        {
            try
            {
                CreateItem_Control control = (CreateItem_Control)sender!;
                Item newItem= (Item)control.Tag;
                foreach (Item i in this.currentDirectory.Last!.Value.Items)
                {
                    if (i.Name == newItem.Name)
                    {
                        MessageBox.Show("An item with the same name already exists.");
                        return;
                    }
                }
                this.currentDirectory.Last!.Value.AddItem(newItem);
                ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while creating the Item entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void ShowPlaceholder_BudgetEntries()
        {
            this.Placeholder_Panel.Controls.Clear();
            Placeholder_BudgetEntries_Control placeholder_BudgetEntries_Control = new Placeholder_BudgetEntries_Control(this.budgets);
            placeholder_BudgetEntries_Control.OnControlClicked += Open_BudgetEntry;
            placeholder_BudgetEntries_Control.OnControlUpdated += Refresh_BudgetEntriesPlaceholder;
            this.Placeholder_Panel.Controls.Add(placeholder_BudgetEntries_Control);
            this.Add_Button.Visible = true;
            this.PageName_Label.Text = "Budgets";
        }
        private void ShowPlaceholder_BudgetActivityEntries(Budget budget)
        {   
            try
            {
                Placeholder_ActivityEntries_Control activities = new Placeholder_ActivityEntries_Control(budget);
                activities.OnBackButtonClicked += Refresh_BudgetEntriesPlaceholder;
                activities.OnEditBudgetClicked += Show_EditBudgetForm;
                activities.OnEntriesUpdated += Refresh_BudgetActivityEntriesPlaceholder;
                activities.OnEntryClicked += Open_BudgetActivityEntry;
                this.Placeholder_Panel.Controls.Clear();
                this.Placeholder_Panel.Controls.Add(activities);
                this.Add_Button.Visible = true;
                this.PageName_Label.Text = "Budget Activities";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading the Budget activities. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void ShowPlaceholder_SubActivityEntries(BudgetActivity activity)
        {
            try
            {
                Placeholder_SubActivitiesEntries_Control activities = new(activity);
                activities.OnBackButtonClicked += Refresh_SubActivityEntriesPlaceholder;
                /*activities.OnEditButtonClicked += ;
                activities.OnEntriesUpdated += ;
                activities.OnEntryClicked += ;*/
                this.Placeholder_Panel.Controls.Clear();
                this.Placeholder_Panel.Controls.Add(activities);
                this.Add_Button.Visible = true;
                this.PageName_Label.Text = "Budget Activities";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading the Budget activities. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Open_BudgetEntry(object? sender, EventArgs e)
        {
            try
            {
                EntryBudget_Control entry = (EntryBudget_Control)sender!;
                this.activeBudget = (Budget)entry.Tag;
                ShowPlaceholder_BudgetActivityEntries(this.activeBudget);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading the selected Budget. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Open_BudgetActivityEntry(object? sender, EventArgs e)
        {
            try
            {
                EntryActivity_Control control = (EntryActivity_Control)sender!;
                BudgetActivity activity = (BudgetActivity)control.Tag;
                ShowPlaceholder_SubActivityEntries(activity);
                currentDirectory.AddLast(activity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading the BudgetActivity entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Add_BudgetActivityEntry(object? sender, EventArgs e)
        {
            try
            {
                CreateBudgetActivity_Control control = (CreateBudgetActivity_Control)sender!;
                BudgetActivity activity = (BudgetActivity)control.Tag;
                if (this.currentDirectory.Count > 0)
                {
                    foreach (BudgetActivity a in currentDirectory.Last!.Value.SubActivities)
                    {
                        if (a.Name == activity.Name)
                        {
                            MessageBox.Show("An activity with the same name already exists.");
                            return;
                        }
                    }
                    BudgetActivity currentActivity = currentDirectory.Last.Value;
                    currentActivity.SubActivities.Add(activity);
                    ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last.Value);
                }
                else
                {
                    foreach (BudgetActivity a in this.activeBudget!.Activities)
                    {
                        if (a.Name == activity.Name)
                        {
                            MessageBox.Show("An activity with the same name already exists.");
                            return;
                        }
                    }
                    this.activeBudget!.AddActivity(activity);
                    ShowPlaceholder_BudgetActivityEntries(this.activeBudget);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while creating the Budget Activity entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Refresh_BudgetEntriesPlaceholder(object? sender, EventArgs e)
        {
            ShowPlaceholder_BudgetEntries();
        }

        private void Refresh_BudgetActivityEntriesPlaceholder(object? sender, EventArgs e)
        {
            try
            {
                if (this.currentDirectory.Count > 0)
                {
                    ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
                }
                else
                {
                    ShowPlaceholder_BudgetActivityEntries(this.activeBudget!);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while refreshing the Budget activities. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Refresh_SubActivityEntriesPlaceholder(object? sender, EventArgs e)
        {
            try
            {
                // if placeholder is type create control of item and activity then remain in the currentDirectory
                // if placeholder is type subactivities control then go to previous by removing the last of current directory
                    // if currentdirectory count would be zero means it goes out and loads the subactivities of the active budget
                // else generate message box
                var placeholderContent = this.Placeholder_Panel.Controls.OfType<System.Windows.Forms.UserControl>().FirstOrDefault();
                if(placeholderContent is CreateItem_Control || placeholderContent is CreateBudgetActivity_Control)
                {
                    ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
                }
                else if (placeholderContent is Placeholder_SubActivitiesEntries_Control)
                {
                    if(this.currentDirectory.Count > 0)
                    {
                        this.currentDirectory.RemoveLast();
                        if(this.currentDirectory.Count > 0)
                        {
                            ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
                        }
                        else
                        {
                            ShowPlaceholder_BudgetActivityEntries(this.activeBudget!);
                        }
                    }
                    else
                    {
                        ShowPlaceholder_BudgetActivityEntries(this.activeBudget!);
                    }
                }
                else
                {
                    MessageBox.Show("An error occurred while redirecting to previous page. Please try again.\n", "Error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while refreshing the Budget Subactivities. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Show_EditBudgetForm(object? sender, EventArgs e)
        {
            this.modalPanel.Visible = true;
            this.modalPanel.BringToFront();
            if (this.activeBudget == null || !this.budgets.Contains(this.activeBudget))
            {
                MessageBox.Show("Cannot edit Budget");
                return;
            }
            EditBudget_Form form = new(this.activeBudget);
            form.OnConfirmButtonClicked += Edit_BudgetEntry;
            form.ShowDialog();
            this.modalPanel.Visible = false;
        }

        private void Edit_BudgetEntry(object? sender, EventArgs e)
        {
            try
            {
                EditBudget_Form form = (EditBudget_Form)sender!;
                Budget update = (Budget)form.Tag;
                if (!this.budgets.Contains(this.activeBudget!))
                {
                    MessageBox.Show("An error occurred while editing the Budget entry. Please try again.\n", "Missing Budget");
                    return;
                }
                foreach (Budget b in this.budgets)
                {
                    if (b.Name == update.Name)
                    {
                        if (update.Name == this.activeBudget!.Name) break;
                        MessageBox.Show("A budget with the same name already exists.");
                        return;
                    }
                }
                foreach (Budget b in this.budgets)
                {
                    if (b.Name == this.activeBudget!.Name)
                    {
                        b.Name = update.Name;
                        if (update.Amount < b.Amount)
                        {
                            b.RemoveBudgetAmount(b.Amount - update.Amount);
                        }
                        else
                        {
                            b.AddBudgetAmount(update.Amount - b.Amount);
                        }
                        this.activeBudget = b;
                        ShowPlaceholder_BudgetActivityEntries(this.activeBudget);
                        form.Close();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while editing the Budget entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Add_Button_Click(object? sender, EventArgs e)
        {

            if (this.Placeholder_Panel.Controls.Count > 0)
            {
                var placeholderContent = this.Placeholder_Panel.Controls.OfType<System.Windows.Forms.UserControl>().FirstOrDefault();
                if (placeholderContent is Placeholder_BudgetEntries_Control)
                {
                    this.Placeholder_Panel.Controls.Clear();
                    this.ShowCreateBudgetControl();
                    this.Add_Button.Visible = false;
                }
                else if (placeholderContent is Placeholder_ActivityEntries_Control)
                {
                    this.Placeholder_Panel.Controls.Clear();
                    this.ShowCreateBudgetActivityControl();
                    this.Add_Button.Visible = false;
                }
                else if (placeholderContent is Placeholder_SubActivitiesEntries_Control) // TODO do not show add activity button if activity is type savings
                {
                    this.Add_Button.Visible = false;
                    this.CollapseButton.Visible = this.AddItemButton.Visible = this.AddActivityButton.Visible = this.AddActivityLabel.Visible = this.AddItemLabel.Visible = true;
                    this.CollapseButton.BringToFront();
                    this.AddItemLabel.BringToFront();
                    this.AddActivityButton.BringToFront();
                    this.AddActivityLabel.BringToFront();
                    this.AddItemButton.BringToFront();
                }
                else
                    MessageBox.Show($"");
            }
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.AddActivityButton.Visible = this.AddItemButton.Visible = this.AddActivityLabel.Visible = this.AddItemLabel.Visible =
                this.CollapseButton.Visible = false;
            this.Add_Button.Visible = true;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            this.AddActivityButton.Visible = this.AddItemButton.Visible = this.AddActivityLabel.Visible = this.AddItemLabel.Visible =
                this.CollapseButton.Visible = false;
            this.Add_Button.Visible = false;
            this.Placeholder_Panel.Controls.Clear();
            this.ShowCreateItemControl();
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            this.AddActivityButton.Visible = this.AddItemButton.Visible = this.AddActivityLabel.Visible = this.AddItemLabel.Visible =
                this.CollapseButton.Visible = false;
            this.Add_Button.Visible = false;
            this.Placeholder_Panel.Controls.Clear();
            this.ShowCreateBudgetActivityControl();
        }

        private void MenuButton_Click(object? sender, EventArgs e)
        {

        }

        bool isDragging = false;
        Point startPoint;

        private void AppBar_MouseDown(object? sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void AppBar_MouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void AppBar_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void PageName_Label_SizeChanged(object? sender, EventArgs e)
        {
            PageName_Label.Left = (this.ClientSize.Width - PageName_Label.Size.Width) / 2;
        }

        private void Exit_Button_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        /*private void BudgetEntry_BudgetClicked(object sender, EventArgs e)
        {
            EntryBudget_Control budgetEntry = (EntryBudget_Control)sender;
            selectedBudget = (Budget)budgetEntry.Tag;

            AppPanel_Form2 form = new AppPanel_Form2(selectedBudget);

            form.ShowDialog();

            // Update the budget entries after the form is closed
            budgets = form.BudgetEntries;
            this.Placeholder_Panel.Controls.Clear();
            this.Placeholder_Panel.Controls.Add(new PlaceholderBudgetEntries_Control(budgets));
        }*/
    }
}
