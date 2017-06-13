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

        public DbSet<UserModel> Users;
        public DbSet<Company> Companies;
        public DbSet<Interaction> Interactions;
    }
}