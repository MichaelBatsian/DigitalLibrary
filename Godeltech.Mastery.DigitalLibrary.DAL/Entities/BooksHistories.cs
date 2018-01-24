using System;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Entities
{
    public class BooksHistories
    {
        public int BookHistoryId { get; set; }
        public int BookCardId { get; set; }
        public string UserId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturningDate { get; set; }

        //navigation props
        public virtual BooksCards BooksCards { get; set; }
        public virtual ApplicationUsers Users { get; set; }
    }
}
