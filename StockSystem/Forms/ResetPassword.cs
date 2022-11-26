namespace StockSystem.Forms
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            // check if a user has been logged in for a reset.
            if (Program.activeUser == null)
                return;

            // set the textbox to the username text
            txtUsername.Text = Program.activeUser.GetUsername();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // check if a user has been logged in for a reset.
            if (Program.activeUser == null)
                return;

            // update the password
            Program.activeUser.SetPassword(txtPassword.Text);

            // save the user
            Program.authManager.SaveUsers();

            // close the form and load the stock form
            new StockForm().Show();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
