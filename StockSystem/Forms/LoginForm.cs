namespace StockSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // validation check - make sure that the username and password is actually present
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter a valid username or pasword.", Program.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the user needs a password reset
            var passwordUser = Program.authManager.GetUser(txtUsername.Text);
            if (passwordUser != null && passwordUser.GetSalt() == "0" && passwordUser.GetHash() == "0")
            {
                // set as active user
                Program.activeUser = passwordUser;

                // show the password reset window
                new ResetPassword().Show();
                Hide();

                // dont continue with the rest of the login
                return;
            }

            // check if the login details correspond to a created user
            var user = Program.authManager.AuthUser(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("You have entered an incorrect username or password.", Program.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the user is possibly a guest (unverified account)
            if (user.GetRole() == Authentication.Role.Guest)
            {
                MessageBox.Show("Your account has not been verified yet!\nPlease contact your manager to resolve the issue.", Program.title, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // set user as global static variable
            Program.activeUser = user;

            // clear login details
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

            // instantiate a new stock form and show it.
            new StockForm().Show();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // instantiate a new register form and show it.
            new RegisterForm().Show();

            // hide the login form as that is the main entry point of the application
            // we can not close it otherwise the application will exit
            Hide();
        }
    }
}