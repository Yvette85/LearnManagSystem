using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LearnManagSystem.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Course> Courses { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<ActivityType> ActivityTypes { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<UMessage> UMessages { get; set; }

        public ApplicationDbContext()

                : base("DefaultConnection", throwIfV1Schema: false)

        {

        }



        public static ApplicationDbContext Create()

        {

            return new ApplicationDbContext();

        }

        public System.Data.Entity.DbSet<LearnManagSystem.ViewModels.AllStudentsView> AllStudentsViews { get; set; }

        public System.Data.Entity.DbSet<LearnManagSystem.ViewModels.AllTeachersView> AllTeachersViews { get; set; }
    }
}
