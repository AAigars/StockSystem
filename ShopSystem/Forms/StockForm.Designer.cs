namespace StockSystem.Forms
{
    partial class StockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbViewProducts = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tsActions = new System.Windows.Forms.ToolStrip();
            this.tslName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslUserManagement = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSignOut = new System.Windows.Forms.ToolStripLabel();
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbProductControls = new System.Windows.Forms.GroupBox();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.gbViewProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tsActions.SuspendLayout();
            this.gbProductInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.gbProductControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbViewProducts
            // 
            this.gbViewProducts.Controls.Add(this.dgvProducts);
            this.gbViewProducts.Location = new System.Drawing.Point(12, 28);
            this.gbViewProducts.Name = "gbViewProducts";
            this.gbViewProducts.Size = new System.Drawing.Size(459, 256);
            this.gbViewProducts.TabIndex = 0;
            this.gbViewProducts.TabStop = false;
            this.gbViewProducts.Text = "View Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 20);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(447, 230);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(78, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(6, 47);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(138, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tsActions
            // 
            this.tsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslName,
            this.toolStripSeparator1,
            this.tslUserManagement,
            this.toolStripSeparator2,
            this.tslSignOut});
            this.tsActions.Location = new System.Drawing.Point(0, 0);
            this.tsActions.Name = "tsActions";
            this.tsActions.Size = new System.Drawing.Size(639, 25);
            this.tsActions.TabIndex = 2;
            this.tsActions.Text = "tsActions";
            // 
            // tslName
            // 
            this.tslName.Name = "tslName";
            this.tslName.Size = new System.Drawing.Size(103, 22);
            this.tslName.Text = "Aigars Aldermanis";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslUserManagement
            // 
            this.tslUserManagement.Name = "tslUserManagement";
            this.tslUserManagement.Size = new System.Drawing.Size(104, 22);
            this.tslUserManagement.Text = "User Management";
            this.tslUserManagement.Click += new System.EventHandler(this.tslUserManagement_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslSignOut
            // 
            this.tslSignOut.Name = "tslSignOut";
            this.tslSignOut.Size = new System.Drawing.Size(53, 22);
            this.tslSignOut.Text = "Sign Out";
            this.tslSignOut.Click += new System.EventHandler(this.tslSignOut_Click);
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.btnSelect);
            this.gbProductInformation.Controls.Add(this.lblImage);
            this.gbProductInformation.Controls.Add(this.nupQuantity);
            this.gbProductInformation.Controls.Add(this.lblQuantity);
            this.gbProductInformation.Controls.Add(this.txtName);
            this.gbProductInformation.Controls.Add(this.lblName);
            this.gbProductInformation.Location = new System.Drawing.Point(477, 28);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(150, 174);
            this.gbProductInformation.TabIndex = 3;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Product Information";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(6, 138);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(138, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(6, 120);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(40, 15);
            this.lblImage.TabIndex = 4;
            this.lblImage.Text = "Image";
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(6, 89);
            this.nupQuantity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(138, 23);
            this.nupQuantity.TabIndex = 3;
            this.nupQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 71);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 38);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Potato";
            this.txtName.Size = new System.Drawing.Size(138, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // gbProductControls
            // 
            this.gbProductControls.Controls.Add(this.btnRemove);
            this.gbProductControls.Controls.Add(this.btnUpdate);
            this.gbProductControls.Controls.Add(this.btnAdd);
            this.gbProductControls.Location = new System.Drawing.Point(477, 208);
            this.gbProductControls.Name = "gbProductControls";
            this.gbProductControls.Size = new System.Drawing.Size(150, 76);
            this.gbProductControls.TabIndex = 4;
            this.gbProductControls.TabStop = false;
            this.gbProductControls.Text = "Product Controls";
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "cat.png";
            this.ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            this.ofdImage.Title = "Select a Product Image";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 298);
            this.Controls.Add(this.gbProductControls);
            this.Controls.Add(this.gbProductInformation);
            this.Controls.Add(this.tsActions);
            this.Controls.Add(this.gbViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockForm";
            this.Text = "Stock System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockForm_FormClosed);
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.gbViewProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tsActions.ResumeLayout(false);
            this.tsActions.PerformLayout();
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.gbProductControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbViewProducts;
        private ToolStrip tsActions;
        private ToolStripLabel tslName;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel tslSignOut;
        private Button btnAdd;
        private DataGridView dgvProducts;
        private Button btnRemove;
        private Button btnUpdate;
        private GroupBox gbProductInformation;
        private GroupBox gbProductControls;
        private Button btnSelect;
        private Label lblImage;
        private NumericUpDown nupQuantity;
        private Label lblQuantity;
        private TextBox txtName;
        private Label lblName;
        private OpenFileDialog ofdImage;
        private ToolStripLabel tslUserManagement;
        private ToolStripSeparator toolStripSeparator2;
    }
}