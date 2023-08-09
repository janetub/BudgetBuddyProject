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
    public partial class EntryItem_Control : UserControl
    {
        public event EventHandler? OnControlClicked;
        public event EventHandler? OnDeleteButtonClicked;
        public EntryItem_Control(Item item)
        {
            InitializeComponent();
            this.ItemName_Label.Text = item.Name;
            double price = item.Cost * item.Quantity;
            this.ItemPriceAmount_Label.Text = price.ToString("N2");
            this.ItemQuantity_Label.Text = item.Cost.ToString("N2") + "x" + item.Quantity + "qty";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ItemName_Label, ItemName_Label.Text);
            this.Tag = item;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OnDeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void Entry_Control_Click(object sender, EventArgs e)
        {
            OnControlClicked?.Invoke(this, EventArgs.Empty);
        }
        private void EntryItem_Control_SizeChanged(object sender, EventArgs e)
        {
            int originalControlWidth = 350;
            int originalButtonX = 321;
            int currentControlWidth = this.Size.Width;
            int newButtonX = originalButtonX - (originalControlWidth - currentControlWidth);
            this.Delete_Button.Location = new Point(newButtonX, 3);
        }
    }
}
