using AngularAuthAPI.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAuthAPI.Data
{
    public class UserDbContext: DbContext
        {
            public UserDbContext()
            {
            }

            public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
            {
            }

            public virtual DbSet<User> Users { get; set; }

/*            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                    optionsBuilder.UseSqlServer("Server=LIN24006770\\SQLEXPRESS;Database=Employee;Trusted_Connection=True;");
                }
            }*/

        }
    }
