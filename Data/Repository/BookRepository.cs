using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookRepository : RepositoryBase<Book>
    {
        public BookRepository() { }

        public int GetBookIdByTitle(string title)
        {
            var book = GetAll().SingleOrDefault(x => x.Title == title);
            if (book != null)
            {
                return book.BookId;
            }

            return -1;
        }
    }
}
