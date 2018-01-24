using Godeltech.Mastery.DigitalLibrary.DAL.EF;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Repositories
{
    public class GenresRepositoryEF : GenericRepository<Genres>
    {
        public GenresRepositoryEF(ApplicationDbContext context) : base(context)
        {
        }
    }
}
