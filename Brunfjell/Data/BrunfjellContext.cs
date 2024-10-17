using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Brunfjell.Models;

namespace Brunfjell.Data
{
    public class BrunfjellContext : DbContext
    {
        public BrunfjellContext (DbContextOptions<BrunfjellContext> options)
            : base(options)
        {
        }

        public DbSet<Brunfjell.Models.Gallery> Gallery { get; set; } = default!;
    }
}
