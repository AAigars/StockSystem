namespace StockSystem.Forms
{
    public partial class UserManagementForm : Form
    {
        // stores the selected row in the DataGridView (dgvUsers_CellClick)
        private int selectedRow = -1;

        // stores if the user management form is open
        private bool isStockOpen = false;

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            // dont load form if no active user
            if (Program.activeUser == null)
            {
                MessageBox.Show("Failed to fetch user data, invalid login?", Program.title);
                Close();
                return;
            }

            // setup dgv columns
            dgvUsers.Columns.Add("firstName", "First Name");
            dgvUsers.Columns.Add("lastName", "Last Name");
            dgvUsers.Columns.Add("username", "Username");
            dgvUsers.Columns.Add("role", "Role");

            // import user data into dgv
            foreach (var user in Program.authManager.GetUsers())
            {
                dgvUsers.Rows.Add(new string[]
                {
                    user.GetFirstName(),
                    user.GetLastName(),
                    user.GetUsername(),
                    user.GetRole().ToString()
                });
            }

            // add roles to combobox
            foreach (var role in Enum.GetValues(typeof(Authentication.Role)))
            {
                cbRole.Items.Add(role);
            }

            // set label first name and last name
            tslName.Text = Program.activeUser.GetFirstName() + " " + Program.activeUser.GetLastName();
        }

        private void UserManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, UserManagementForm won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing the stock form will cause the program to remain open in the background.
            if (Program.loginForm != null && !Program.loginForm.Visible && !isStockOpen)
                Program.loginForm.Close();
        }

        private void tslUserManagement_Click(object sender, EventArgs e)
        {
            // load up the user management form
            var form = new StockForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = Location;
            form.Show();

            // prevent stock form from terminating program by closing LoginForm
            isStockOpen = true;

            // close the user management form
            Close();
        }

        private void tslSignOut_Click(object sender, EventArgs e)
        {
            // set the active user to null
            Program.activeUser = null;

            // load up the login form
            if (Program.loginForm != null)
                Program.loginForm.Show();

            // close the user management form
            Close();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // make sure the selected row is valid
            selectedRow = e.RowIndex;
            if (selectedRow == -1)
                return;

            // check if the cells have data stored in them
            // otherwise an exception will be thrown for an attempt to cast null values
            var cells = dgvUsers.Rows[selectedRow].Cells;
            if (cells["FirstName"].Value == null || cells["LastName"].Value == null ||
                cells["Username"].Value == null || cells["Role"].Value == null
            )
                return;

            // cast the object values from the cells to the required data type.
            txtFirstName.Text = Convert.ToString(cells["FirstName"].Value);
            txtLastName.Text = Convert.ToString(cells["LastName"].Value);
            cbRole.SelectedIndex = cbRole.FindString(Convert.ToString(cells["Role"].Value));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // make sure a row has been selected
            if (selectedRow == -1)
            {
                MessageBox.Show("You have not selected a row to update!", Program.title);
                return;
            }

            // grab the username from the cells
            var cell = dgvUsers.Rows[selectedRow].Cells["Username"].Value;
            if (cell == null) return;

            // get the user
            var user = Program.authManager.GetUser(cell.ToString());
            if (user == null) return;

            // update the user
            user.SetFirstName(txtFirstName.Text);
            user.SetLastName(txtLastName.Text);
            user.SetRole(Enum.Parse<Authentication.Role>(cbRole.SelectedItem.ToString()));

            // force update the user
            Program.authManager.SaveUsers();

            // update the cells
            var cells = dgvUsers.Rows[selectedRow].Cells;
            cells["FirstName"].Value = user.GetFirstName();
            cells["LastName"].Value = user.GetLastName();
            cells["Role"].Value = user.GetRole();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // make sure a row has been selected
            if (selectedRow == -1)
            {
                MessageBox.Show("You have not selected a row to delete!", Program.title);
                return;
            }

            // grab the username from the cells
            var cell = dgvUsers.Rows[selectedRow].Cells["Username"].Value;
            if (cell == null) return;

            // make sure that the logged in user isnt the same as the one being deleted
            if (Program.activeUser != null && Program.activeUser.GetUsername() == cell.ToString())
            {
                MessageBox.Show("You cannot delete your own account...!", Program.title);
                return;
            }

            // remove the user
            Program.authManager.RemoveUser(cell.ToString());

            // remove the user from the dgv
            dgvUsers.Rows.RemoveAt(selectedRow);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // make sure a row has been selected
            if (selectedRow == -1)
            {
                MessageBox.Show("You have not selected a row to reset the password for!", Program.title);
                return;
            }

            // grab the username from the cells
            var cell = dgvUsers.Rows[selectedRow].Cells["Username"].Value;
            if (cell == null) return;

            // get the user
            var user = Program.authManager.GetUser(cell.ToString());
            if (user == null) return;

            // set the hash and salt to 0 to indicate a password reset
            user.SetSalt("0");
            user.SetHash("0");

            // save the users details
            Program.authManager.SaveUsers();
            MessageBox.Show("The password for the user has been reset.\nOnce they attempt to login they will be asked for a new password!", 
                Program.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // clear the dgv rows
            dgvUsers.Rows.Clear();

            // insert the rows
            foreach (var user in Program.authManager.GetUsers())
            {
                // check if the product name contains the search
                if (!user.GetUsername().Contains(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase)) continue;

                // insert the users
                dgvUsers.Rows.Add(new string[]
                {
                    user.GetFirstName(),
                    user.GetLastName(),
                    user.GetUsername(),
                    user.GetRole().ToString()
                });
            }
        }
    }
}
