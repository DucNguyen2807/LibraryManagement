using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BooksRepository : RepositoryBase<Book>
    {
        public bool isPublisherExist(int PublisherID)
        {
            var accounts = GetAll();
            return accounts.Any(a => a.PublisherId == PublisherID);
        }
        public bool isISBNExist(string ISBN)
        {
            var accounts = GetAll();
            return accounts.Any(a => a.Isbn == ISBN);
        }
    }
}
