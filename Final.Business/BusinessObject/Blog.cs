using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Business.BusinessObject
{
    public partial class Blog
    {
        public Blog()
        {
            Comments = new HashSet<Comment>();
        }

        public int BlogId { get; set; }
        public string BlogContext { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Decs { get; set; }
        public int? CateId { get; set; }
        public DateTime? DatePost { get; set; }

        public virtual Category Cate { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
