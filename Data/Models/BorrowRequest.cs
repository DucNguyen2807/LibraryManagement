using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class BorrowRequest
    {
        public int RequestId { get; set; }
        public int BookId { get; set; }
        public string MemberCode { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }

        public virtual Book Book { get; set; }
        public virtual User MemberCodeNavigation { get; set; }
    }
}
