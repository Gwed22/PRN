namespace WinAppAdmin
{
    partial class frmBlogManagement
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvBlogList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBlogID = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbBlogID = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlogList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(552, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvBlogList
            // 
            this.dgvBlogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlogList.Location = new System.Drawing.Point(45, 235);
            this.dgvBlogList.Name = "dgvBlogList";
            this.dgvBlogList.ReadOnly = true;
            this.dgvBlogList.RowHeadersWidth = 62;
            this.dgvBlogList.RowTemplate.Height = 33;
            this.dgvBlogList.Size = new System.Drawing.Size(850, 225);
            this.dgvBlogList.TabIndex = 52;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(783, 488);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 34);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(783, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(305, 181);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 34);
            this.btnNew.TabIndex = 49;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(630, 42);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(265, 31);
            this.txtCategory.TabIndex = 45;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(177, 101);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(265, 31);
            this.txtTitle.TabIndex = 43;
            // 
            // txtBlogID
            // 
            this.txtBlogID.Location = new System.Drawing.Point(177, 45);
            this.txtBlogID.Name = "txtBlogID";
            this.txtBlogID.Size = new System.Drawing.Size(265, 31);
            this.txtBlogID.TabIndex = 42;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(515, 101);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(49, 25);
            this.lbDate.TabIndex = 41;
            this.lbDate.Text = "Date";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(515, 45);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(84, 25);
            this.lbCategory.TabIndex = 39;
            this.lbCategory.Text = "Category";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(45, 101);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(44, 25);
            this.lbTitle.TabIndex = 37;
            this.lbTitle.Text = "Title";
            // 
            // lbBlogID
            // 
            this.lbBlogID.AutoSize = true;
            this.lbBlogID.Location = new System.Drawing.Point(45, 45);
            this.lbBlogID.Name = "lbBlogID";
            this.lbBlogID.Size = new System.Drawing.Size(71, 25);
            this.lbBlogID.TabIndex = 36;
            this.lbBlogID.Text = "Blog ID";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(630, 99);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(265, 31);
            this.txtDate.TabIndex = 54;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(45, 181);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 34);
            this.btnLoad.TabIndex = 55;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmBlogManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 549);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvBlogList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBlogID);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbBlogID);
            this.Name = "frmBlogManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blog Management";
            this.Load += new System.EventHandler(this.frmBlogManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlogList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvBlogList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBlogID;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbBlogID;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Button btnLoad;
    }
}