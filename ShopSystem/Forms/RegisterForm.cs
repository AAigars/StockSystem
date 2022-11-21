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
    }
}
