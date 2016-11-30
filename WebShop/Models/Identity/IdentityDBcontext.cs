using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebShop.Models.Identity
{
    public class IdentityDBcontext: IdentityDbContext<AppUser>
    {
        public IdentityDBcontext() : base("name=IdentityConcetion") { }
        static IdentityDBcontext()
        {
            Database.SetInitializer<IdentityDBcontext>(new IdentityDbInit());   // when I gonna obj form IdContext using IdDbInit
        }

        public static IdentityDBcontext Create()
        {
            return new IdentityDBcontext();
        }
    }

    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<IdentityDBcontext> //Drop and Updata Database
    {
        protected override void Seed(IdentityDBcontext context)
        { PerformInitialSetup(context); base.Seed(context); }

        public void PerformInitialSetup(IdentityDBcontext context) { }
    }
}