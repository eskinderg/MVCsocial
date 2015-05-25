using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Users
{
    public class UserMapping : EntityTypeConfiguration<AppUser>
    {
        public UserMapping()
        {
            //this.HasKey(x => x.Id);
            this.ToTable("AspNetUsers"); // map to Articles table in database
        }
    }
}
