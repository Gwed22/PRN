using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Business.BusinessObject
{
    public partial class Category
    {
        public Category()
        {
            Blogs = new HashSet<Blog>();
        }

        public int CateId { get; set; }
        public string CateName { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
