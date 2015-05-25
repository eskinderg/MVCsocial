using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Authentication.Users
{

    public interface IWebDbContext : IDisposable
    {

    }

    public class WebDbContext : DbContext, IWebDbContext
    {
        public DbSet<AppUser> Users { get; set; }

        public WebDbContext()
            
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mappings
           modelBuilder.Configurations.Add(new UserMapping());

            base.OnModelCreating(modelBuilder);

        }

        public new void Dispose()
        {

        }
    }
}
