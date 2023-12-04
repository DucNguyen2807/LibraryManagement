using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class BookLocation
    {
        public int LocationId { get; set; }
        public int BookId { get; set; }
        public int Shelf { get; set; }
        public int RowShelf { get; set; }
        public int ColumnShelf { get; set; }

        public virtual Book Book { get; set; }
    }
}
