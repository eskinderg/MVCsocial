using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Host;

namespace Authentication
{
    public class ApplicationUser : IdentityUser      // Implements IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("DBconn")
        {
           
        }
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }*/
    }

    //public class ApplicationRole : IdentityRole
    //{

    //    public ApplicationRole() : base() { }

    //    public ApplicationRole(string name)
    //        : base(name)
    //    {
    //        //this.Description = description;
    //    }

    //    //public virtual string Description { get; set; }

    //}







}
