namespace ShopSystem
{
    public partial class StockForm : Form
    {
        private string? imagePath = null;
        private int selectedRow = -1;

        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // setup dgv columns
            var _image = new DataGridViewImageColumn();
            _image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            _image.DefaultCellStyle.NullValue = null;
            dgvProducts.Columns.Add(_image);

            // hack to get around DataGridViewImageColumn displaying a X cross
            // https://stackoverflow.com/a/68331322
            dgvProducts.Rows[0].Cells[0].Value = null;

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
            var product = Program.stockManager.AddProduct(
                txtName.Text, Convert.ToInt32(nupQuantity.Value), imagePath);

            if (product == null)
            {
                MessageBox.Show("Product with this name already exists!", Program.title);
                return;
            }

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
            var cell = dgvProducts.Rows[selectedRow].Cells[1].Value;
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
            cells[0].Value = product.GetImage() != null ? Image.FromFile(product.GetImage()) : cells[0].Value; // only update image if new one selected
            cells[1].Value = product.GetName();
            cells[2].Value = product.GetQuantity();

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
            var cell = dgvProducts.Rows[selectedRow].Cells[1].Value;
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
            if (Program.loginForm != null)
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
            if (cells[1].Value == null || cells[2].Value == null)
                return;

            // cast the object values from the cells to the required data type.
            txtName.Text = Convert.ToString(cells[1].Value);
            nupQuantity.Value = Convert.ToInt32(cells[2].Value);
        }
    }
}
