using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace UserLogin
{
    public class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }
      

        public UserContext() : base(Properties.Resources.DbConnect)

        {

        }
    }
}