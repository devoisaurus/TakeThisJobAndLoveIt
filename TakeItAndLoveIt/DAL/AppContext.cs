using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TakeItAndLoveIt.Models;

namespace TakeItAndLoveIt.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("TakeItLoveIt") { }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
    }
}