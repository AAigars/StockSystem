namespace StockSystem.Forms
{
    partial class UserManagementForm
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
            this.tsActions = new System.Windows.Forms.ToolStrip();
            this.tslName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslUserManagement = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSignOut = new System.Windows.Forms.ToolStripLabel();
            this.gbViewProducts = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbProductControls = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tsActions.SuspendLayout();
            this.gbViewProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbProductControls.SuspendLayout();
            this.gbProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsActions
            // 
            this.tsActions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslName,
            this.toolStripSeparator1,
            this.tslUserManagement,
            this.toolStripSeparator2,
            this.tslSignOut});
            this.tsActions.Location = new System.Drawing.Point(0, 0);
            this.tsActions.Name = "tsActions";
            this.tsActions.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsActions.Size = new System.Drawing.Size(639, 25);
            this.tsActions.TabIndex = 3;
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
            this.tslUserManagement.Size = new System.Drawing.Size(77, 22);
            this.tslUserManagement.Text = "Stock System";
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
            // gbViewProducts
            // 
            this.gbViewProducts.Controls.Add(this.btnSearch);
            this.gbViewProducts.Controls.Add(this.txtSearch);
            this.gbViewProducts.Controls.Add(this.dgvUsers);
            this.gbViewProducts.Location = new System.Drawing.Point(12, 28);
            this.gbViewProducts.Name = "gbViewProducts";
            this.gbViewProducts.Size = new System.Drawing.Size(459, 256);
            this.gbViewProducts.TabIndex = 4;
            this.gbViewProducts.TabStop = false;
            this.gbViewProducts.Text = "View Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 46);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(447, 204);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // gbProductControls
            // 
            this.gbProductControls.Controls.Add(this.btnReset);
            this.gbProductControls.Controls.Add(this.btnRemove);
            this.gbProductControls.Controls.Add(this.btnUpdate);
            this.gbProductControls.Location = new System.Drawing.Point(477, 208);
            this.gbProductControls.Name = "gbProductControls";
            this.gbProductControls.Size = new System.Drawing.Size(150, 76);
            this.gbProductControls.TabIndex = 6;
            this.gbProductControls.TabStop = false;
            this.gbProductControls.Text = "User Controls";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 47);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(78, 22);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(66, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.cbRole);
            this.gbProductInformation.Controls.Add(this.txtLastName);
            this.gbProductInformation.Controls.Add(this.lblImage);
            this.gbProductInformation.Controls.Add(this.lblQuantity);
            this.gbProductInformation.Controls.Add(this.txtFirstName);
            this.gbProductInformation.Controls.Add(this.lblName);
            this.gbProductInformation.Location = new System.Drawing.Point(477, 28);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(150, 174);
            this.gbProductInformation.TabIndex = 5;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "User Information";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(6, 138);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(138, 23);
            this.cbRole.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 89);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Aldermanis";
            this.txtLastName.Size = new System.Drawing.Size(138, 23);
            this.txtLastName.TabIndex = 5;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(6, 120);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(30, 15);
            this.lblImage.TabIndex = 4;
            this.lblImage.Text = "Role";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 71);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 15);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Aigars";
            this.txtFirstName.Size = new System.Drawing.Size(138, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Username";
            this.txtSearch.Size = new System.Drawing.Size(341, 23);
            this.txtSearch.TabIndex = 7;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 298);
            this.Controls.Add(this.gbProductControls);
            this.Controls.Add(this.gbProductInformation);
            this.Controls.Add(this.gbViewProducts);
            this.Controls.Add(this.tsActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.tsActions.ResumeLayout(false);
            this.tsActions.PerformLayout();
            this.gbViewProducts.ResumeLayout(false);
            this.gbViewProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbProductControls.ResumeLayout(false);
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsActions;
        private ToolStripLabel tslName;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel tslUserManagement;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel tslSignOut;
        private GroupBox gbViewProducts;
        private DataGridView dgvUsers;
        private GroupBox gbProductControls;
        private Button btnRemove;
        private Button btnUpdate;
        private GroupBox gbProductInformation;
        private Label lblImage;
        private Label lblQuantity;
        private TextBox txtFirstName;
        private Label lblName;
        private TextBox txtLastName;
        private ComboBox cbRole;
        private Button btnReset;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}