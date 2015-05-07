using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Social.Models
{
    public class UserFriends
    {
        public int UserId { get; set; }

        public int FriendId { get; set; }
    }
}