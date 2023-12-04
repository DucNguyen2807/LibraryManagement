using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BorrowBookRepository : RepositoryBase<BorrowRecord>
    {
        public BorrowBookRepository() { }

        public bool DeleteBorrowRecord(int id)
        {
            var record = GetAll().SingleOrDefault(x => x.RecordId == id);
            if (record != null)
            {
                Delete(record);
                return true;
            }
            return false;
        }

        public BorrowRecord GetBorrowRecord(int id)
        {
            var record = GetAll().FirstOrDefault(x => x.RecordId == id);
            if (record != null)
            {
                return record;
            }
            return null;
        }


    }
}
