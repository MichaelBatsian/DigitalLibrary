using System.Data.Entity;
using Godeltech.Mastery.DigitalLibrary.DAL.EF.Map;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Godeltech.Mastery.DigitalLibrary.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers>
    {
        static ApplicationDbContext ()
        {
            Database.SetInitializer(new DigitalLibraryDbInitializer());
        }

        public ApplicationDbContext(string name = "DigitalLibraryConnection") : base(name, throwIfV1Schema: false) { } 

        public DbSet<Genres> Genres { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<BooksCards> BooksCardses { get; set; }
        public DbSet<BooksHistories> BooksHistories { get; set; }

        public static ApplicationDbContext Create()
        {
            var context = new ApplicationDbContext();
            CheckRoles(context);
            return context;
        }
        private static void CheckRoles(ApplicationDbContext context)
        {
            //create managers of the role an users
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUsers>(new UserStore<ApplicationUsers>(context));
          
            //find role of admin
            var roleAdmin = roleManager.FindByName("admin");
            if (roleAdmin == null)
            {
                roleAdmin = new IdentityRole { Name = "admin" };
                roleManager.Create(roleAdmin);
            }

            //find role of user
            var roleUser = roleManager.FindByName("user");
            if (roleUser == null)
            {
                roleUser = new IdentityRole { Name = "user" };
                roleManager.Create(roleUser);
            }
            //to search user admin@mail.ru
            var userAdmin = userManager.FindByEmail("admin@mail.ru");
            if (userAdmin == null)
            {
                userAdmin = new ApplicationUsers
                {
                    //NickName = "admin",
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                userManager.Create(userAdmin, "123456");
                userManager.AddToRole(userAdmin.Id, "admin");
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BooksMap());
            modelBuilder.Configurations.Add(new BooksCardsMap());
            modelBuilder.Configurations.Add(new BooksHistoriesMap());
            modelBuilder.Configurations.Add(new GenresMap());
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public class DigitalLibraryDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
        {
            protected override void Seed(ApplicationDbContext context)
            {
                //context.Roles.Add(new Roles() { RoleName = "admin" });
                //context.Roles.Add(new Roles() { RoleName = "user" });
                //context.Users.Add(new Users()
                //{
                //    Login = "Misha",
                //    Password = "$2a$10$NMPkH49JfNxrrxFUOImmzOyEBBKlxDZPzbThcHv30aV2aysDWZq1u",
                //    CreationDate = DateTime.Now,
                //    UserRole = "admin"
                //});
                //1
                //context.Catalogs.Add(new Catalogs()
                //{
                //    Name = "music",
                //    CreationDate = DateTime.Now,
                //    ModificationDate = DateTime.Now,
                //    Level = 0,
                //    ParentId = null,
                //    UserLogin = "Misha"
                //});
                ////2
                //context.Catalogs.Add(new Catalogs()
                //{
                //    Name = "rock",
                //    CreationDate = DateTime.Now,
                //    ModificationDate = DateTime.Now,
                //    Level = 1,
                //    ParentId = 1,
                //    UserLogin = "Misha"
                //});
                ////3
                //context.Catalogs.Add(new Catalogs()
                //{
                //    Name = "metall",
                //    CreationDate = DateTime.Now,
                //    ModificationDate = DateTime.Now,
                //    Level = 1,
                //    ParentId = 1,
                //    UserLogin = "Misha"
                //});
                ////4
                //context.Catalogs.Add(new Catalogs()
                //{
                //    Name = "aria",
                //    CreationDate = DateTime.Now,
                //    ModificationDate = DateTime.Now,
                //    Level = 2,
                //    ParentId = 2,
                //    UserLogin = "Misha"
                //});
                ////5
                //context.Catalogs.Add(new Catalogs()
                //{
                //    Name = "documents",
                //    CreationDate = DateTime.Now,
                //    ModificationDate = DateTime.Now,
                //    Level = 0,
                //    ParentId = null,
                //    UserLogin = "Misha"
                //});
                ////6
                //context.Catalogs.Add(new Catalogs()
                //{
                //    Name = "work",
                //    CreationDate = DateTime.Now,
                //    ModificationDate = DateTime.Now,
                //    Level = 1,
                //    ParentId = 5,
                //    UserLogin = "Misha"
                //});
            }
        }
    }
}
