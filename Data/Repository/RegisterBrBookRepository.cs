using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RegisterBrBookRepository : RepositoryBase<Book>
    {
        private LibraryManagementContext _context;

        public RegisterBrBookRepository()
        {
            _context = new LibraryManagementContext();
        }

        public IEnumerable<Book> GetAllBooks()
        {

            return _context.Books.ToList();
        }
        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(book => book.BookId == id);
        }
    }
}
