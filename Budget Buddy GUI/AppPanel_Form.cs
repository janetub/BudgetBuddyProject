using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class AppPanel_Form : Form
    // add a dialog box w option to redirect to page of control
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
            createBudgetControl.OnBackButtonClicked += BudgetEntriesPlaceholder_Refresh;
            this.Placeholder_Panel.Controls.Add(createBudgetControl);
            createBudgetControl.Dock = DockStyle.Fill;
            this.PageName_Label.Text = "Create a Budget";
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
        private void ShowCreateBudgetActivityControl()
        {
            CreateBudgetActivity_Control createBudgetActivityControl = new CreateBudgetActivity_Control(true);
            createBudgetActivityControl.OnActivityEntered += ActivityEntryCreated;
            createBudgetActivityControl.OnBackButtonClicked += Refresh_BudgetActivityEntriesPlaceholder;
            this.Placeholder_Panel.Controls.Add(createBudgetActivityControl);
            createBudgetActivityControl.Dock = DockStyle.Fill;
            this.PageName_Label.Text = "Create an Activity";
        }

        private void ShowCreateItemControl()
        {
            CreateItem_Control createItem = new();
            createItem.OnBackButtonClicked += CreateItem_OnBackButtonClicked;
            createItem.OnItemCreationConfirmed += CreateItem_OnItemCreationConfirmed;
            this.Placeholder_Panel.Controls.Add(createItem);
            createItem.Dock = DockStyle.Fill;
            this.PageName_Label.Text = "Create an Item";
        }

        private void CreateItem_OnItemCreationConfirmed(object? sender, ItemEventArgs e)
        {
            ShowSubActivityEntries();
        }

        private void CreateItem_OnBackButtonClicked(object? sender, ItemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowPlaceholder_BudgetEntries()
        {
            this.Placeholder_Panel.Controls.Clear();
            Placeholder_BudgetEntries_Control placeholder_BudgetEntries_Control = new Placeholder_BudgetEntries_Control(this.budgets);
            placeholder_BudgetEntries_Control.OnControlClicked += ShowPlaceHolder_ActivityEntries;
            placeholder_BudgetEntries_Control.OnControlUpdated += BudgetEntriesPlaceholder_Refresh;
            this.Placeholder_Panel.Controls.Add(placeholder_BudgetEntries_Control);
            this.Add_Button.Visible = true;
            this.PageName_Label.Text = "Budgets";
        }
        private void ShowBudgetActivityEntries(Budget budget)
        {
            if (this.activeBudget == null) return;
            Placeholder_ActivityEntries_Control activities = new Placeholder_ActivityEntries_Control(budget);
            activities.OnBackButtonClicked += BudgetEntriesPlaceholder_Refresh;
            activities.OnEditBudgetClicked += ShowForm_EditBudget;
            activities.OnEntriesUpdated += Refresh_BudgetEntriesPlaceholder;
            activities.OnEntryClicked += Activities_OnEntryClicked;
            this.Placeholder_Panel.Controls.Clear();
            this.Placeholder_Panel.Controls.Add(activities);
            this.Add_Button.Visible = true;
            this.PageName_Label.Text = "Budget Activities";
        }

        private void ShowBudgetActivityEntries(BudgetActivity activity)
        {

        }

        private void Activities_OnEntryClicked(object sender, EventArgs e)
        {
            EntryActivity_Control control = (EntryActivity_Control)sender;
            BudgetActivity activity = (BudgetActivity)control.Tag;
            ShowSubActivityEntries(activity);
        }

        private void ShowSubActivityEntries(BudgetActivity activity)
        {
            this.Placeholder_Panel.Controls.Clear();
            Placeholder_SubActivitiesEntries_Control subAct = new(activity);
            subAct.OnEntriesUpdated += SubAct_OnEntriesUpdated;
            //
            this.Placeholder_Panel.Controls.Add(subAct);
            this.Add_Button.Visible = true;
            this.PageName_Label.Text = "Budget Subactivity";
        }

        private void SubAct_OnEntriesUpdated(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ActivityEntryCreated(object? sender, EventArgs e)
        {
            try
            {
                CreateBudgetActivity_Control control = (CreateBudgetActivity_Control)sender!;
                BudgetActivity activity = (BudgetActivity)control.Tag;
                if (activity == null || this.activeBudget == null)
                {
                    MessageBox.Show("Cannot create activity.");
                    return;
                }
                foreach (BudgetActivity a in this.activeBudget.Activities)
                {
                    if (a.Name == this.activeBudget.Name)
                    {
                        MessageBox.Show("An activity with the same name already exists.");
                        return;
                    }
                }
                this.activeBudget.AddActivity(activity);
                ShowBudgetActivityEntries(this.activeBudget);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while creating the Budget activity entry. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void BudgetEntriesPlaceholder_Refresh(object? sender, EventArgs e)
        {
            ShowPlaceholder_BudgetEntries();
        }

        private void Refresh_BudgetActivityEntriesPlaceholder(object? sender, EventArgs e)
        {
            try
            {
                if (this.currentDirectory.Count > 0)
                {
                    ShowBudgetActivityEntries(currentDirectory.Last!.Value);
                }
                else
                {
                    ShowBudgetActivityEntries(this.activeBudget!);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while refreshing the Budget activities. Please try again.\n" + ex.Message, "Error");
            }
        }

        private void ShowPlaceHolder_ActivityEntries(object sender, EventArgs e)
        {
            EntryBudget_Control entry = (EntryBudget_Control)sender;
            this.activeBudget = (Budget)entry.Tag;
            ShowBudgetActivityEntries(this.activeBudget);
        }

        private void ShowForm_EditBudget(object? sender, EventArgs e)
        {
            this.modalPanel.Visible = true;
            this.modalPanel.BringToFront();
            if (this.activeBudget == null || !this.budgets.Contains(this.activeBudget))
            {
                MessageBox.Show("Cannot edit Budget");
                return;
            }
            EditBudget_Form form = new(this.activeBudget);
            form.OnConfirmButtonClicked += Form_OnConfirmButtonClicked;
            form.ShowDialog();
            this.modalPanel.Visible = false;
        }

        private void Form_OnConfirmButtonClicked(object sender, EventArgs e)
        {
            EditBudget_Form form = (EditBudget_Form)sender;
            Budget update = (Budget)form.Tag;
            if (update == null || this.activeBudget == null || !this.budgets.Contains(this.activeBudget))
            {
                MessageBox.Show("Cannot edit budget.");
                return;
            }
            foreach (Budget b in this.budgets)
            {
                if (b.Name == update.Name)
                {
                    if (update.Name == this.activeBudget.Name) break;
                    MessageBox.Show("A budget with the same name already exists.");
                    return;
                }
            }
            foreach (Budget b in this.budgets)
            {
                if (b.Name == this.activeBudget.Name)
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
                    ShowBudgetActivityEntries(this.activeBudget);
                    form.Close();
                    return;
                }
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

        private void Exit_Button_Click(object? sender, EventArgs e)
        {
            this.Close();
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
