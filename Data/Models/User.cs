using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class User
    {
        

        public User()
        {
            BorrowRecords = new HashSet<BorrowRecord>();
            BorrowRequests = new HashSet<BorrowRequest>();
            LostBooks = new HashSet<LostBook>();
            Reviews = new HashSet<Review>();
            ViewedBooks = new HashSet<ViewedBook>();
        }

        

        public int UserId { get; set; }
        public string MemberCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Idcard { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<BorrowRecord> BorrowRecords { get; set; }
        public virtual ICollection<BorrowRequest> BorrowRequests { get; set; }
        public virtual ICollection<LostBook> LostBooks { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<ViewedBook> ViewedBooks { get; set; }
    }
}
