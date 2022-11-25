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
                MessageBox.Show("Enter a valid username or pasword.", Program.title);
                return;
            }

            // check if the login details correspond to a created user
            var user = Program.authManager.AuthUser(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("You have entered an incorrect username or password.", Program.title);
                return;
            }

            // set user as global static variable
            Program.activeUser = user;

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