using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Business.BusinessObject
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int BlogId { get; set; }
        public int AccountId { get; set; }
        public string Context { get; set; }

        public virtual Account Account { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
