using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using WebShop.Models.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

[assembly: OwinStartup(typeof(WebShop.App_Start.OwinConfig))]

namespace WebShop.App_Start
{
    public class OwinConfig
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.CreatePerOwinContext<IdentityDBcontext>(IdentityDBcontext.Create);            
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            app.CreatePerOwinContext<AppSignInManager>(AppSignInManager.Create);
            app.CreatePerOwinContext<AppSignInManager>((options, context) => new AppSignInManager(context.GetUserManager<AppUserManager>(), context.Authentication));
            app.CreatePerOwinContext<AppRoleManager>(AppRoleManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Admin/Login"),
                Provider = new CookieAuthenticationProvider()
            });
        }
    }
}
