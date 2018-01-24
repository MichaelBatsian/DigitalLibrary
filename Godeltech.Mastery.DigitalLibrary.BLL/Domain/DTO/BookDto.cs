using System;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Domain.DTO
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublishingYear { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
    }
}
