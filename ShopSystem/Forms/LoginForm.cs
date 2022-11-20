namespace ShopSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter a valid username or pasword.", Program.title);
                return;
            }

            var user = Program.authManager.AuthUser(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("You have entered an incorrect username or password.", Program.title);
                return;
            }

            MessageBox.Show("yooo");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // handle switching to register form
            // todo: global form handler? (prevent creating duplicate instances of forms)
        }
    }
}