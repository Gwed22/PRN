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
    public partial class frmAccountManagement : Form
    {
        IAccountRepository accountRepository = new AccountRepository();

        //Create a data source
        BindingSource source;
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAccountDetails frmAccountDetails = new frmAccountDetails
            {
                Text = "Update Account",
                InsertOrUpdate = true,
                AccountInfo = GetAccountObject(),
                AccountRepository = accountRepository
            };
            if (frmAccountDetails.ShowDialog() == DialogResult.OK)
            {
                LoadAccountList();
                //Set focus car updated
                source.Position = source.Count - 1;
            }
        }

        //Clear text of textboxes
        private void ClearText()
        {
            txtAccountID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRoleName.Text = string.Empty;
        }


        //Get a Account Object
        private Account GetAccountObject()
        {
            Account acc = null;
            try
            {
                acc = new Account
                {
                    AccountId = int.Parse(txtAccountID.Text),
                    FullName = txtFullName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    RoleName = txtRoleName.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get account");
            }
            return acc;
        }

        public void LoadAccountList()
        {
            var accs = accountRepository.GetAll();
            try
            {
                source = new BindingSource();
                source.DataSource = accs;

                txtAccountID.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtRoleName.DataBindings.Clear();

                txtAccountID.DataBindings.Add("Text", source, "AccountID");
                txtFullName.DataBindings.Add("Text", source, "FullName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtRoleName.DataBindings.Add("Text", source, "RoleName");

                dgvAccountList.DataSource = null;
                dgvAccountList.DataSource = source;
                if (accs.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load account list");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        //button New
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAccountDetails frmAccountDetails = new frmAccountDetails
            {
                Text = "Add account",
                InsertOrUpdate = false,
                AccountRepository = accountRepository
            };
            if (frmAccountDetails.ShowDialog() == DialogResult.OK)
            {
                LoadAccountList();
                //Set focus account inserted
                source.Position = source.Count - 1;
            }
        }

        //button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var acc = GetAccountObject();
                accountRepository.Remove(acc.AccountId);
                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a account");
            }
        }

        //button Close
        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
