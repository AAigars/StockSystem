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
            MessageBox.Show("Your password has been changed.", Program.title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // check if the user is a guest
            if (Program.activeUser.GetRole() == Authentication.Role.Guest)
            {
                if (Program.loginForm != null)
                    Program.loginForm.Show();

                Close();
                return;
            }

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
