using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class LostBook
    {
        public int LostId { get; set; }
        public int BookId { get; set; }
        public string MemberCode { get; set; }
        public DateTime LostDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual User MemberCodeNavigation { get; set; }
    }
}
