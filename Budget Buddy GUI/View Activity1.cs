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
    public partial class View_Activity1 : Form
    {
        public View_Activity1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmptyActivity().Show();
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void pb_Click(object sender, EventArgs e)
        {
            double maxBudget = 100, projected = 55, actual = 20;

            Graphics g = pb.CreateGraphics();

            //Projected
            g.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 200)), new RectangleF(0, 0, pb.Width * (float)(projected / maxBudget), Height));
            //Actual
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, 255, 0)), new RectangleF(0, 0, pb.Width * (float)(actual / maxBudget), Height));

            //For percentage of Projected at the Right
            double projectedAmount = projected / maxBudget * 100;
            SolidBrush brush1 = new SolidBrush(Color.FromArgb(200, 255, 200));
            SizeF textSize1 = g.MeasureString($"{projectedAmount:0.##}.00", Font);
            float textX1 = pb.Width * (float)(actual / maxBudget) / 2 - textSize1.Width / 2;
            float textY1 = pb.Height / 2 - textSize1.Height / 2;
            RectangleF rect1 = new RectangleF(0, 0, pb.Width * (float)(projected / maxBudget), pb.Height);
            g.FillRectangle(brush1, rect1);
            g.DrawString($"{projectedAmount:0.##}.00", Font, Brushes.Black, rect1, new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Near });

            //Label will be placed outside the color
            //g.DrawString($"{projectedAmount:0.##}.00", Font, Brushes.Black, pb.Width * (float)(projected / maxBudget) + 5, pb.Height / 2 - Font.Height / 2);

            //For percentage of Actual at the Center of
            double actualAmount = actual / maxBudget * 100;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 255, 0));
            SizeF textSize = g.MeasureString($"{actualAmount:0.##}.00", Font);
            float textX = pb.Width * (float)(actual / maxBudget) / 2 - textSize.Width / 2;
            float textY = pb.Height / 2 - textSize.Height / 2;
            RectangleF rect = new RectangleF(0, 0, pb.Width * (float)(actual / maxBudget), pb.Height);
            g.FillRectangle(brush, rect);
            g.DrawString($"{actualAmount:0.##}.00", Font, Brushes.Black, rect, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }
    }
}
