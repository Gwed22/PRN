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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppAdmin
{
    public partial class frmBlogDetails : Form
    {

        public IBlogRepository BlogRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // False = insert; True = update
        public Blog BlogInfo { get; set; }
        public frmBlogDetails()
        {
            InitializeComponent();
        }

        private void frmBlogDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                // Show blogount info to update
                txtTitle.Text = BlogInfo.Title;
                txtDate.Text = BlogInfo.DatePost.ToString();
                txtCategory.SelectedIndex = 0;
                txtImage.Text = BlogInfo.Img;
                txtDesc.Text = BlogInfo.Decs;
                txtContent.Text = BlogInfo.BlogContext;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string cateString = txtCategory.SelectedItem.ToString();
            try
            {
                var blog = new Blog
                {
                    BlogId = 0,
                    Title = txtTitle.Text,
                    BlogContext = txtContent.Text,
                    Img = txtImage.Text,
                    Decs = txtDesc.Text,
                    DatePost = Convert.ToDateTime(txtDate.Value.ToString("yyyy-MM-dd")),
                    CateId = int.Parse(cateString.Substring(0, 1))
                };
                if (InsertOrUpdate == false)    //insert
                {
                    BlogRepository.Insert(blog);
                }
                else
                {
                    blog.BlogId = BlogInfo.BlogId;
                    BlogRepository.Update(blog);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new blogount" : "Update a blogount");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
