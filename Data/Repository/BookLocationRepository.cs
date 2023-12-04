using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookLocationRepository : RepositoryBase<BookLocation>
    {
        public bool IsLocationEmpty(BookLocation bookLocation)
        {
            return !GetAll().Any(location =>
                location.Shelf == bookLocation.Shelf &&
                location.ColumnShelf == bookLocation.ColumnShelf &&
                location.RowShelf == bookLocation.RowShelf);
        }

        public bool DeleteLocation(int locationId)
        {
            BookLocation? bookLocation = GetLocationById(locationId);
            if (bookLocation != null)
            {
                Delete(bookLocation);
                return true;
            }

            return false;
        }
        public BookLocation? GetLocationById(int locationId)
        {
            return GetAll().FirstOrDefault(x => x.LocationId == locationId);
        }


    }
}
