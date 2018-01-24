using System.Collections.Generic;
using System.Linq;
using Godeltech.Mastery.DigitalLibrary.BLL.Domain;
using Godeltech.Mastery.DigitalLibrary.BLL.Domain.DTO;
using Godeltech.Mastery.DigitalLibrary.BLL.Interfaces;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Impl
{
    public class BookCartService : IBookCartService
    {
        private readonly List<BookCart> _books;
    
        public BookCartService()
        {
            _books = new List<BookCart>();
        }

        public ICollection<BookCart> Books { get; set; }

        //Add item to the cart
        public void Add(BookDto bookDto)
        {
            var book = _books.Find(bc => bc.BookDto.BookId == bookDto.BookId);
            if (book == null)
            {
                _books.Add(new BookCart { BookDto = bookDto, Quantity = 1 });
            }
            else
            {
                book.Quantity++;
            }
        }

        //Remove item from the cart
        public void Remove(BookDto bookDto)
        {
            var book = _books.Find(bc => bc.BookDto.BookId == bookDto.BookId);
            if (book.Quantity == 1)
            {
                _books.Remove(book);
            }
            else
            {
                book.Quantity--;
            }
        }
        //Clear cart
        public void Clear()
        {
            _books.Clear();
        }

        public int GetTotalCount()
        {
            return _books.Sum(i => i.Quantity);
        }

        public IEnumerable<BookCart> GetItems()
        {
            return _books;
        }
    }
}
