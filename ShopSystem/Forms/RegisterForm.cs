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
                MessageBox.Show("Enter a valid username or pasword.", "Shop System");
                return;
            }

            var user = Program.authManager.CreateUser(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("The username has already been used.", "Shop System");
                return;
            }

            MessageBox.Show("The user has been registered!", "Shop System");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
