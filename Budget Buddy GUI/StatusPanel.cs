using Student_Financial_Assisstance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Buddy_GUI
{
    public partial class StatusPanel : UserControl
    {
        public StatusPanel(Placeholder_SubActivitiesEntries_Control placeholder_BudgetActivitiesEntries_Control)
        {
            InitializeComponent();
            placeholder_BudgetActivitiesEntries_Control.OnEntriesUpdated += UpdateStatusBar;
            BudgetActivity act = (BudgetActivity)placeholder_BudgetActivitiesEntries_Control.Tag;
            this.ActualBalanceAmount_Label.Text = act.Actual.ToString().Contains(".") ? act.Actual.ToString() : act.Actual + ".00";
            this.ProjectedAmount_Label.Text = act.GetSummedProjectedsItems().ToString().Contains(".") ? act.GetSummedProjectedsItems().ToString() : act.GetSummedProjectedsItems() + ".00";
            this.AllocatedAmount_Label1.Text = "/" + (act.Projected.ToString().Contains(".") ? act.Projected.ToString() : act.Projected + ".00");
            this.AllocatedAmount_Label2.Text = "/" + (act.Projected.ToString().Contains(".") ? act.Projected.ToString() : act.Projected + ".00");
        }

        private void UpdateStatusBar(object sender, EventArgs e)
        {
            Placeholder_SubActivitiesEntries_Control control = (Placeholder_SubActivitiesEntries_Control)sender;
            BudgetActivity act = (BudgetActivity)control.Tag;
            this.Name_Label.Text = act.Name;
            double maxBudget = act.Projected, projected = act.GetSummedProjectedsItems(), actual = act.Actual;

            Graphics g = this.StatusBar_PicBox.CreateGraphics();

            // Projected
            float projectedWidth = this.StatusBar_PicBox.Width * (float)(projected / maxBudget);
            g.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 200)), new RectangleF(0, 0, projectedWidth, Height));
            // Label for Projected
            string projectedLabel = "P";
            SizeF projectedLabelSize = g.MeasureString(projectedLabel, this.Font);
            PointF projectedLabelLocation = new PointF(projectedWidth - projectedLabelSize.Width, 0);
            g.DrawString(projectedLabel, this.Font, Brushes.Black, projectedLabelLocation);

            // Actual
            float actualWidth = this.StatusBar_PicBox.Width * (float)(actual / maxBudget);
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, 255, 0)), new RectangleF(0, 0, actualWidth, Height));
            // Label for Actual
            string actualLabel = "A";
            SizeF actualLabelSize = g.MeasureString(actualLabel, this.Font);
            PointF actualLabelLocation = new PointF(actualWidth - actualLabelSize.Width, 0);
            g.DrawString(actualLabel, this.Font, Brushes.Black, actualLabelLocation);
        }

    }
}