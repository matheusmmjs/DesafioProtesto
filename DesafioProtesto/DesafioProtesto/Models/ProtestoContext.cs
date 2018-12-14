using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProtesto.Models
{
    public class ProtestoContext : DbContext
    {
        public ProtestoContext(DbContextOptions<ProtestoContext> options)
           : base(options)
        { }
        public DbSet<Protesto> Protestos { get; set; }
    }
}
