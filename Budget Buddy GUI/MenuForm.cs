namespace Budget_Buddy_GUI
{
    public partial class MenuForm : Form
    {
        private Form previousForm;
        public MenuForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            new Help().Show();
            this.Hide();
        }

        private void FAQsButton_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
