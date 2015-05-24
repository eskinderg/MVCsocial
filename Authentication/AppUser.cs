using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Authentication
{
    [Table("AspNetUsers")]
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }
        

        public string ProfilePicture { get; set; }

    }

    //public class AppUserDbContext : DbContext
    //{
    //    public AppUserDbContext() : base("DBconn") { }

    //    public DbSet<AppUser> Users { get; set; }

    //}
}