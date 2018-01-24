
using System.Data.Entity;
using Godeltech.Mastery.DigitalLibrary.DAL.EF;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Repositories
{
    public class BooksRepositoryEF : GenericRepository<Books>
    {
        public BooksRepositoryEF(ApplicationDbContext context) : base(context)
        {
        }
    }
}
