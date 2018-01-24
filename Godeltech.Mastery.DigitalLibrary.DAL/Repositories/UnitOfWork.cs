using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Godeltech.Mastery.DigitalLibrary.DAL.EF;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;
using Godeltech.Mastery.DigitalLibrary.DAL.Identity;
using Godeltech.Mastery.DigitalLibrary.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed;

        public UnitOfWork(string connectionString)
        {
            _context = new ApplicationDbContext(connectionString);

            UserManager = new ApplicationUserManager(new UserStore<ApplicationUsers>(_context));
            RoleManager = new ApplicationRoleManager(new RoleStore<ApplicationRoles>(_context));

            Genres = new GenresRepositoryEF(_context);
            Books = new BooksRepositoryEF(_context);
            BooksHistories = new BooksHistoriesRepositoryEF(_context);
            BooksCards = new BooksCardsRepositoryEF(_context);
        }
        

        public ApplicationUserManager UserManager { get; }
        public ApplicationRoleManager RoleManager { get; }

        public DbContext Context => _context;

        public IRepository<Genres> Genres { get; }
        public IRepository<Books> Books { get; }
        public IRepository<BooksHistories> BooksHistories { get; }
        public IRepository<BooksCards> BooksCards { get; }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                    UserManager.Dispose();

                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
