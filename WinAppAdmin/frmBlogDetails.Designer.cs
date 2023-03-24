namespace WinAppAdmin
{
    partial class frmBlogDetails
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
            txtDate = new System.Windows.Forms.DateTimePicker();
            txtTitle = new System.Windows.Forms.TextBox();
            lbDate = new System.Windows.Forms.Label();
            lbCategory = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            txtDesc = new System.Windows.Forms.TextBox();
            txtImage = new System.Windows.Forms.TextBox();
            lbDescription = new System.Windows.Forms.Label();
            lbImage = new System.Windows.Forms.Label();
            txtContent = new System.Windows.Forms.TextBox();
            lbContent = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtCategory = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(129, 166);
            txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(248, 27);
            txtDate.TabIndex = 62;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(129, 66);
            txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(248, 27);
            txtTitle.TabIndex = 60;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new System.Drawing.Point(27, 173);
            lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new System.Drawing.Size(41, 20);
            lbDate.TabIndex = 58;
            lbDate.Text = "Date";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(27, 126);
            lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(69, 20);
            lbCategory.TabIndex = 57;
            lbCategory.Text = "Category";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(27, 69);
            lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(38, 20);
            lbTitle.TabIndex = 56;
            lbTitle.Text = "Title";
            // 
            // txtDesc
            // 
            txtDesc.Location = new System.Drawing.Point(129, 278);
            txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDesc.Size = new System.Drawing.Size(248, 146);
            txtDesc.TabIndex = 66;
            // 
            // txtImage
            // 
            txtImage.Location = new System.Drawing.Point(129, 223);
            txtImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtImage.Name = "txtImage";
            txtImage.Size = new System.Drawing.Size(248, 27);
            txtImage.TabIndex = 65;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(27, 280);
            lbDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(85, 20);
            lbDescription.TabIndex = 64;
            lbDescription.Text = "Description";
            // 
            // lbImage
            // 
            lbImage.AutoSize = true;
            lbImage.Location = new System.Drawing.Point(27, 226);
            lbImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbImage.Name = "lbImage";
            lbImage.Size = new System.Drawing.Size(51, 20);
            lbImage.TabIndex = 63;
            lbImage.Text = "Image";
            // 
            // txtContent
            // 
            txtContent.Location = new System.Drawing.Point(411, 66);
            txtContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtContent.Size = new System.Drawing.Size(357, 352);
            txtContent.TabIndex = 68;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new System.Drawing.Point(411, 27);
            lbContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(61, 20);
            lbContent.TabIndex = 67;
            lbContent.Text = "Content";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(678, 445);
            btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(90, 27);
            btnCancel.TabIndex = 70;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(411, 445);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(90, 27);
            btnSave.TabIndex = 69;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCategory
            // 
            txtCategory.FormattingEnabled = true;
            txtCategory.Items.AddRange(new object[] { "1- Politics", "2 - Economy", "3 - Culture", "4 - Society", "5 - Education", "6 - Medical" });
            txtCategory.Location = new System.Drawing.Point(129, 123);
            txtCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new System.Drawing.Size(248, 28);
            txtCategory.TabIndex = 71;
            // 
            // frmBlogDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(788, 482);
            Controls.Add(txtCategory);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtContent);
            Controls.Add(lbContent);
            Controls.Add(txtDesc);
            Controls.Add(txtImage);
            Controls.Add(lbDescription);
            Controls.Add(lbImage);
            Controls.Add(txtDate);
            Controls.Add(txtTitle);
            Controls.Add(lbDate);
            Controls.Add(lbCategory);
            Controls.Add(lbTitle);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmBlogDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBlogDetails";
            Load += frmBlogDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox txtCategory;
    }
}