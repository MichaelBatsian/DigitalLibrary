using Godeltech.Mastery.DigitalLibrary.DAL.EF;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Repositories
{
    public  class BooksHistoriesRepositoryEF : GenericRepository<BooksHistories>
    {
        public BooksHistoriesRepositoryEF(ApplicationDbContext context) : base(context)
        {
        }
    }
}
