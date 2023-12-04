using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class BorrowRecord
    {
        public int RecordId { get; set; }
        public int BookId { get; set; }
        public string MemberCode { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public string ReturnStatus { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual User MemberCodeNavigation { get; set; }
    }
}
