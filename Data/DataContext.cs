using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_api_dnet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
 
        }
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Skill> Skills => Set<Skill>();

    }

} 