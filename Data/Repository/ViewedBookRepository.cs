using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ViewedBookRepository : RepositoryBase<ViewedBook>
    {
        public bool isBookExist(int bookID)
        {
            var accounts = GetAll();
            return accounts.Any(a => a.BookId == bookID);
        }

        public bool isMemberCodeExist(string memberCode)
        {
            var accounts = GetAll();
            return accounts.Any(a => a.MemberCode == memberCode);
        }
    }
}
