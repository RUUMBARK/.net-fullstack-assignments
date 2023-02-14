using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Day3_MVC_.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base() { }
        public DbSet<User> Users { get; set; }
    }

}