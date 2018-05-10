using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commanders
{
    class CommandersDbContext : DbContext
    {
        public DbSet<Commander> Commanders { get; set; }
    }
}
