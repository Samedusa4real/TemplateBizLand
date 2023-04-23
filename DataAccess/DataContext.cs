using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TemplateBizLand.Models;

namespace TemplateBizLand.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Features> Features { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
    
    }
}
