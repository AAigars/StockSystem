namespace ShopSystem
{
    public partial class StockForm : Form
    {
        private string imagePath = string.Empty;
        private int selectedRow = -1;

        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // setup dgv columns
            var image = new DataGridViewImageColumn();
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvProducts.Columns.Add(image);

            dgvProducts.Columns.Add("name", "Name");
            dgvProducts.Columns.Add("quantity", "Quantity");

            // import stock manager data into dgv
            foreach (var product in Program.stockManager.GetProducts())
            {
                // handle stored products.
                dgvProducts.Rows.Add(new object[] {
                    Image.FromFile(imagePath),
                    product.GetName(),
                    product.GetQuantity().ToString()
                });
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofdImage.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = Program.stockManager.AddProduct(
                txtName.Text, Convert.ToInt32(nupQuantity.Value));

            dgvProducts.Rows.Add(new object[] {
                Image.FromFile(imagePath),
                product.GetName(),
                product.GetQuantity().ToString()
            });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("You have not selected a row to delete.", Program.title);
                return;
            }

            dgvProducts.Rows.RemoveAt(selectedRow);
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway
            if (Program.loginForm != null)
                Program.loginForm.Close();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow == -1)
                return;

            var cells = dgvProducts.Rows[selectedRow].Cells;
            if (cells[1].Value == null || cells[2].Value == null)
                return;

            txtName.Text = cells[1].Value.ToString();
            nupQuantity.Value = Convert.ToInt32(cells[2].Value);
        }
    }
}
