using System.Collections.Generic;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Entities
{
    public class BooksCards
    {
        public int InventoryId { get; set; }
        public double Price { get; set; }
        public string AuthorString { get; set; }
        public string LBC { get; set; }
        public bool AvailabilityStatus { get; set; }

        //foreign kies
        public int BookId { get; set; }

        //Navigation props
        public virtual Books Books { get; set; }
        public virtual ICollection<BooksHistories> BooksHistories { get; set; } = new List<BooksHistories>();
    }
}
