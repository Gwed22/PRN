using Final.Business.BusinessObject;
using Final.Lib.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAdmin
{
    public partial class frmAccountDetails : Form
    {

        public IAccountRepository AccountRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // False = insert; True = update
        public Account AccountInfo { get; set; }
        public frmAccountDetails()
        {
            InitializeComponent();
        }

        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                // Show account info to update
                txtFullName.Text = AccountInfo.FullName;
                txtPhone.Text = AccountInfo.Phone;
                txtEmail.Text = AccountInfo.Email;
                txtPassword.Text = AccountInfo.Password;
                txtRoleName.Text = AccountInfo.RoleName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var acc = new Account
                {
                    AccountId = 0,
                    FullName = txtFullName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    RoleName = txtRoleName.Text
                };
                if (InsertOrUpdate == false)    //insert
                {
                    AccountRepository.Insert(acc);
                }
                else
                {
                    acc.AccountId = AccountInfo.AccountId;
                    AccountRepository.Update(acc);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new account" : "Update a account");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
