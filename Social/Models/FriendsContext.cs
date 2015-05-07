using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Social.Models;
using System.Data.Entity;

namespace Social.Models
{
    public class UserFriendsContext:DbContext
    {
        public DbSet<UserFriends> UserFriends { get; set; }
    }
}