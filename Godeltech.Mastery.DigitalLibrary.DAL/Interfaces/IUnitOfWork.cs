using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;
using Godeltech.Mastery.DigitalLibrary.DAL.Identity;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; } 
        ApplicationRoleManager RoleManager { get; }
        DbContext Context { get; }
        IRepository<Genres> Genres { get; }
        IRepository<Books> Books { get; }
        IRepository<BooksHistories> BooksHistories { get; }
        IRepository<BooksCards> BooksCards { get; }
        void Save();
        Task SaveAsync();
    }
}
