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
    public partial class frmBlogManagement : Form
    {
        IBlogRepository blogRepository = new BlogRepository();

        //Create a data source
        BindingSource source;
        public frmBlogManagement()
        {
            InitializeComponent();
        }

        private void frmBlogManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmBlogDetails frmBlogDetails = new frmBlogDetails
            {
                Text = "Update Blog",
                InsertOrUpdate = true,
                BlogInfo = GetBlogObject(),
                BlogRepository = blogRepository
            };
            if (frmBlogDetails.ShowDialog() == DialogResult.OK)
            {
                LoadBlogList();
                //Set focus car updated
                source.Position = source.Count - 1;
            }
        }

        //Clear text of textboxes
        private void ClearText()
        {
            txtBlogID.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtCategory.Text = string.Empty;
        }


        //Get a Blog Object
        private Blog GetBlogObject()
        {
            Blog blog = null;
            try
            {
                blog = blogRepository.GetById(int.Parse(txtBlogID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get blog");
            }
            return blog;
        }

        public void LoadBlogList()
        {
            var blogs = blogRepository.GetAll();
            try
            {
                source = new BindingSource();
                source.DataSource = blogs;

                txtBlogID.DataBindings.Clear();
                txtTitle.DataBindings.Clear();
                txtCategory.DataBindings.Clear();
                txtDate.DataBindings.Clear();

                txtBlogID.DataBindings.Add("Text", source, "BlogID");
                txtTitle.DataBindings.Add("Text", source, "Title");
                txtCategory.DataBindings.Add("Text", source, "CateID");
                txtDate.DataBindings.Add("Text", source, "DatePost");

                dgvBlogList.DataSource = null;
                dgvBlogList.DataSource = source;
                if (blogs.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load blog list");
            }
        }

        //button New
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmBlogDetails frmBlogDetails = new frmBlogDetails
            {
                Text = "Add blog",
                InsertOrUpdate = false,
                BlogRepository = blogRepository
            };
            if (frmBlogDetails.ShowDialog() == DialogResult.OK)
            {
                LoadBlogList();
                //Set focus blog inserted
                source.Position = source.Count - 1;
            }
        }

        //button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var blog = GetBlogObject();
                blogRepository.Remove(blog.BlogId);
                LoadBlogList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a blog");
            }
        }

        //button Close
        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBlogList();
        }
    }
}
