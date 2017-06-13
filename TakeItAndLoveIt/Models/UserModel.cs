using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TakeItAndLoveIt.Models
{
    public class UserModel : IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public override string Email { get; set; }
        public string Name { get; set; }
        public List<Company> Companies;
    }
}