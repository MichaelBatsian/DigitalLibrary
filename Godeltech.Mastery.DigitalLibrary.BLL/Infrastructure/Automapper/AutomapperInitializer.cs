using AutoMapper;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Infrastructure.Automapper
{
    public class AutomapperInitializer
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                //cfg.AddProfile(new CatalogsAutoMap());
                //cfg.AddProfile(new FilesAutoMap());
                //cfg.AddProfile(new UsersAutoMap());
                //cfg.AddProfile(new UsersAdminAutoMap());
            });
        }
    }
}
