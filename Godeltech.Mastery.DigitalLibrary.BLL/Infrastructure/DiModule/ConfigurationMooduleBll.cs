using Godeltech.Mastery.DigitalLibrary.DAL.EF;
using Godeltech.Mastery.DigitalLibrary.DAL.Interfaces;
using Godeltech.Mastery.DigitalLibrary.DAL.Repositories;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Infrastructure.DiModule
{
    public class ConfigurationMooduleBll : NinjectModule
    {
        private readonly string _connectionString;
        public ConfigurationMooduleBll(string connectionString)
        {
            _connectionString = connectionString;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(_connectionString);
            Bind<ApplicationDbContext>().ToSelf().InRequestScope();
        }
    }
}
