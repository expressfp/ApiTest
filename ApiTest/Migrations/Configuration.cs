namespace ApiTest.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiTest.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApiTest.Models.ApplicationDbContext context)
        {
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "expressfp",
            //    Email = "richardheeth@gmail.com",
            //    EmailConfirmed = true,
            //    FirstName = "Richard",
            //    LastName = "Heeth"
            //};

            //manager.Create(user, "MySuperP@ssword!");
        }
    }
}
