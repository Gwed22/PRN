using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Business.BusinessObject
{
    public partial class Account
    {
        public Account()
        {
            Comments = new HashSet<Comment>();
        }

        public int AccountId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
