namespace StockSystem.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // validation check - make sure that the username and password is actually present
            if
            (
                txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty ||
                txtUsername.Text == string.Empty || txtPassword.Text == string.Empty
            )
            {
                MessageBox.Show("The information which has been provided is not valid.", Program.title);
                return;
            }

            // create a user and store them in a file
            var user = Program.authManager.CreateUser(txtFirstName.Text, txtLastName.Text, txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("The username has already been used.", Program.title);
                return;
            }

            // tell the user the user has been created!
            MessageBox.Show("The user has been registered!", Program.title);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // wont ever be null anyway, but VS likes to throw a nice null warning
            if (Program.loginForm != null)
                Program.loginForm.Show();
            Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, RegisterForm won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing the register form will cause the program to remain open in the background.
            if (Program.loginForm != null && !Program.loginForm.Visible)
                Program.loginForm.Close();
        }
    }
}
