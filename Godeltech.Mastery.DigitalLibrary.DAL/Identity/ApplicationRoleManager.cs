using Godeltech.Mastery.DigitalLibrary.DAL.EF;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Identity
{
    public class ApplicationRoleManager : RoleManager<ApplicationRoles>
    {
        public ApplicationRoleManager(RoleStore<ApplicationRoles> store) : base(store) { }

        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options,
            IOwinContext context)
        {
            return new ApplicationRoleManager(new RoleStore<ApplicationRoles>(context.Get<ApplicationDbContext>()));
        }

    }
}
