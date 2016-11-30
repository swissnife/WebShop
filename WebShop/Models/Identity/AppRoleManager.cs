using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models.Identity
{
    public class AppRoleManager:RoleManager<IdentityRole>
    {
        public AppRoleManager(IRoleStore<IdentityRole,string> rolestore ) : base(rolestore)
        {

        }

        public static AppRoleManager Create(IdentityFactoryOptions<AppRoleManager> options ,IOwinContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context.Get<IdentityDBcontext>());
            return new AppRoleManager(roleStore);
        }
       
    }
}