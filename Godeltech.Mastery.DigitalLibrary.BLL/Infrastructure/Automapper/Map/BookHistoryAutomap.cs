using AutoMapper;
using Godeltech.Mastery.DigitalLibrary.BLL.Domain.DTO;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Infrastructure.Automapper.Map
{
    internal class BookHistoryAutomap : Profile
    {
        internal BookHistoryAutomap()
        {
            CreateMap<BooksHistories, BookHistoryDto>();
        }
    }
}
