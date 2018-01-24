using System;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Domain.DTO
{
    public class BookHistoryDto
    {
        public int BookHistoryId { get; set; }
        public string UserName { get; set; }
        public string BookName { get; set; }
        public string Publishing { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturningDate { get; set; }
    }
}
