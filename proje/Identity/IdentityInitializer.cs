using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace proje.Identity
{
    public class IdentityInitializer:CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if(!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user" };
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "secilakekmekci"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "secil", Surname = "akekmekci", Email = "secilakekmekci.9@gmail.com", UserName = "secilakekmekci" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id,"admin");
                manager.AddToRole(user.Id, "user");

            }


            if (!context.Users.Any(i => i.Name == "kutayakekmekci"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "kutay", Surname = "akekmekci", Email = "kutayakekmekci@gmail.com", UserName = "kutayakekmekci" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");

            }












            base.Seed(context);
        }
    }
}