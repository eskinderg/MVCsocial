using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Models
{
    public class Register
    {
        [Required]
        public string Username { get; set; }
        
        [EmailAddress]
        public string EMail { get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage="Password Did Not Match")]
        public string ConfirmPassword { get; set; }


    }
}
