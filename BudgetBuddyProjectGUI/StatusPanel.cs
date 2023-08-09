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
        public StatusPanel(BudgetActivity act)
        {
            InitializeComponent();
            this.Name_Label.Text = act.Name;
            this.ActualBalanceAmount_Label.Text = act.Actual.ToString("N2");
            this.ProjectedAmount_Label.Text = act.GetSummedProjectedsItems().ToString("N2");
            this.AllocatedAmount_Label1.Text = "/" + (act.Projected.ToString("N2"));
            this.AllocatedAmount_Label2.Text = "/" + (act.Projected.ToString("N2"));
            ToolTip nameLabel_toolTip = new ToolTip();
            nameLabel_toolTip.SetToolTip(Name_Label, Name_Label.Text);

            double maxBudget = act.Projected, projected = act.GetSummedProjectedsItems(), actual = act.Actual;

            // Attach an event handler to the Paint event of the PictureBox control
            this.StatusBar_PicBox.Paint += (s, e) =>
            {
                // Get the Graphics object from the PaintEventArgs
                Graphics g = e.Graphics;

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
            };
        }
    }
}