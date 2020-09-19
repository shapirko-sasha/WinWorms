using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_WinForm_.Classes
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("GameConnection")
        {
        }

        public DbSet<DBUser> Users { get; set; }
        public DbSet<UserRezalts> UserRezalts { get; set; }
    }
}
