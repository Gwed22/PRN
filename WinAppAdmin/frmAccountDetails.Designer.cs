namespace WinAppAdmin
{
    partial class frmAccountDetails
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
            txtPassword = new System.Windows.Forms.TextBox();
            txtRoleName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtFullName = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            lbRoleName = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPhone = new System.Windows.Forms.Label();
            lbFullName = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(156, 166);
            txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(324, 27);
            txtPassword.TabIndex = 41;
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new System.Drawing.Point(156, 208);
            txtRoleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new System.Drawing.Size(324, 27);
            txtRoleName.TabIndex = 40;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(156, 121);
            txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(324, 27);
            txtEmail.TabIndex = 39;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(156, 74);
            txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(324, 27);
            txtPhone.TabIndex = 38;
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(156, 31);
            txtFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(324, 27);
            txtFullName.TabIndex = 37;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(50, 168);
            lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 35;
            lbPassword.Text = "Password";
            // 
            // lbRoleName
            // 
            lbRoleName.AutoSize = true;
            lbRoleName.Location = new System.Drawing.Point(50, 210);
            lbRoleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbRoleName.Name = "lbRoleName";
            lbRoleName.Size = new System.Drawing.Size(83, 20);
            lbRoleName.TabIndex = 34;
            lbRoleName.Text = "Role Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(50, 123);
            lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 33;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(50, 74);
            lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(50, 20);
            lbPhone.TabIndex = 32;
            lbPhone.Text = "Phone";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new System.Drawing.Point(50, 31);
            lbFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new System.Drawing.Size(76, 20);
            lbFullName.TabIndex = 31;
            lbFullName.Text = "Full Name";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(390, 257);
            btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(90, 27);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(156, 257);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(90, 27);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAccountDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(530, 307);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtRoleName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(lbPassword);
            Controls.Add(lbRoleName);
            Controls.Add(lbEmail);
            Controls.Add(lbPhone);
            Controls.Add(lbFullName);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmAccountDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Account Details";
            Load += frmAccountDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRoleName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}