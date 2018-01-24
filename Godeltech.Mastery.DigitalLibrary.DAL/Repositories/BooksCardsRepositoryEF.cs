using Godeltech.Mastery.DigitalLibrary.DAL.EF;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Repositories
{
    public class BooksCardsRepositoryEF : GenericRepository<BooksCards>
    {
        public BooksCardsRepositoryEF(ApplicationDbContext context) : base(context)
        {
        }
    }
}
