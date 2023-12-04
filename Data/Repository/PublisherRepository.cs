using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PublisherRepository : RepositoryBase<Publisher>
    {
        public bool isPublisherExist(int PublisherID)
        {
            var publishers = GetAll();
            return publishers.Any(a => a.PublisherId == PublisherID);
        }
    }
}
