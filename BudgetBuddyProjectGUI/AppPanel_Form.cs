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
using BudgetBuddyProject;
using Student_Financial_Assisstance;

namespace Budget_Buddy_GUI
{
    // TODO add a dialog box w option to redirect to page of control
    // TODO add messagebox when creation is not processed or maximum amount is exceeded
    // FIXME bug, sometimes after creating an entry, it does not get added || actually add a messagebox if the entry was not added or a snackbar. see classes, use the bool return of the function
    // TODO put appropriate texts such as when inside savings, instead of add item when creating an item, put contribution

    public partial class AppPanel_Form : Form
    {
        private HashSet<Budget> budgets = new HashSet<Budget>();
        private Budget? activeBudget = null;
        private LinkedList<BudgetActivity> currentDirectory = new LinkedList<BudgetActivity>();

        public AppPanel_Form(HashSet<Budget> budgets)
        {
            InitializeComponent();
            this.budgets = budgets;
            this.Add_Button.Visible = true;
            ShowPlaceholder_BudgetEntries();
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
        private void ShowCreateBudgetActivityControl(bool canCreateSavings)
        {
            CreateBudgetActivity_Control createBudgetActivityControl = new CreateBudgetActivity_Control(canCreateSavings);
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
                    if (!currentActivity.AddSubActivity(activity))
                    {
                        MessageBox.Show("Projected amount cannot be funded. Please check funds and try again.", "Cannot Add Activity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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
                    if (!this.activeBudget!.AddActivity(activity))
                    {
                        MessageBox.Show("Projected amount cannot be funded. Please check balance and try again.", "Cannot Add Activity", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    ShowPlaceholder_BudgetActivityEntries(this.activeBudget);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while creating the Budget Activity entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void Add_ItemEntry(object? sender, EventArgs e)
        {
            try
            {
                CreateItem_Control control = (CreateItem_Control)sender!;
                Item newItem = (Item)control.Tag;
                foreach (Item i in this.currentDirectory.Last!.Value.Items)
                {
                    if (i.Name == newItem.Name)
                    {
                        MessageBox.Show("An item with the same name already exists.");
                        return;
                    }
                }
                if (!this.currentDirectory.Last!.Value.AddItem(newItem))
                {
                    MessageBox.Show("Please check your balance and try again.\n", "Not Enough Funds");
                    return;
                }
                ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while creating the item entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void ShowPlaceholder_BudgetEntries()
        {
            Placeholder_BudgetEntries_Control placeholder_BudgetEntries_Control = new Placeholder_BudgetEntries_Control(this.budgets);
            placeholder_BudgetEntries_Control.OnControlClicked += Open_BudgetEntry;
            placeholder_BudgetEntries_Control.OnControlUpdated += Refresh_BudgetEntriesPlaceholder;
            this.Placeholder_Panel.Controls.Clear();
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
                activities.OnAddAmountClicked += Show_AddBudgetAmountForm;
                activities.OnRemoveAmountClicked += Show_RemoveBudgetForm;
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
                // CollapseButton.performCLick() when other elements are clicked
                activities.OnBackButtonClicked += Refresh_SubActivityEntriesPlaceholder;
                activities.OnEntriesUpdated += Refresh_SubActivityEntries;
                activities.OnEditButtonClicked += Show_EditActivityForm;
                activities.OnEntryClicked += Open_BudgetActivityEntry;
                activities.OnCancelSavingsButtonClicked += CancelSavings;
                activities.OnTransferToBudgetClicked += TransferFunds_ToBudget;
                this.Placeholder_Panel.Controls.Clear();
                this.Placeholder_Panel.Controls.Add(activities);
                this.Add_Button.Visible = true;
                this.PageName_Label.Text = "Subactivities";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading the Budget activities. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void CancelSavings(object? sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Cancelling this savings will move all your saved funds back to your Budget funds. You may choose to delete this activity anytime.", "Are you sure you want to cancel this savings activity?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    if(!this.activeBudget!.CancelSavings(this.currentDirectory.Last!.Value))
                    {
                        MessageBox.Show("A problem occured while cancelling the savings activity. Please try again later.", "Cannot Cancel Savings");
                        return;
                    }
                    this.currentDirectory.Last!.Value.isUsed = true;
                    ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while cancelling the savings activity. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void TransferFunds_ToBudget(object? sender, EventArgs e)
        {
            try
            {
                String message = ((BudgetActivity)((Placeholder_SubActivitiesEntries_Control)sender!).Tag).ActivityType == BudgetActivityType.Expense ? "Remaining unused funds in this activity will be moved back to the budget funds." : "All saved amount in this activity will be added to the budget funds.";
                DialogResult result = MessageBox.Show(message, "Are you sure you want to transfer the activity funds to the budget funds?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    if(!this.activeBudget!.TransferBalanceToBudget(this.currentDirectory.Last!.Value))
                    {
                        MessageBox.Show("A problem occured while moving the funds. Please check all subactivities within this activity and try again later.", "Cannot Transfer Funds");
                        return;
                    }
                    this.currentDirectory.Last!.Value.isUsed = true;
                    ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while cancelling the savings activity. Please try again.\n" + ex.Message, "Error");
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

        private void Refresh_SubActivityEntries(object? sender, EventArgs e)
        {
            ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
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
                if (placeholderContent is CreateItem_Control || placeholderContent is CreateBudgetActivity_Control)
                {
                    ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
                }
                else if (placeholderContent is Placeholder_SubActivitiesEntries_Control)
                {
                    if (this.currentDirectory.Count > 0)
                    {
                        this.currentDirectory.RemoveLast();
                        if (this.currentDirectory.Count > 0)
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
                CollapseButton.PerformClick();
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
                MessageBox.Show("An error occured while editing budget", "Budget does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditBudget_Form form = new(this.activeBudget);
            form.OnConfirmButtonClicked += Edit_BudgetEntry;
            form.ShowDialog();
            this.modalPanel.Visible = false;
        }

        private void Show_AddBudgetAmountForm(object? sender, EventArgs e)
        {
            this.modalPanel.Visible = true;
            this.modalPanel.BringToFront();
            if (this.activeBudget == null || !this.budgets.Contains(this.activeBudget))
            {
                MessageBox.Show("An error occured while adding amount to budget funds", "Budget does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditBudgetmount_Form form = new("add", this.activeBudget);
            form.OnConfirmAddButtonClicked += AddAmount_BudgetEntry;
            form.ShowDialog();
            this.modalPanel.Visible = false;
        }

        private void Show_RemoveBudgetForm(object? sender, EventArgs e)
        {
            this.modalPanel.Visible = true;
            this.modalPanel.BringToFront();
            if (this.activeBudget == null || !this.budgets.Contains(this.activeBudget))
            {
                MessageBox.Show("An error occured while removing amount to budget funds", "Budget does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditBudgetmount_Form form = new("remove", this.activeBudget);
            form.OnConfirmRemoveButtonClicked += RemoveAmount_BudgetEntry;
            form.ShowDialog();
            this.modalPanel.Visible = false;
        }

        private void Show_EditActivityForm(object? sender, EventArgs e)
        {
            try
            {
                this.modalPanel.Visible = true;
                this.modalPanel.BringToFront();
                if (this.activeBudget == null || !this.budgets.Contains(this.activeBudget) || this.currentDirectory.Count < 1)
                {
                    MessageBox.Show("An error occured while editing activity", "Budget or Activity does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                EditActivity_Form form = new(this.currentDirectory.Last!.Value);
                form.OnConfirmEditClicked += Edit_ActivityEntry;
                form.ShowDialog();
                this.modalPanel.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while loading Edit Activity Form. Please try again.\nError: " + ex.Message, "Cannot Open Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_BudgetEntry(object? sender, EventArgs e)
        {
            try
            {
                var senderForm = sender;
                if (!this.budgets.Contains(this.activeBudget!))
                {
                    MessageBox.Show("An error occurred while editing the Budget entry. Please try again.\n", "Missing Budget");
                    return;
                }
                EditBudget_Form form = (EditBudget_Form)sender!;
                Budget update = (Budget)form.Tag;
                foreach (Budget b in this.budgets)
                {
                    if (b.Name == update.Name)
                    {
                        if (b.Name == this.activeBudget!.Name) break;
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

        private void Edit_ActivityEntry(object? sender, EventArgs e)
        {
            try
            {
                var senderForm = sender;
                if (!this.budgets.Contains(this.activeBudget!) || this.currentDirectory.Count < 0)
                {
                    MessageBox.Show("An error occurred while editing the Activity entry. Please try again.\n", "Missing Budget or Activity");
                    return;
                }
                EditActivity_Form form = (EditActivity_Form)sender!;
                BudgetActivity update = (BudgetActivity)form.Tag;
                if(this.currentDirectory.Count == 1)
                {
                    foreach (BudgetActivity a in this.activeBudget!.Activities)
                    {
                        if (a.Name == update.Name)
                        {
                            if (a.Name == this.currentDirectory.Last!.Value.Name) break;
                            MessageBox.Show("An activity with the same name already exists.");
                            return;
                        }
                    }
                }
                if(this.currentDirectory.Count > 1)
                {
                    BudgetActivity prev = this.currentDirectory.Last!.Value;
                    this.currentDirectory.RemoveLast();
                    foreach (BudgetActivity a in this.currentDirectory.Last!.Value.SubActivities)
                    {
                        if (a.Name == update.Name)
                        {
                            if (a.Name == this.activeBudget!.Name) break;
                            MessageBox.Show("An activity with the same name already exists.");
                            return;
                        }
                    }
                    this.currentDirectory.AddLast(prev);
                }
                this.currentDirectory.Last!.Value.Name = update.Name;
                this.currentDirectory.Last!.Value.Description = update.Description;
                ShowPlaceholder_SubActivityEntries(this.currentDirectory.Last!.Value);
                form.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while editing the Activity entry. Please try again.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAmount_BudgetEntry(object? sender, EventArgs e)
        {
            try
            {
                var senderForm = sender;
                if (!this.budgets.Contains(this.activeBudget!))
                {
                    MessageBox.Show("An error occurred while editing the Budget entry. Please try again.\n", "Missing Budget");
                    return;
                }
                EditBudgetmount_Form form = (EditBudgetmount_Form)sender!;
                foreach (Budget b in this.budgets)
                {
                    if (b.Name == this.activeBudget!.Name)
                    {
                        b.AddBudgetAmount(form.Amount);
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

        private void RemoveAmount_BudgetEntry(object? sender, EventArgs e)
        {
            try
            {
                var senderForm = sender;
                if (!this.budgets.Contains(this.activeBudget!))
                {
                    MessageBox.Show("An error occurred while editing the Budget entry. Please try again.\n", "Missing Budget");
                    return;
                }
                EditBudgetmount_Form form = (EditBudgetmount_Form)sender!;
                foreach (Budget b in this.budgets)
                {
                    if (b.Name == this.activeBudget!.Name)
                    {
                        b.RemoveBudgetAmount(form.Amount);
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
                    this.ShowCreateBudgetActivityControl(true);
                    this.Add_Button.Visible = false;
                }
                else if (placeholderContent is Placeholder_SubActivitiesEntries_Control)
                {
                    BudgetActivity act = (BudgetActivity)placeholderContent!.Tag;
                    if (act.ActivityType == BudgetActivityType.Savings)
                    {
                        this.Placeholder_Panel.Controls.Clear();
                        this.ShowCreateItemControl();
                        this.Add_Button.Visible = false;
                    }
                    else if (act.ActivityType == BudgetActivityType.Expense)
                    {
                        this.Add_Button.Visible = false;
                        this.CollapseButton.Visible = this.AddItemButton.Visible = this.AddActivityButton.Visible = this.AddActivityLabel.Visible = this.AddItemLabel.Visible = true;
                        this.CollapseButton.BringToFront();
                        this.AddItemLabel.BringToFront();
                        this.AddActivityButton.BringToFront();
                        this.AddActivityLabel.BringToFront();
                        this.AddItemButton.BringToFront();
                    }
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
            this.ShowCreateBudgetActivityControl(false);
        }

        private void MenuButton_Click(object? sender, EventArgs e)
        {
            btnChooseDirectory_Click(sender, e);
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
        private void AppPanel_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.Budgets = this.budgets.ToList();
            DataBase.SaveBudget();
            DataBase.LoadBackupDirectoryPath();
            if (DataBase.CreateBackup())
            {
                MessageBox.Show("Backup successfully.");
            }
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    DataBase.BackupDirectory = folderBrowserDialog.SelectedPath;
                    DataBase.SaveBackupDirectoryPath();
                    var directoryInfo = new DirectoryInfo(DataBase.BackupDirectory);
                    var latestBackupFile = directoryInfo.GetFiles()
                        .Where(f => f.Extension.Equals(".bb"))
                        .OrderByDescending(f => f.LastWriteTime)
                        .FirstOrDefault();

                    if (latestBackupFile != null)
                    {
                        var result = MessageBox.Show("A backup file was found in the chosen directory. Do you want to load this backup?", "Load Backup", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            DataBase.LoadBackup();
                            MessageBox.Show("Latest backup loaded successfully.");
                        }
                    }
                }
            }
        }
    }
}
