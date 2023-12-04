using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int BookId { get; set; }
        public string MemberCode { get; set; }
        public DateTime ReviewDate { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public virtual Book Book { get; set; }
        public virtual User MemberCodeNavigation { get; set; }
    }
}
