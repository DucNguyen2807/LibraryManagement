using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ReviewRepository : RepositoryBase<Review>
    {
        private LibraryManagementContext _context;

        public ReviewRepository()
        {
            _context = new LibraryManagementContext();
        }
        public IEnumerable<Review> GetAllReviews()
        {

            return _context.Reviews.ToList();
        }
        public Review GetReviewById(int id)
        {
            return _context.Reviews.FirstOrDefault(review => review.ReviewId == id);
        }

    }
}
