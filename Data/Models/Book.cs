using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Book
    {
        public Book()
        {
            BookLocations = new HashSet<BookLocation>();
            BorrowRecords = new HashSet<BorrowRecord>();
            BorrowRequests = new HashSet<BorrowRequest>();
            LostBooks = new HashSet<LostBook>();
            Reviews = new HashSet<Review>();
            ViewedBooks = new HashSet<ViewedBook>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string Isbn { get; set; }
        public int Quantity { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int? PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<BookLocation> BookLocations { get; set; }
        public virtual ICollection<BorrowRecord> BorrowRecords { get; set; }
        public virtual ICollection<BorrowRequest> BorrowRequests { get; set; }
        public virtual ICollection<LostBook> LostBooks { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<ViewedBook> ViewedBooks { get; set; }
    }
}
