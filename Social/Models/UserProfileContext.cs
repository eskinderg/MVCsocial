using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Models
{
    public interface IUserProfileContext
    {
         DbSet<UserProfile> UserProfile { get; set; }


         int SaveChanges();
    }


    public class UserProfileContext : DbContext, IUserProfileContext
    {
        public DbSet<UserProfile> UserProfile { get; set; }

        public override int SaveChanges() { return base.SaveChanges(); }

        //public System.Data.Entity.DbSet<Social.Models.Login> Logins { get; set; }
    }
}
