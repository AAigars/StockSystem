using ShopSystem;
using System.Xml.Linq;

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
            foreach (var role in Enum.GetValues(typeof(ShopSystem.Authentication.Role)))
            {
                cbRole.Items.Add(role);
            }
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
            new StockForm().Show();

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
    }
}
