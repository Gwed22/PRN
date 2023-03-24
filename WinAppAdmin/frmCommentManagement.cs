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
    public partial class frmCommentManagement : Form
    {
        ICommentRepository commentRepository = new CommentRepository();

        //Create a data source
        BindingSource source;
        public frmCommentManagement()
        {
            InitializeComponent();
        }

        private void frmCommentManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        //Clear text of textboxes
        private void ClearText()
        {
            txtCommentID.Text = string.Empty;
            txtAccountName.Text = string.Empty;
            txtBlogID.Text = string.Empty;
            txtContext.Text = string.Empty;
        }


        //Get a Comment Object
        private Comment GetCommentObject()
        {
            Comment com = null;
            try
            {
                com = new Comment
                {
                    CommentId = int.Parse(txtCommentID.Text),
                    AccountId = int.Parse(txtAccountID.Text),
                    BlogId = int.Parse(txtBlogID.Text),
                    Context = txtContext.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get comment");
            }
            return com;
        }

        public void LoadCommentList()
        {
            var coms = commentRepository.GetAll();
            try
            {
                source = new BindingSource();
                source.DataSource = coms;

                txtCommentID.DataBindings.Clear();
                txtAccountID.DataBindings.Clear();
                txtAccountName.DataBindings.Clear();
                txtBlogID.DataBindings.Clear();
                txtContext.DataBindings.Clear();

                txtCommentID.DataBindings.Add("Text", source, "CommentID");
                txtAccountID.DataBindings.Add("Text", source, "AccountID");
                txtAccountName.DataBindings.Add("Text", source, "Account.FullName");
                txtBlogID.DataBindings.Add("Text", source, "BlogID");
                txtContext.DataBindings.Add("Text", source, "Context");

                dgvCommentList.DataSource = null;
                dgvCommentList.DataSource = source;
                if (coms.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load comment list");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCommentList();
        }

        //button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var com = GetCommentObject();
                commentRepository.Remove(com.CommentId);
                LoadCommentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a comment");
            }
        }

        //button Close
        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            var coms = commentRepository.GetByAccountName(query);
            try
            {
                source = new BindingSource();
                source.DataSource = coms;

                txtCommentID.DataBindings.Clear();
                txtAccountID.DataBindings.Clear();
                txtAccountName.DataBindings.Clear();
                txtBlogID.DataBindings.Clear();
                txtContext.DataBindings.Clear();

                txtCommentID.DataBindings.Add("Text", source, "CommentID");
                txtAccountID.DataBindings.Add("Text", source, "AccountID");
                txtAccountName.DataBindings.Add("Text", source, "Account.FullName");
                txtBlogID.DataBindings.Add("Text", source, "BlogID");
                txtContext.DataBindings.Add("Text", source, "Context");

                dgvCommentList.DataSource = null;
                dgvCommentList.DataSource = source;
                if (coms.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load comment list");
            }
        }
    }
}
