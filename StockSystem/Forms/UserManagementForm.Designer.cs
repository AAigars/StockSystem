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
            this.tsActions.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsActions.Size = new System.Drawing.Size(913, 30);
            this.tsActions.TabIndex = 3;
            this.tsActions.Text = "tsActions";
            // 
            // tslName
            // 
            this.tslName.Name = "tslName";
            this.tslName.Size = new System.Drawing.Size(156, 25);
            this.tslName.Text = "Aigars Aldermanis";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tslUserManagement
            // 
            this.tslUserManagement.Name = "tslUserManagement";
            this.tslUserManagement.Size = new System.Drawing.Size(117, 25);
            this.tslUserManagement.Text = "Stock System";
            this.tslUserManagement.Click += new System.EventHandler(this.tslUserManagement_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // tslSignOut
            // 
            this.tslSignOut.Name = "tslSignOut";
            this.tslSignOut.Size = new System.Drawing.Size(82, 25);
            this.tslSignOut.Text = "Sign Out";
            this.tslSignOut.Click += new System.EventHandler(this.tslSignOut_Click);
            // 
            // gbViewProducts
            // 
            this.gbViewProducts.Controls.Add(this.dgvUsers);
            this.gbViewProducts.Location = new System.Drawing.Point(17, 47);
            this.gbViewProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbViewProducts.Name = "gbViewProducts";
            this.gbViewProducts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbViewProducts.Size = new System.Drawing.Size(656, 427);
            this.gbViewProducts.TabIndex = 4;
            this.gbViewProducts.TabStop = false;
            this.gbViewProducts.Text = "View Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(9, 33);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(639, 383);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // gbProductControls
            // 
            this.gbProductControls.Controls.Add(this.btnReset);
            this.gbProductControls.Controls.Add(this.btnRemove);
            this.gbProductControls.Controls.Add(this.btnUpdate);
            this.gbProductControls.Location = new System.Drawing.Point(681, 347);
            this.gbProductControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductControls.Name = "gbProductControls";
            this.gbProductControls.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductControls.Size = new System.Drawing.Size(214, 127);
            this.gbProductControls.TabIndex = 6;
            this.gbProductControls.TabStop = false;
            this.gbProductControls.Text = "User Controls";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 78);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(197, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(111, 37);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 38);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 37);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 38);
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
            this.gbProductInformation.Location = new System.Drawing.Point(681, 47);
            this.gbProductInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductInformation.Size = new System.Drawing.Size(214, 290);
            this.gbProductInformation.TabIndex = 5;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "User Information";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(9, 230);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(195, 33);
            this.cbRole.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(9, 148);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Aldermanis";
            this.txtLastName.Size = new System.Drawing.Size(195, 31);
            this.txtLastName.TabIndex = 5;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(9, 200);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(46, 25);
            this.lblImage.TabIndex = 4;
            this.lblImage.Text = "Role";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(9, 118);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(95, 25);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(9, 63);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Aigars";
            this.txtFirstName.Size = new System.Drawing.Size(195, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 497);
            this.Controls.Add(this.gbProductControls);
            this.Controls.Add(this.gbProductInformation);
            this.Controls.Add(this.gbViewProducts);
            this.Controls.Add(this.tsActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.tsActions.ResumeLayout(false);
            this.tsActions.PerformLayout();
            this.gbViewProducts.ResumeLayout(false);
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
    }
}