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
    public partial class frmHomeAdmin : Form
    {
        public frmHomeAdmin()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            frmBlogManagement frmBlogManagement = new frmBlogManagement();
            frmBlogManagement.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmAccountManagement frmAccountManagement = new frmAccountManagement();
            frmAccountManagement.Show();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            frmCommentManagement frmCommentManagement = new frmCommentManagement();
            frmCommentManagement.Show();
        }
    }
}
