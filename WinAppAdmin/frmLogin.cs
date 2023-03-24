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
    public partial class frmLogin : Form
    {
        IAccountRepository accountRepository = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            accountRepository = new AccountRepository();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Account acc = accountRepository.checkLogin(email, password);
            if (acc != null && acc.RoleName.Equals("ADMIN"))
            {
                this.Hide();
                frmHomeAdmin frmHomeAdmin = new frmHomeAdmin();
                frmHomeAdmin.Show();
            }
            else if (acc != null && acc.RoleName.Equals("USER"))
            {
                MessageBox.Show("This is not an account of Admin! Please check again.", "Login Failed");
            }
            else
            {
                MessageBox.Show("Wrong username or password! Please check again.", "Login Failed");
            }
        }
    }
}
