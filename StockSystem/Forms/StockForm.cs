namespace StockSystem.Forms
{
    public partial class StockForm : Form
    {
        // stores the image path from the OpenFileDialog (btnSelect_Click)
        private string? imagePath = null;

        // stores the selected row in the DataGridView (dgvProducts_CellClick)
        private int selectedRow = -1;

        // stores if the user management form is open
        private bool isUserManagementOpen = false;

        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // dont load form if no active user
            if (Program.activeUser == null)
            {
                MessageBox.Show("Failed to fetch user data, invalid login?", Program.title);
                Close();
                return;
            }

            // setup dgv columns
            var _image = new DataGridViewImageColumn();
            _image.Name = "Image";
            _image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            _image.DefaultCellStyle.NullValue = null;
            dgvProducts.Columns.Add(_image);

            // hack to get around DataGridViewImageColumn displaying a X cross
            // https://stackoverflow.com/a/68331322
            dgvProducts.Rows[0].Cells["Image"].Value = null;

            // create rest of columns
            dgvProducts.Columns.Add("name", "Name");
            dgvProducts.Columns.Add("quantity", "Quantity");

            // import stock manager data into dgv
            foreach (var product in Program.stockManager.GetProducts())
            {
                // handle products with images
                var image = product.GetImage();
                dgvProducts.Rows.Add(new object[] {
                    image != null ? Image.FromFile(image) : null,
                    product.GetName(),
                    product.GetQuantity().ToString()
                });
            }

            // set label first name and last name
            tslName.Text = Program.activeUser.GetFirstName() + " " + Program.activeUser.GetLastName();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // show open file dialog and save file path
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofdImage.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validation check on input
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please specify the name for the product.", Program.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // attempt to add a new product in the stock manager, which will then be saved to a file.
            var product = Program.stockManager.AddProduct(
                txtName.Text, Convert.ToInt32(nupQuantity.Value), imagePath);

            // AddProduct will only return null, if the product name has already been used.
            if (product == null)
            {
                MessageBox.Show("Product with this name already exists!", Program.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // add the new product to the DataGridView
            var image = product.GetImage();
            dgvProducts.Rows.Add(new object[] {
                image != null ? Image.FromFile(image) : null,
                product.GetName(),
                product.GetQuantity().ToString()
            });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // make sure a row has been selected
            if (selectedRow == -1)
            {
                MessageBox.Show("You have not selected a row to update!", Program.title);
                return;
            }

            // check for valid product name cell
            var cell = dgvProducts.Rows[selectedRow].Cells["Name"].Value;
            if (cell == null) return;

            // get the product object from the stock manager
            var product = Program.stockManager.GetProduct(cell.ToString());
            if (product == null) return;

            // set the new details
            if (imagePath != null) product.SetImage(imagePath);
            product.SetName(txtName.Text);
            product.SetQuantity(Convert.ToInt32(nupQuantity.Value));

            // force products to be saved
            Program.stockManager.SaveProducts();

            // update the product information text boxes to match the cell values
            var cells = dgvProducts.Rows[selectedRow].Cells;
            cells["Image"].Value = product.GetImage() != null ? Image.FromFile(product.GetImage()) : cells[0].Value; // only update image if new one selected
            cells["Name"].Value = product.GetName();
            cells["Quantity"].Value = product.GetQuantity();

            // reset image path
            imagePath = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // make sure a row has been selected
            if (selectedRow == -1)
            {
                MessageBox.Show("You have not selected a row to delete!", Program.title);
                return;
            }

            // make sure the name cell is valid
            var cell = dgvProducts.Rows[selectedRow].Cells["Name"].Value;
            if (cell == null) return;

            // remove from the stock manager
            Program.stockManager.RemoveProduct(cell.ToString());

            // remove the row which is at the selected index
            dgvProducts.Rows.RemoveAt(selectedRow);
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, StockForm won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing the stock form will cause the program to remain open in the background.
            if (Program.loginForm != null && !Program.loginForm.Visible && !isUserManagementOpen)
                Program.loginForm.Close();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // make sure the selected row is valid
            selectedRow = e.RowIndex;
            if (selectedRow == -1)
                return;

            // check if the cells have data stored in them
            // otherwise an exception will be thrown for an attempt to cast null values
            var cells = dgvProducts.Rows[selectedRow].Cells;
            if (cells["Name"].Value == null || cells["Quantity"].Value == null)
                return;

            // cast the object values from the cells to the required data type.
            txtName.Text = Convert.ToString(cells["Name"].Value);
            nupQuantity.Value = Convert.ToInt32(cells["Quantity"].Value);
        }

        private void tslUserManagement_Click(object sender, EventArgs e)
        {
            // check if the user is the correct role
            if (Program.activeUser == null || Program.activeUser.GetRole() != Authentication.Role.Manager)
            {
                MessageBox.Show("You do not have enough privileges to access this menu!", Program.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // load up the user management form
            var form = new UserManagementForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = Location;
            form.Show();

            // prevent stock form from terminating program by closing LoginForm
            isUserManagementOpen = true;

            // close the stock form
            Close();
        }

        private void tslSignOut_Click(object sender, EventArgs e)
        {
            // set the active user to null
            Program.activeUser = null;

            // load up the login form
            if (Program.loginForm != null)
                Program.loginForm.Show();

            // close the stock form
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // clear the dgv rows
            dgvProducts.Rows.Clear();

            // hack to get around DataGridViewImageColumn displaying a X cross
            // https://stackoverflow.com/a/68331322
            dgvProducts.Rows[0].Cells["Image"].Value = null;

            // insert the rows
            foreach (var product in Program.stockManager.GetProducts())
            {
                // check if the product name contains the search
                if (!product.GetName().Contains(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase)) continue;

                // handle products with images
                var image = product.GetImage();
                dgvProducts.Rows.Add(new object[] {
                    image != null ? Image.FromFile(image) : null,
                    product.GetName(),
                    product.GetQuantity().ToString()
                });
            }
        }
    }
}
