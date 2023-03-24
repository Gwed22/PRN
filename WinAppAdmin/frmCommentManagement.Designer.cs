namespace WinAppAdmin
{
    partial class frmCommentManagement
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
            txtContext = new System.Windows.Forms.TextBox();
            lbContext = new System.Windows.Forms.Label();
            dgvCommentList = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            txtAccountName = new System.Windows.Forms.TextBox();
            txtBlogID = new System.Windows.Forms.TextBox();
            txtCommentID = new System.Windows.Forms.TextBox();
            lbAccountName = new System.Windows.Forms.Label();
            lbBlogID = new System.Windows.Forms.Label();
            lbCommentID = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            txtAccountID = new System.Windows.Forms.TextBox();
            lbAccountID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCommentList).BeginInit();
            SuspendLayout();
            // 
            // txtContext
            // 
            txtContext.Location = new System.Drawing.Point(526, 29);
            txtContext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtContext.Multiline = true;
            txtContext.Name = "txtContext";
            txtContext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtContext.Size = new System.Drawing.Size(300, 165);
            txtContext.TabIndex = 66;
            // 
            // lbContext
            // 
            lbContext.AutoSize = true;
            lbContext.Location = new System.Drawing.Point(450, 29);
            lbContext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbContext.Name = "lbContext";
            lbContext.Size = new System.Drawing.Size(60, 20);
            lbContext.TabIndex = 65;
            lbContext.Text = "Context";
            // 
            // dgvCommentList
            // 
            dgvCommentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommentList.Location = new System.Drawing.Point(31, 271);
            dgvCommentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dgvCommentList.Name = "dgvCommentList";
            dgvCommentList.ReadOnly = true;
            dgvCommentList.RowHeadersWidth = 62;
            dgvCommentList.RowTemplate.Height = 33;
            dgvCommentList.Size = new System.Drawing.Size(795, 180);
            dgvCommentList.TabIndex = 64;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(736, 468);
            btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(90, 27);
            btnClose.TabIndex = 63;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(409, 468);
            btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(90, 27);
            btnDelete.TabIndex = 62;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(31, 468);
            btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(90, 27);
            btnLoad.TabIndex = 61;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new System.Drawing.Point(151, 167);
            txtAccountName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new System.Drawing.Size(274, 27);
            txtAccountName.TabIndex = 60;
            // 
            // txtBlogID
            // 
            txtBlogID.Location = new System.Drawing.Point(151, 74);
            txtBlogID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtBlogID.Name = "txtBlogID";
            txtBlogID.Size = new System.Drawing.Size(274, 27);
            txtBlogID.TabIndex = 59;
            // 
            // txtCommentID
            // 
            txtCommentID.Location = new System.Drawing.Point(151, 29);
            txtCommentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtCommentID.Name = "txtCommentID";
            txtCommentID.Size = new System.Drawing.Size(274, 27);
            txtCommentID.TabIndex = 58;
            // 
            // lbAccountName
            // 
            lbAccountName.AutoSize = true;
            lbAccountName.Location = new System.Drawing.Point(31, 169);
            lbAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbAccountName.Name = "lbAccountName";
            lbAccountName.Size = new System.Drawing.Size(107, 20);
            lbAccountName.TabIndex = 57;
            lbAccountName.Text = "Account Name";
            // 
            // lbBlogID
            // 
            lbBlogID.AutoSize = true;
            lbBlogID.Location = new System.Drawing.Point(31, 74);
            lbBlogID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbBlogID.Name = "lbBlogID";
            lbBlogID.Size = new System.Drawing.Size(59, 20);
            lbBlogID.TabIndex = 56;
            lbBlogID.Text = "Blog ID";
            // 
            // lbCommentID
            // 
            lbCommentID.AutoSize = true;
            lbCommentID.Location = new System.Drawing.Point(31, 29);
            lbCommentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbCommentID.Name = "lbCommentID";
            lbCommentID.Size = new System.Drawing.Size(93, 20);
            lbCommentID.TabIndex = 55;
            lbCommentID.Text = "Comment ID";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(31, 223);
            txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(213, 27);
            txtSearch.TabIndex = 67;
            txtSearch.Text = "  User name....";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(259, 223);
            btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(90, 27);
            btnSearch.TabIndex = 68;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new System.Drawing.Point(151, 116);
            txtAccountID.Margin = new System.Windows.Forms.Padding(2);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new System.Drawing.Size(274, 27);
            txtAccountID.TabIndex = 70;
            // 
            // lbAccountID
            // 
            lbAccountID.AutoSize = true;
            lbAccountID.Location = new System.Drawing.Point(31, 116);
            lbAccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbAccountID.Name = "lbAccountID";
            lbAccountID.Size = new System.Drawing.Size(82, 20);
            lbAccountID.TabIndex = 69;
            lbAccountID.Text = "Account ID";
            // 
            // frmCommentManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(860, 521);
            Controls.Add(txtAccountID);
            Controls.Add(lbAccountID);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtContext);
            Controls.Add(lbContext);
            Controls.Add(dgvCommentList);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(txtAccountName);
            Controls.Add(txtBlogID);
            Controls.Add(txtCommentID);
            Controls.Add(lbAccountName);
            Controls.Add(lbBlogID);
            Controls.Add(lbCommentID);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmCommentManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCommentManagement";
            Load += frmCommentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Label lbContext;
        private System.Windows.Forms.DataGridView dgvCommentList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtBlogID;
        private System.Windows.Forms.TextBox txtCommentID;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label lbBlogID;
        private System.Windows.Forms.Label lbCommentID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label lbAccountID;
    }
}