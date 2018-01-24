using System.Collections.Generic;
using Godeltech.Mastery.DigitalLibrary.BLL.Domain;
using Godeltech.Mastery.DigitalLibrary.BLL.Domain.DTO;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Interfaces
{
    public interface IBookCartService
    {
        ICollection<BookCart> Books { get; set; }
        void Add(BookDto bookDto);
        void Remove(BookDto bookDto);
        void Clear();
        int GetTotalCount();
        IEnumerable<BookCart> GetItems();
    }
}
