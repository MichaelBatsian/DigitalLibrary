using System;
using System.Collections.Generic;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Entities
{
    public class Books
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublishingYear { get; set; }
        public string Publisher { get; set; }
        //public byte [] Image { get; set; }

        //foreign kies
        public int GenreId { get; set; }

        //navigation props
        public virtual Genres Genre { get; set; }
        public virtual ICollection<BooksCards> BooksCards { get; set; } = new List<BooksCards>();
   }
}
