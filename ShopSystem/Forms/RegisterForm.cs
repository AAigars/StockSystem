namespace ShopSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter a valid username or pasword.", Program.title);
                return;
            }

            var user = Program.authManager.CreateUser(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("The username has already been used.", Program.title);
                return;
            }

            MessageBox.Show("The user has been registered!", Program.title);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.loginForm.Show();
            Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, RegisterForm won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing the register form will cause the program to remain open in the background.
            if (Program.loginForm != null)
                Program.loginForm.Close();
        }
    }
}
